using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class SearchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String searchterm = Request.QueryString["Search"];
            String todisplay = "<p>You are searching for: " + searchterm + "</p>";
            String searchtermupper = searchterm.ToUpper();

            var db = new DataLinqDataContext();

            dynamic pro = from p in db.Products
                          select p;
            Boolean productfound = false;

            foreach (Product pr in pro)
            {
                String PName = pr.Product_Name.ToUpper();
                String PType = pr.Product_Type.ToUpper();

                if (PName.Contains(searchtermupper))
                {
                    productfound = true;
                    todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                    todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                    todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                    todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                }else if(PType.Contains(searchtermupper))
                {
                    productfound = true;
                    todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                    todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                    todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                    todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                }
                else
                {
                    productfound = false;
                }

            }

            if (productfound == false)
            {
                todisplay = todisplay + "Cannot find result";
               
            }

            productsearchdetails.InnerHtml = todisplay;

            //todisplay = todisplay + "< h6 class=" + "product-title" + ">";
            //todisplay = todisplay + "< a href =" + "ProductPage.aspx" + ">" + pr.Product_Name +"</a>";
            //todisplay = todisplay + "</ h6 >";
            //todisplay = todisplay + "< div class=" + "pro-rating" + ">";
            //todisplay = todisplay + "< a href = " + "#" + ">< i class=" + "zmdi zmdi-star" + "></i></a>";
            //todisplay = todisplay + "< a href =" + "#" + ">< i class=" + "zmdi zmdi-star" + "></i></a>";
            //todisplay = todisplay + "< a href =" + "#" + ">< i class=" + "zmdi zmdi-star" + "></i></a>";
            //todisplay = todisplay + "< a href =" + "#" + ">< i class=" + "zmdi zmdi-star-half" + "></i></a>";
            //todisplay = todisplay + "< a href =" + "#" + ">< i class=" + "zmdi zmdi-star-outline" + "></i></a>";
            //todisplay = todisplay + "</div>";
            //todisplay = todisplay + "< h3 class=" + "pro-price" + ">R " + pr.Product_Price + "</h3>";
            //todisplay = todisplay + "< ul class=" + "action-button" + ">";
            //todisplay = todisplay + "< li>";
            //todisplay = todisplay + "< a href =" +  "#" + " title=" + "Wishlist"+ "><i class="+ "zmdi zmdi-favorite" + "></i></a>";
            //todisplay = todisplay + "</li>";
            //todisplay = todisplay + "< li>";
            //todisplay = todisplay + "< a href =" + "#" + "data-toggle=" + "modal" + "data-target=" + "#productModal" + "title=" + "Quickview" + "><i class=" + "zmdi zmdi-zoom-in" + "></i></a>";
            //todisplay = todisplay + "</li>";
            //todisplay = todisplay + "< li>";
            //todisplay = todisplay + "< a href = " + "#" + "title=" + "Compare" + "><i class=" + "zmdi zmdi-refresh" + "></i></a>";
            //todisplay = todisplay + "</li>";
            //todisplay = todisplay + "<li>";
            //todisplay = todisplay + "<a href = " + "#" + "title=" + "Add to cart" + "><i class=" + "zmdi zmdi-shopping-cart-plus" + "></i></a>";
            //todisplay = todisplay + "</li>";
            //todisplay = todisplay + "</ul>";
        }
    }
}