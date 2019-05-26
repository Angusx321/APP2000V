using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace WebApplication1.Pages
{
	public partial class WebForm5 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
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
						Label1.Text ="This email is already registered.";
					}
				}
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				using (MySqlConnection con = new MySqlConnection())
				{
					String connectionString = "Server=remotemysql.com; Port=3306; Database=fC9ZHTjFn1; Uid=fC9ZHTjFn1; Pwd=fWqAPndchu";
					string insertQuery = "INSERT INTO user_s (email,firstName,lastName,password) VALUES (@mail ,@fname, @lname, @pword)";
					con.ConnectionString = connectionString;
					con.Open();
					MySqlCommand com = new MySqlCommand(insertQuery, con);
					com.Parameters.AddWithValue("@mail", Email.Text);
					com.Parameters.AddWithValue("@fname", FirstName.Text);
					com.Parameters.AddWithValue("@lname", LastName.Text);
					com.Parameters.AddWithValue("@pword", Password.Text);

					com.ExecuteNonQuery();
					Label2.Text = "Your Registration is complete! <br/>Click <a href='~/Pages/Login.aspx'>here</a> to login.";

					con.Close();
				}
			}
			catch (Exception ex)
			{
				Response.Write("Error:" + ex.ToString());
			}
		}
		//private void CheckMysqlConnection()
		//{
		//	//connectionString
		//	String connectionString = "Server=remotemysql.com; Port=3306; Database=fC9ZHTjFn1; Uid=fC9ZHTjFn1; Pwd=fWqAPndchu";
		//	using (MySqlConnection cn = new MySqlConnection(connectionString))
		//	{
		//		cn.Open();
		//		Response.Write("Mysql Connection Successful");
		//	}
		//}

	}

}
