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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		loginBLL l = new loginBLL();
		loginDAL dal = new loginDAL();
		public static string loggedIn;

		

		private void pboxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			l.username = txtUserName.Text.Trim();
			l.password = txtPassword.Text.Trim();
			l.user_type = cmbUserType.Text.Trim();
			bool success = dal.loginCheck(l);
			if (success == true)
			{
				MessageBox.Show("Login Successful");
				loggedIn = l.username;
				switch (l.user_type)
				{
					case "Admin":
						{
							frmAdminDashboard admin = new frmAdminDashboard();
							admin.Show();
							this.Hide();
						}
						break;
					case "User":
						{
							frmUserDashboard user = new frmUserDashboard();
							user.Show();
							this.Hide();

						}
						break;
					default:
						{
							MessageBox.Show("Inalid User Type");
						}
						break;
				}

			}
			else
			{
				MessageBox.Show("Login Failed,Try Again ");

			}

		}

		private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
