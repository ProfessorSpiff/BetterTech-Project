using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            dynamic users = from a in db.Users
                            select a;

            dynamic products = from b in db.Products
                               select b;

            int userCount = 0;
            foreach (User u in users)
            {
                userCount++;
            }
            numRegUsers.InnerHtml = "<p>Number of total registered users is:</br><h1>" + userCount + "</h1></p>";
            int productCount = 0;
            foreach (Product p in products)
            {
                productCount++;
            }
            numProducts.InnerHtml = "<p>Number of total products is:</br><h1>" + productCount + "</h1></p>";
            Decimal grossRevenue = 0;
            dynamic items = from c in db.Items
                            select c;
            foreach (Item d in items)
            {
                grossRevenue = d.Item_Qty * d.Item_SellingPrice;
            }
            grossRev.InnerHtml = "<p>Gross Revenue:</br><h1>R" + grossRevenue + "</h1></p>";
        }
    }
}