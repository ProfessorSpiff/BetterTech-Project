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
                todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                todisplay = todisplay + "<a href=Controlsingleproduct.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                todisplay = todisplay + "<p>Current Product price:R " + pr.Product_Price + "</p>";
                todisplay = todisplay + "<p>Current Discount Percentage: " + pr.Product_SpclPercantage + "</p>";
            }
            cspec.InnerHtml = todisplay;
        }
    }
}