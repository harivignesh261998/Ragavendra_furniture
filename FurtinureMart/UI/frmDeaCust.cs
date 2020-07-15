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
	public partial class frmDeaCust : Form
	{
		public frmDeaCust()
		{
			InitializeComponent();
		}








		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		DeaCustBLL dc = new DeaCustBLL();
		DeaCustDAL dcDal = new DeaCustDAL();
		userDAL uDal = new userDAL();

		private void btnAdd1_Click(object sender, EventArgs e)
		{
			dc.type = cmbType.Text;
			dc.name = txtName1.Text;
			dc.email = txtEmail1.Text;
			dc.contact = txtContact1.Text;
			dc.address = txtAddress1.Text;
			//dc.added_date = DateTime.Now;
			dc.discount1 =txtDisc1.Text;
			dc.discount2 = txtDisc2.Text;
			dc.discount3 = txtDisc3.Text;
			dc.discount4 = txtDisc4.Text;
			dc.discount5 = txtDisc5.Text;
	
			string loggedUsr = frmLogin.loggedIn;
			userBLL usr = uDal.GetIDFromUsername(loggedUsr);
			/*dc.added_by = usr.id;*/
			bool success = dcDal.Insert(dc);
			if (success == true)
			{
				MessageBox.Show("Dealer or Customer Added Successfully");
				Clear();
				DataTable dt = dcDal.Select();
				dgvDeaCust1.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed to Add");
			}


		}
		public void Clear()
		{
			txtDeaCustID1.Text = "";
			txtName1.Text = "";
			txtEmail1.Text = "";
			txtContact1.Text = "";
			txtAddress1.Text = "";
			txtSearch1.Text = "";
			txtDisc1.Text = "";

		}
		private void frmDeaCust_Load(object sender, EventArgs e)
		{
			DataTable dt = dcDal.Select();
			dgvDeaCust1.DataSource = dt;

		}

		private void dgvDeaCust1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowIndex = e.RowIndex;
			txtDeaCustID1.Text = dgvDeaCust1.Rows[rowIndex].Cells[0].Value.ToString();
			cmbType.Text = dgvDeaCust1.Rows[rowIndex].Cells[1].Value.ToString();
			txtName1.Text = dgvDeaCust1.Rows[rowIndex].Cells[2].Value.ToString();
			txtEmail1.Text = dgvDeaCust1.Rows[rowIndex].Cells[3].Value.ToString();
			txtContact1.Text = dgvDeaCust1.Rows[rowIndex].Cells[4].Value.ToString();
			txtAddress1.Text = dgvDeaCust1.Rows[rowIndex].Cells[5].Value.ToString();
			txtDisc1.Text = dgvDeaCust1.Rows[rowIndex].Cells[6].Value.ToString();

		}

		private void btnUpdate1_Click(object sender, EventArgs e)
		{
			dc.id = int.Parse(txtDeaCustID1.Text);
			dc.type = cmbType.Text;
			dc.name = txtName1.Text;
			dc.email = txtEmail1.Text;
			dc.contact = txtContact1.Text;
			dc.address = txtAddress1.Text;
			//dc.added_date = DateTime.Now;
			dc.discount1 = txtDisc1.Text;
			dc.discount2 = txtDisc2.Text;
			dc.discount3 = txtDisc3.Text;
			dc.discount4 = txtDisc4.Text;
			dc.discount5 = txtDisc5.Text;

			string loggedUsr = frmLogin.loggedIn;
			userBLL usr = uDal.GetIDFromUsername(loggedUsr);
			/*dc.added_by = usr.id;*/

			bool success = dcDal.Update(dc);
			if (success == true)
			{
				MessageBox.Show("Update Successfully");
				Clear();
				DataTable dt = dcDal.Select();
				dgvDeaCust1.DataSource = dt;

			}
			else
			{
				MessageBox.Show("Failed to Update");
			}


		}

		private void btnDelete1_Click(object sender, EventArgs e)
		{
			dc.id = int.Parse(txtDeaCustID1.Text);
			bool success = dcDal.Delete(dc);
			if (success == true)
			{
				MessageBox.Show("Deleted Successfully");
				Clear();
				DataTable dt = dcDal.Select();
				dgvDeaCust1.DataSource = dt;

			}
			else
			{
				MessageBox.Show("Failed to Delete");
			}
		}

		private void txtSearch1_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSearch.Text;

			if (keyword != null)
			{

				DataTable dt = dcDal.Search(keyword);
				dgvDeaCust.DataSource = dt;
			}
			else
			{

				DataTable dt = dcDal.Select();
				dgvDeaCust.DataSource = dt;
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
