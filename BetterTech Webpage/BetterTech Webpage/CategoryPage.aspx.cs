using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class CategoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            //......................................................................................Product Category List
            string divCategoryDisplay = "";
            dynamic ProductList = from product in db.Products
                                      group product by product.Product_Type into productTypeLst
                                      select productTypeLst.Key;

            foreach (string prdctType in ProductList)
            {

                divCategoryDisplay += " <li class=closed><a href=CategoryPage.aspx?Category="+ prdctType + ">"+ prdctType + "</a>";

                dynamic ProductItmLst = (from item in db.Products
                                        where (item.Product_Type.Equals(prdctType)) || (item.Product_IsSpecial == true)
                                        select item).Take(3);
                divCategoryDisplay += "<ul>";
                foreach (Product prdctItm in ProductItmLst)
                {
                    divCategoryDisplay += "<li><a href=#>" + prdctItm.Product_Name + "</a></li>";
                }
                divCategoryDisplay += "<li><a href='CategoryPage.aspx?Category="+prdctType+"'>View All</a></li>";
                divCategoryDisplay += "</ul>";
                divCategoryDisplay += "</li>";
            }

            ulCategoryList.InnerHtml = divCategoryDisplay;

            //...................................................................................Populate With Image
            string ImgDisplay = "";
            var ProductImgLst = (from productImg in db.Products
                                     where productImg.Product_Type.Equals(Request.QueryString["Category"])
                                     select productImg).Take(9);

            if (!ProductImgLst.Any())
            {
                ProductImgLst = (from productImg in db.Products
                                 select productImg).Take(9);
            }

            ImgDisplay += "<div class=row>";
            foreach (Product prdctImg in ProductImgLst)
            {
                ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                ImgDisplay += " <div class='product-item'>";
                ImgDisplay += " <div class='product-img'>";
                ImgDisplay += " <a href=ProductPage.aspx?ProductId="+prdctImg.Product_Id+">";
                ImgDisplay += " <img src=" + prdctImg.Product_Img + " height=300 width=270 alt=/>";
                ImgDisplay += " </a>";
                ImgDisplay += " </div>";
                ImgDisplay += " <div class='product-info'>";
                ImgDisplay += " <h6 class='product-title'>";
                ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + prdctImg.Product_Id + " >" + prdctImg.Product_Name + "</a>";
                ImgDisplay += " </h6>";
                //ImgDisplay += " <div class='pro-rating'>";
                //ImgDisplay += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                //ImgDisplay += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                //ImgDisplay += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                //ImgDisplay += " <a href=#><i class='zmdi zmdi-star-half'></i></a>";
                //ImgDisplay += " <a href=#><i class='zmdi zmdi-star-outline'></i></a>";
                //ImgDisplay += " </div>";
                ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdctImg.Product_Price) + "</h3>";
                ImgDisplay += " <ul class='action-button'>";
                ImgDisplay += " <li>";
                ImgDisplay += " <a href=# title=Wishlist><i class='zmdi zmdi-favorite'></i></a>";
                ImgDisplay += " </li>";
                ImgDisplay += " <li>";
                ImgDisplay += " <a href=# data-toggle=modal data-target=#productModal title=Quickview><i class='zmdi zmdi-zoom-in'></i></a>";
                ImgDisplay += " </li>";
                ImgDisplay += " <li>";
                ImgDisplay += " <a href=# title=Compare><i class='zmdi zmdi-refresh'></i></a>";
                ImgDisplay += " </li>";
                ImgDisplay += " <li>";
                ImgDisplay += " <a href=# title=Add to cart><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
                ImgDisplay += " </li>";
                ImgDisplay += " </ul>";
                ImgDisplay += " </div>";
                ImgDisplay += " </div>";
                ImgDisplay += " </div>";

            }
            ImgDisplay += "</div>";
            gridImg.InnerHtml = ImgDisplay;
        }
    }
}