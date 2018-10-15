﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Session["Username"] = null;
            HttpContext.Current.Session["AuthLevel"] = null;

            HttpContext.Current.Session["AddListItm"] = null;

            Response.Redirect("Index.aspx");
        }
    }
}