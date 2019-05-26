using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1.Pages
{
	public partial class WebForm4 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			using (MySqlConnection con = new MySqlConnection())
			{
				if (Session["New"] != null)
				{
					String connectionString = "Server=remotemysql.com; Port=3306; Database=fC9ZHTjFn1; Uid=fC9ZHTjFn1; Pwd=fWqAPndchu";
					con.ConnectionString = connectionString;
					con.Open();

					//string key = Session["New"].ToString();
					string findfirstName = "SELECT firstName FROM user_s WHERE email='" + Session["New"] + "'";
					MySqlCommand com = new MySqlCommand(findfirstName, con);
					object obj = Session["New"];
					int firstName = Convert.ToInt32(obj);
					com.Parameters.Add(new MySqlParameter("New", firstName));
					MySqlDataReader reader = com.ExecuteReader();

					reader.Read();
					WelcomeLabel.Text += reader["firstName"].ToString();
					//WelcomeLabel.Text += Session["New"].ToString();

					con.Close();

					//Grid
					//using (MySqlCommand cmd = new MySqlCommand("SELECT foodID, orderstate FROM customerorders"))
					//{
					//	using (MySqlDataAdapter sda = new MySqlDataAdapter())
					//	{
					//		cmd.Connection = con;
					//		sda.SelectCommand = cmd;
					//		using (DataTable dt = new DataTable())
					//		{
					//			sda.Fill(dt);
					//			GridView1.DataSource = dt;
					//			GridView1.DataBind();
					//		}
					//	}
					//}

				}
				else
				{
					Response.Redirect("Login.aspx");
				}
			}
		}


		protected void LogoutButton_Click(object sender, EventArgs e)
		{
			Session["New"] = null;
			Response.Redirect("../Index.aspx");
		}


	}
}