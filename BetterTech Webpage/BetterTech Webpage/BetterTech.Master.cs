using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class BetterTech : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["Username"] != null)
            {
                myaccountlink.Visible = true;
                loginlink.Visible = false;
                logoutlink.Visible = true;
            }
        }
    }
}