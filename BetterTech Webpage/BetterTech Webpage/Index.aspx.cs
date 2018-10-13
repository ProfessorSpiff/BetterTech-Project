using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            dynamic ProductTpLst = (from products in db.Products
                                    where(products.Product_IsActive == true)
                                    orderby (products.Product_DateAdded) descending
                                    select products).Take(3);
            
            string strDisplay = "";

            foreach(Product prdct in ProductTpLst)
            {
                strDisplay += "<div class='col-md-12'>";
                strDisplay += "<div class='layer-1'>";
                strDisplay += "<div class='slider-img'>";
                strDisplay += "<img src='" + prdct.Product_Img + "' alt='' width=800 height=600>";
                strDisplay += "</div>";
                strDisplay += "<div class='slider-info gray-bg'>";
                strDisplay += "<div class='slider-info-inner'>";
                strDisplay += "<h1 class='slider-title-1 text-uppercase text-black-1'>" + prdct.Product_Name + "</h1>";

                strDisplay += "<div class='slider-brief text-black-2'>";
                strDisplay += "<p>"+prdct.Product_Description+"</p>";
                strDisplay += "</div>";
                strDisplay += "<a href='ProductPage.aspx?AddToShpCrt="+prdct.Product_Id+"' class='button extra-small button-black'>";
                strDisplay += "<span class='text-uppercase'>Add To Shopping Cart</span>";
                strDisplay += "</a>";
                strDisplay += "</div>";
                strDisplay += "</div>";
                strDisplay += "</div>";
                strDisplay += "</div>";
            }
            topSldr.InnerHtml = strDisplay;
        }
    }
}