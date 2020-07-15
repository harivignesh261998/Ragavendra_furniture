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
	public partial class frmTransaction : Form
	{
		public frmTransaction()
		{
			InitializeComponent();
		}
		transactionDAL tdal = new transactionDAL();
		private void frmTransaction_Load(object sender, EventArgs e)
		{
			DataTable dt = tdal.DisplayAllTransactions();
			dgvTransation.DataSource = dt;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		

		private void cmbTransaction_SelectedIndexChanged(object sender, EventArgs e)
		{
			string type = cmbTransaction.Text;
			DataTable dt = tdal.DisplayTransactionByType(type);
			dgvTransation.DataSource = dt;

		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			DataTable dt = tdal.DisplayAllTransactions();
			dgvTransation.DataSource = dt;
		}
	}
}
