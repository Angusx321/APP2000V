using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WebApplication1
{
	public partial class WebForm3 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void LoginButton_Click(object sender, EventArgs e)
		{
			using (MySqlConnection con = new MySqlConnection())
			{
				String connectionString = "Server=remotemysql.com; Port=3306; Database=fC9ZHTjFn1; Uid=fC9ZHTjFn1; Pwd=fWqAPndchu";
				con.ConnectionString = connectionString;
				con.Open();
				string checkemail = "SELECT COUNT(*) FROM user_s WHERE email='" + Email.Text + "'";
				MySqlCommand com = new MySqlCommand(checkemail, con);
				int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
				con.Close();
				if (temp == 1)
				{
					con.Open();
					string checkPasswordQuery = "SELECT password FROM user_s WHERE email='" + Email.Text + "'";
					MySqlCommand passCom = new MySqlCommand(checkPasswordQuery, con);
					string password = passCom.ExecuteScalar().ToString();
					if(password==Password.Text)
					{
						Session["New"] = Email.Text;
						Response.Redirect("../Index.aspx");
					}
					else
					{
						Label1.Text = "Password is not correct!";
					}
				}
				else
				{
					Label1.Text="Email is not in our database.";
				}
			}
		}
	}
}