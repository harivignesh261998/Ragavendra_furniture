using DGVPrinterHelper;
using FurtinureMart.BLL;
using FurtinureMart.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace FurtinureMart.UI
{
	public partial class frmSales : Form
	{
		public frmSales()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		DeaCustDAL dcDAL = new DeaCustDAL();
		productsDAL pDAL = new productsDAL();
		userDAL uDAL = new userDAL();
		transactionDAL tDAL = new transactionDAL();
		transactionDetailDAL tdDAL = new transactionDetailDAL();
		DataTable transactionDT = new DataTable();

		private void frmSales_Load(object sender, EventArgs e)
		{
			string type = frmUserDashboard.transactionType;
			lblTop.Text = type;
			transactionDT.Columns.Add("Product Name");
			transactionDT.Columns.Add("Rate");
			transactionDT.Columns.Add("Quantity");
			transactionDT.Columns.Add("Total");
			transactionDT.Columns.Add("Discount");


		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSearch.Text;
			if (keyword == "")
			{
				txtName.Text = "";
				txtEmail.Text = "";
				txtContact.Text = "";
				txtAddress.Text = "";
				textDisCount.Text = "";
				return;

			}
			DeaCustBLL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);
			txtName.Text = dc.name;
			txtEmail.Text = dc.email;
			txtContact.Text = dc.contact;
			txtAddress.Text = dc.address;

			productsBLL p = pDAL.GetProductsForTransaction(keyword);
			if (p.category == "Chair")
			{ textDisCount.Text = dc.discount1; }
			if (p.category == "Table")
			{ textDisCount.Text = dc.discount2; }
			if (p.category == "Bed")
			{ textDisCount.Text = dc.discount3; }
			if (p.category == "Wardrobe")
			{ textDisCount.Text = dc.discount4; }
			if (p.category == "Shelfing")
			{ textDisCount.Text = dc.discount5; }
		}

		private void txtSearchProduct_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSearchProduct.Text;
			if (keyword == "")
			{
				txtProductName.Text = "";
				txtInventory.Text = "";
				txtRate.Text = "";
				txtQty.Text = "";
				textDisCount.Text = "";
				return;
			}
			productsBLL p = pDAL.GetProductsForTransaction(keyword);
			txtProductName.Text = p.name;

			txtInventory.Text = p.qty.ToString();
			txtRate.Text = p.rate.ToString();
	
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string productName = txtProductName.Text;
			decimal Rate = decimal.Parse(txtRate.Text);
			decimal Qty = decimal.Parse(txtQty.Text);
			decimal Total = Rate * Qty;
			decimal subTotal = decimal.Parse(txtSubTotal.Text);
			subTotal = subTotal + Total;

			if (productName == "")
			{
				MessageBox.Show("Select The Product First Try again");
			}
			else
			{
				transactionDT.Rows.Add(productName, Rate, Qty, Total);
				dgvAddedProducts.DataSource = transactionDT;
				txtSubTotal.Text = subTotal.ToString();
				txtSearchProduct.Text = "";
				txtProductName.Text = "0.00";
				txtInventory.Text = "0.00";
				txtQty.Text = "0.00";

			}
		}

		private void txtDiscount_TextChanged(object sender, EventArgs e)
		{
			
			string value = textDisCount.Text;	
			
			if (value == "")
			{
				MessageBox.Show("Please Add Discount First");

			}
			else
			{
				txtDiscount.Text = textDisCount.Text;
				decimal subTotal = decimal.Parse(txtSubTotal.Text);
				decimal discount = decimal.Parse(textDisCount.Text);
				decimal grandTotal = ((100 - discount) / 100) * subTotal;
				txtGrandTotal.Text = grandTotal.ToString();
			}
		}

		private void txtGST_TextChanged(object sender, EventArgs e)
		{
			string check = txtGrandTotal.Text;
			if (check == "")
			{
				MessageBox.Show("Calculate the discount and set the Grand total first");
			}
			else
			{

				decimal previousGT = decimal.Parse(txtGrandTotal.Text);
				decimal gst = decimal.Parse(txtGST.Text);
				decimal grandTotalWithGSt = ((100 + gst) / 100) * previousGT;
				txtGrandTotal.Text = grandTotalWithGSt.ToString();
			}
		}

		private void txtPaidAmount_TextChanged(object sender, EventArgs e)
		{
			decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
			decimal paidAmount = decimal.Parse(txtPaidAmount.Text);
			decimal returnAmount = paidAmount - grandTotal;
			txtReturnAmount.Text = returnAmount.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			transactionsBLL transaction = new transactionsBLL();

			transaction.type = lblTop.Text;



			string deaCustName = txtName.Text;
			DeaCustBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);

			transaction.dea_cust_id = dc.id;
			transaction.grandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text), 2);
			transaction.transaction_date = DateTime.Now;
			transaction.tax = decimal.Parse(txtGST.Text);
			transaction.discount = decimal.Parse(textDisCount.Text);


			string username = frmLogin.loggedIn;
			userBLL u = uDAL.GetIDFromUsername(username);

			/*transaction.added_by = u.id;*/
			transaction.transactionDetails = transactionDT;


			bool success = false;


			using (TransactionScope scope = new TransactionScope())
			{
				int transactionID = -1;

				bool w = tDAL.Insert_Transaction(transaction, out transactionID);


				for (int i = 0; i < transactionDT.Rows.Count; i++)
				{

					transactionDetailBLL transactionDetail = new transactionDetailBLL();

					string ProductName = transactionDT.Rows[i][0].ToString();
					productsBLL p = pDAL.GetProductIDFromName(ProductName);

					transactionDetail.product_id = p.id;
					transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
					transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
					transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
					transactionDetail.dea_cust_id = dc.id;
					transactionDetail.added_date = DateTime.Now;
					/*transactionDetail.added_by = u.id;*/


					string transactionType = lblTop.Text;


					bool x = false;
										

						
					
					if (transactionType == "SALES")
					{

						x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
					}


					bool y = tdDAL.InsertTransactionDetail(transactionDetail);
					success = w && x && y;
				}
				if (success == true)
				{

					scope.Complete();


					DGVPrinter printer = new DGVPrinter();

					printer.Title = "\r\n\r\n\r\n RAGAVENDRA PVT. LTD. \r\n\r\n";
					printer.SubTitle = "India, Coimbatore \r\n Phone: 01-045XXXX \r\n\r\n";
					printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
					printer.PageNumbers = true;
					printer.PageNumberInHeader = false;
					printer.PorportionalColumns = true;
					printer.HeaderCellAlignment = StringAlignment.Near;
					printer.Footer = "Discount: " + textDisCount.Text + "% \r\n" + "VAT: " + txtGST.Text + "% \r\n" + "Grand Total: " + txtGrandTotal.Text + "\r\n\r\n" + "Thank you for doing business with us.";
					printer.FooterSpacing = 15;
					printer.PrintDataGridView(dgvAddedProducts);

					MessageBox.Show("Transaction Completed Sucessfully");

					dgvAddedProducts.DataSource = null;
					dgvAddedProducts.Rows.Clear();

					txtSearch.Text = "";
					txtName.Text = "";
					txtEmail.Text = "";
					txtContact.Text = "";
					txtAddress.Text = "";
					txtSearchProduct.Text = "";
					txtProductName.Text = "";
					txtInventory.Text = "0";
					txtRate.Text = "0";
					txtQty.Text = "0";
					txtSubTotal.Text = "0";
					txtDiscount.Text = "0";
					txtGST.Text = "0";
					txtGrandTotal.Text = "0";
					txtPaidAmount.Text = "0";
					txtReturnAmount.Text = "0";
				}
				else
				{

					MessageBox.Show("Transaction Failed");
				}

			}
		}

		private void lblRate_Click(object sender, EventArgs e)
		{

		}

		private void lblProductName_Click(object sender, EventArgs e)
		{

		}

		private void txtInventory_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
