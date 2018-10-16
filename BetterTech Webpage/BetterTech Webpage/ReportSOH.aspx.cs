using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class ReportSOH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            dynamic products = from a in db.Products
                               select a;
            string display = "";
            foreach (Product p in products)
            {
                display += "<div class=\"col-sm-6 col-xs-12\">";
                display += "        <div class=\"blog-item-2\">";
                display += "            <div class=\"row\">";
                display += "                <div class=\"col-md-6 col-xs-12\">";
                display += "                    <div class=\"blog-desc\">";
                display += "                        <h5 class=\"blog -title-2\">" + p.Product_OnHand + "</h5>";
                display += "                        <p>" + p.Product_Name + "</p>";
                display += "                    </div>";
                display += "                </div>";
                display += "            </div>";
                display += "        </div>";
                display += "    </div>";
            }
            main.InnerHtml = display;
        }
    }
}