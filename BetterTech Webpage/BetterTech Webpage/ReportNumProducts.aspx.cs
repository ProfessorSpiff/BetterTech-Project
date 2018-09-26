using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class ReportNumProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();
            dynamic products = from a in db.Products
                               select a;
            int productCount = 0;
            int specialCount = 0;
            int recentCount = 0;
            foreach (Product p in products)
            {
                productCount++;
                if (p.Product_IsSpecial)
                {
                    specialCount++;
                }
                if(p.Product_DateAdded > DateTime.Now.AddMonths(-3))
                {
                    recentCount++;
                }
            }
            numProducts.InnerHtml = "<h2 class=uppercase mb-30>Total Number of Products: " + productCount + "</h2>";
            numSpecial.InnerHtml = "<h2 class=uppercase mb-30>Total Number of Products on Special: " + specialCount + "</h2>";
            numRecent.InnerHtml = "<h2 class=uppercase mb-30>Recent Products: " + recentCount + "</h2>";
        }
    }
}