using FurtinureMart.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurtinureMart.DAL
{
	class DeaCustDAL
	{
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		#region SELECT MEthod for Dealer and Customer
		public DataTable Select()
		{
			
			SqlConnection conn = new SqlConnection(myconnstrng);

			
			DataTable dt = new DataTable();

			try
			{
			
				string sql = "SELECT * FROM tbl_dea_cust";

			
				SqlCommand cmd = new SqlCommand(sql, conn);

			
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			
				conn.Open();
			
				adapter.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}

			return dt;
		}
		#endregion
		#region INSERT Method to Add details fo Dealer or Customer
		public bool Insert(DeaCustBLL dc)
		{
			
			SqlConnection conn = new SqlConnection(myconnstrng);

			
			bool isSuccess = false;

			try
			{
			
				string sql = "INSERT INTO tbl_dea_cust (type, name, email, contact, address, discount1, discount2, discount3, discount4, discount5) VALUES (@type, @name, @email, @contact, @address, @discount1, @discount2, @discount3, @discount4, @discount5)";

			
				SqlCommand cmd = new SqlCommand(sql, conn);
			
				cmd.Parameters.AddWithValue("@type", dc.type);
				cmd.Parameters.AddWithValue("@name", dc.name);
				cmd.Parameters.AddWithValue("@email", dc.email);
				cmd.Parameters.AddWithValue("@contact", dc.contact);
				cmd.Parameters.AddWithValue("@address", dc.address);
				//cmd.Parameters.AddWithValue("@added_date", dc.discount);
				//cmd.Parameters.AddWithValue("@added_by", dc.added_by);
				cmd.Parameters.AddWithValue("@discount1", dc.discount1);
				cmd.Parameters.AddWithValue("@discount2", dc.discount2);
				cmd.Parameters.AddWithValue("@discount3", dc.discount3);
				cmd.Parameters.AddWithValue("@discount4", dc.discount4);
				cmd.Parameters.AddWithValue("@discount5", dc.discount5);



				conn.Open();

			
				int rows = cmd.ExecuteNonQuery();

			
				if (rows > 0)
				{
			
					isSuccess = true;
				}
				else
				{
			
					isSuccess = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}

			return isSuccess;
		}
		#endregion
		#region UPDATE method for Dealer and Customer Module
		public bool Update(DeaCustBLL dc)
		{
			
			SqlConnection conn = new SqlConnection(myconnstrng);
			
			bool isSuccess = false;

			try
			{
			
				string sql = "UPDATE tbl_dea_cust SET type=@type, name=@name, email=@email, contact=@contact, address=@address, discount1=@discount1, discount2=@discount2, discount3=@discount3, discount4=@discount4, discount5=@discount5 WHERE id=@id";
			
				SqlCommand cmd = new SqlCommand(sql, conn);

			
				cmd.Parameters.AddWithValue("@type", dc.type);
				cmd.Parameters.AddWithValue("@name", dc.name);
				cmd.Parameters.AddWithValue("@email", dc.email);
				cmd.Parameters.AddWithValue("@contact", dc.contact);
				cmd.Parameters.AddWithValue("@address", dc.address);
				//cmd.Parameters.AddWithValue("@added_date", dc.discount);
				//cmd.Parameters.AddWithValue("@added_by", dc.added_by);
				cmd.Parameters.AddWithValue("@id", dc.id);
				cmd.Parameters.AddWithValue("@discount1", dc.discount1);
				cmd.Parameters.AddWithValue("@discount2", dc.discount2);
				cmd.Parameters.AddWithValue("@discount3", dc.discount3);
				cmd.Parameters.AddWithValue("@discount4", dc.discount4);
				cmd.Parameters.AddWithValue("@discount5", dc.discount5);

				conn.Open();

			
				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
			
					isSuccess = true;
				}
				else
				{
			
					isSuccess = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}

			return isSuccess;
		}
		#endregion
		#region DELETE Method for Dealer and Customer Module
		public bool Delete(DeaCustBLL dc)
		{
			
			SqlConnection conn = new SqlConnection(myconnstrng);

			
			bool isSuccess = false;

			try
			{
				
				string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";

				
				SqlCommand cmd = new SqlCommand(sql, conn);
				
				cmd.Parameters.AddWithValue("@id", dc.id);

				
				conn.Open();
				
				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
				
					isSuccess = true;
				}
				else
				{
				
					isSuccess = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}

			return isSuccess;
		}
		#endregion
		#region SEARCH METHOD for Dealer and Customer Module
		public DataTable Search(string keyword)
		{
			
			SqlConnection conn = new SqlConnection(myconnstrng);

			
			DataTable dt = new DataTable();

			try
			{
			
				string sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keyword + "%' OR type LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

			
				SqlCommand cmd = new SqlCommand(sql, conn);
			
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			
				conn.Open();
			
				adapter.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}

			return dt;
		}
		#endregion
		#region METHOD TO SAERCH DEALER Or CUSTOMER FOR TRANSACTON MODULE
		public DeaCustBLL SearchDealerCustomerForTransaction(string keyword)
		{
			
			DeaCustBLL dc = new DeaCustBLL();

			
			SqlConnection conn = new SqlConnection(myconnstrng);

			
			DataTable dt = new DataTable();

			try
			{
			
				string sql = "SELECT name, email, contact, address,discount from tbl_dea_cust WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

			
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

			
				conn.Open();

			
				adapter.Fill(dt);

			
				if (dt.Rows.Count > 0)
				{
					dc.name = dt.Rows[0]["name"].ToString();
					dc.email = dt.Rows[0]["email"].ToString();
					dc.contact = dt.Rows[0]["contact"].ToString();
					dc.address = dt.Rows[0]["address"].ToString();
					dc.discount1 = dt.Rows[0]["discount1"].ToString();
					dc.discount2 = dt.Rows[0]["discount2"].ToString();
					dc.discount3 = dt.Rows[0]["discount3"].ToString();
					dc.discount4 = dt.Rows[0]["discount4"].ToString();
					dc.discount5 = dt.Rows[0]["discount5"].ToString();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
			
				conn.Close();
			}

			return dc;
		}
		#endregion
		#region METHOD TO GET ID OF THE DEALER OR CUSTOMER BASED ON NAME
		public DeaCustBLL GetDeaCustIDFromName(string Name)
		{
			
			DeaCustBLL dc = new DeaCustBLL();

			
			SqlConnection conn = new SqlConnection(myconnstrng);
			
			DataTable dt = new DataTable();

			try
			{
			
				string sql = "SELECT id FROM tbl_dea_cust WHERE name='" + Name + "'";
			
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

				conn.Open();

			
				adapter.Fill(dt);
				if (dt.Rows.Count > 0)
				{
			
					dc.id = int.Parse(dt.Rows[0]["id"].ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}

			return dc;
		}
		#endregion
	}
}
