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
using System.Windows.Forms;

namespace FurtinureMart.UI
{
	public partial class frmProducts : Form
	{
		public frmProducts()
		{
			InitializeComponent();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		categoriesDAL cdal = new categoriesDAL();
		productsBLL p = new productsBLL();
		productsDAL pdal = new productsDAL();
		userDAL udal = new userDAL();



		private void frmProducts_Load(object sender, EventArgs e)
		{
			DataTable categoriesDT = cdal.Select();
			cmbCategory.DataSource = categoriesDT;
			cmbCategory.DisplayMember = "title";
			cmbCategory.ValueMember = "title";
			DataTable dt = pdal.Select();
			dgvProducts.DataSource = dt;

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			p.id = txtId.Text;
			p.name = txtName.Text;
			p.category = cmbCategory.Text;
			
			p.rate = decimal.Parse(txtRate.Text);
			p.qty = 0;
			//p.added_date = DateTime.Now;
			String loggedUser = frmLogin.loggedIn;
			userBLL usr = udal.GetIDFromUsername(loggedUser);
			/*p.added_by = usr.id;*/
			bool success = pdal.Insert(p);
			if (success == true)
			{
				MessageBox.Show("Product added successfully");
				Clear();
				DataTable dt = pdal.Select();
				dgvProducts.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed to add new product");
			}
			



		}
		public void Clear()
		{
			txtId.Text = "";
			txtName.Text = "";
			
			txtRate.Text = "";
			txtSearch.Text = "";
		}

		private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowIndex = e.RowIndex;
			txtId.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
			txtName.Text= dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
			cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
			txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			p.id = txtId.Text;
			p.name = txtName.Text;
			p.category = cmbCategory.Text;
			
			p.rate = decimal.Parse(txtRate.Text);
			//p.added_date = DateTime.Now;
			String loggedUser = frmLogin.loggedIn;
			userBLL usr = udal.GetIDFromUsername(loggedUser);
			/*p.added_by = usr.id;*/
			bool success = pdal.Update(p);
			if (success == true)
			{
				MessageBox.Show("Product Successfully Updated");
				Clear();
				DataTable dt = pdal.Select();
				dgvProducts.DataSource = dt;

			}
			else
			{
				MessageBox.Show("Failed to updtae");
			}


		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			p.id = txtId.Text;
			bool success = pdal.Delete(p);
			if (success == true)
			{
				MessageBox.Show("Product Deleted successfully");
				Clear();
				DataTable dt = pdal.Select();
				dgvProducts.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed to delete");
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string keywords = txtSearch.Text;
			if (keywords != null)
			{
				DataTable dt = pdal.Search(keywords);
				dgvProducts.DataSource = dt;
			

			}
			else
			{
				DataTable dt = pdal.Select();
				dgvProducts.DataSource = dt;

			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lblName_Click(object sender, EventArgs e)
		{

		}

		private void txtId_TextChanged(object sender, EventArgs e)
		{

		}

		private void lbldiscount_Click(object sender, EventArgs e)
		{

		}
	}
}
