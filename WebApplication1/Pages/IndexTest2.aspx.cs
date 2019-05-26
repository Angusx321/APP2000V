using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WebApplication1.Pages
{ 
    public partial class IndexTest2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            string[] dette = getFromDataBase();
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
            MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM fooditem", databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();



                if (myReader.HasRows)
                {
                    Button1.Text = "WORKING CONNECTION";
                    while (myReader.Read())
                    {
                        Panel cust = customPanel(myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4), myReader.GetString(5), myReader.GetString(6));
                        Image img = new Image();
                        img.ImageUrl = myReader.GetString(4);
                        img.Width = 100;
                        img.Height = 100;
                        Panel pp = new Panel();
                        pp.Controls.Add(img);

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

        Panel customPanel(string name, string price, string description, string imageUrl, string diet, string category)
        {
            Panel output = null;





            return output;
        }
    }
}