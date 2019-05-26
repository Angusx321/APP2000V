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
			{
				if (Session["New"] != null)
				{
					WelcomeLabel.Text += Session["New"].ToString();
					string[] dette = getFromDataBase();

				}
				else
				{
					Response.Redirect("Login.aspx");
				}
			}
		}
		protected void Button1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Knapp");
		}

		String MySQLConnection = "Server=remotemysql.com;Port=3306;Database=fC9ZHTjFn1;Uid=fC9ZHTjFn1;Pwd=fWqAPndchu;";

		string[] getFromDataBase()
		{
			string[] output = null;
			MySqlConnection databaseConnection = new MySqlConnection(MySQLConnection);
			MySqlCommand commandDatabase = new MySqlCommand("SELECT fooditem.name, customerorders.orderstate FROM customerorders JOIN fooditem ON fooditem.foodID=customerorders.foodID JOIN user_s ON user_s.userId=customerorders.userId WHERE user_s.email='" + Session["New"] + "'", databaseConnection);

			try
			{
				databaseConnection.Open();
				MySqlDataReader myReader = commandDatabase.ExecuteReader();



				if (myReader.HasRows)
				{ 
					Button1.Text = "WORKING CONNECTION"; 
					while (myReader.Read())
					{
						Panel cust = customPanel(myReader.GetString(1), myReader.GetString(2));
						Panel pp = new Panel();

						BulletedList1.Items.Add(myReader.GetString(1));
						mainPanel.Controls.Add(pp);
						Button aaff = new Button();
						aaff.Text = myReader.GetString(1);
						mainPanel.Controls.Add(aaff);

					}
				}
				else
				{
					Button1.Text = "NOT WORKING CONNECTION";
				}


				databaseConnection.Close();

			}
			catch (Exception e)
			{
				Button1.Text = e.Message;
			}
			return output;
		}

		Panel customPanel(string name, string orderstate)
		{
			Panel output = null;





			return output;
		}

	}
}