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
            String ImgDisplay = "";

            foreach (Product pr in pro)
            {
                decimal v =Convert.ToDecimal((100 - pr.Product_SpclPercantage)/100);
                decimal discountedprice = Convert.ToDecimal(pr.Product_Price) * v;
                //todisplay = todisplay + "<img src=" + pr.Product_Img + "  height=300 width=270 alt=''>";
                ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                ImgDisplay += " <div class='product-item'>";
                ImgDisplay += " <div class='product-info'>";
                ImgDisplay += " <h6 class='product-title'>";
                ImgDisplay += "<a href=Controlsingleproduct.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>"; ;
                ImgDisplay += " </h6>";
                ImgDisplay += "<p>Current Discounted Product price:R " + String.Format("{0:0.00}", discountedprice) + " and Current Discount Percentage: " + pr.Product_SpclPercantage + " </p>";
                ImgDisplay += " </div>";
                ImgDisplay += " </div>";
                ImgDisplay += " </div>";
            }
            cspec.InnerHtml = ImgDisplay;
        }
    }
}