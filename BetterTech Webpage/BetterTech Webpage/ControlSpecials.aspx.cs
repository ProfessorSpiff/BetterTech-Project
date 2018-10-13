using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class ControlSpecials : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();
            dynamic pro = from p in db.Products
                          select p;
            String todisplay = "";

            foreach (Product pr in pro)
            {
                todisplay = todisplay + "<img src=" + pr.Product_Img + "  height=300 width=270 alt=''>";
                todisplay = todisplay + "<p></p>";
                todisplay = todisplay + "<a href=Controlsingleproduct.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                todisplay = todisplay + "<p>Current Product price:R " + String.Format("{0:0.00}",pr.Product_Price) + " and Current Discount Percentage: " + pr.Product_SpclPercantage  + " </p>";
                todisplay = todisplay + "<hr>";
            }
            cspec.InnerHtml = todisplay;
        }
    }
}