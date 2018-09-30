using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class ProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            //...........................................................................................Product Category List
            string divCategoryDisplay = "";
            dynamic ProductList = from product in db.Products
                                  group product by product.Product_Type into productTypeLst
                                  select productTypeLst.Key;

            foreach (string prdctType in ProductList)
            {

                divCategoryDisplay += " <li class=closed><a href=CategoryPage.aspx?Category=" + prdctType + ">" + prdctType + "</a>";

                dynamic ProductItmLst = (from item in db.Products
                                         where (item.Product_Type.Equals(prdctType)) || (item.Product_IsSpecial == true)
                                         select item).Take(3);
                divCategoryDisplay += "<ul>";
                foreach (Product prdctItm in ProductItmLst)
                {
                    divCategoryDisplay += "<li><a href=#>" + prdctItm.Product_Name + "</a></li>";
                }
                divCategoryDisplay += "<li><a href='CategoryPage.aspx?Category=" + prdctType + "'>View All</a></li>";
                divCategoryDisplay += "</ul>";
                divCategoryDisplay += "</li>";
            }

            ulCategoryList.InnerHtml = divCategoryDisplay;

            //..................................................................................................Populate Recent Products

            dynamic RecentProductList = (from product in db.Products
                                         orderby product.Product_DateAdded descending
                                         select product).Take(3);

            string strDisplayRcnt = "";

            foreach (Product prdct in RecentProductList)
            {
                strDisplayRcnt += " <div class='product-item'>";
                strDisplayRcnt += " <div class='product-img'>";
                strDisplayRcnt += " <a href='ProductPage.aspx?ProductId=" + prdct.Product_Id + "'>";
                strDisplayRcnt += " <img src='" + prdct.Product_Img + "' alt='' width=90 height=80/>";
                strDisplayRcnt += " </a>";
                strDisplayRcnt += " </div>";
                strDisplayRcnt += " <div class='product-info'>";
                strDisplayRcnt += " <h6 class='product-title'>";
                strDisplayRcnt += " <a href='ProductPage.aspx?ProductId=" + prdct.Product_Id + "'>" + prdct.Product_Name + "</a>";
                strDisplayRcnt += " </h6>";
                strDisplayRcnt += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdct.Product_Price) + "</h3>";
                strDisplayRcnt += " </div>";
                strDisplayRcnt += " </div>";
            }

            WidgetProduct.InnerHtml = strDisplayRcnt;

            //.........................................................................................Selected Product Specifications

            var Product = (from product in db.Products
                           where (product.Product_Id).Equals(Request.QueryString["ProductId"])
                           select product).FirstOrDefault();

            description.InnerHtml = "<p>" + Product.Product_Description + "</p>";

            ProductImg.InnerHtml = "<img id='zoom_03' src='" + Product.Product_Img + "' data-zoom-image='" + Product.Product_Img + "' alt=''>";
            //src="img/product/6.jpg" data-zoom-image="img/product/6.jpg"

            //...........................................................................................................Related Product Images

            
            var RelatedProduct = (from product in db.Products
                                      where (product.Product_Id).Equals(Request.QueryString["ProductId"])
                                      select product).FirstOrDefault();

            dynamic RelatedPrdctLst = (from product in db.Products
                                       where (product.Product_Type).Equals(RelatedProduct.Product_Type)
                                       select product).Take(3);

            string strDisplay = "";
            foreach(Product prdct in RelatedPrdctLst)
            {
                strDisplay += " <div class='col-xs-12'>";
                strDisplay += " <div class='product-item'>";
                strDisplay += " <div class='product-img'>";
                strDisplay += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + ">";
                strDisplay += " <img src=" + prdct.Product_Img + " height=300 width=270 alt=/>";
                strDisplay += " </a>";
                strDisplay += " </div>";
                strDisplay += " <div class='product-info'>";
                strDisplay += " <h6 class='product-title'>";
                strDisplay += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + " >" + prdct.Product_Name + "</a>";
                strDisplay += " </h6>";
                //strDisplay += " <div class='pro-rating'>";
                //strDisplay += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                //strDisplay += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                //strDisplay += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                //strDisplay += " <a href=#><i class='zmdi zmdi-star-half'></i></a>";
                //strDisplay += " <a href=#><i class='zmdi zmdi-star-outline'></i></a>";
                //strDisplay += " </div>";
                strDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdct.Product_Price) + "</h3>";
                strDisplay += " <ul class='action-button'>";
                strDisplay += " <li>";
                strDisplay += " <a href=# title=Wishlist><i class='zmdi zmdi-favorite'></i></a>";
                strDisplay += " </li>";
                strDisplay += " <li>";
                strDisplay += " <a href=# data-toggle=modal data-target=#productModal title=Quickview><i class='zmdi zmdi-zoom-in'></i></a>";
                strDisplay += " </li>";
                strDisplay += " <li>";
                strDisplay += " <a href=# title=Compare><i class='zmdi zmdi-refresh'></i></a>";
                strDisplay += " </li>";
                strDisplay += " <li>";
                strDisplay += " <a href=# title=Add to cart><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
                strDisplay += " </li>";
                strDisplay += " </ul>";
                strDisplay += " </div>";
                strDisplay += " </div>";
                strDisplay += " </div>";
            }
            RelatedPrdct.InnerHtml = strDisplay;
        }
    }
}