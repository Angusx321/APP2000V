using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
	public partial class Index : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

            ContentPlaceHolder aaa = new ContentPlaceHolder();
            aaa.Controls.Add(new Button());
            Index a = new Index();
            a.Controls.Add(aaa);

		}


    }
}