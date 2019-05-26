using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
	public partial class Site1 : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["New"] != null)
			{
				RegLink.Visible = false;
				LoginLink.Visible = false;
			}
			else
			{
				LogoutButton.Visible = false;
				MyLink.Visible = false;
			}

		}
		public void LogoutAction(object sender, EventArgs e)
		{
			Session["New"] = null;
			Response.Redirect("~/Index.aspx");
		}
	}
}