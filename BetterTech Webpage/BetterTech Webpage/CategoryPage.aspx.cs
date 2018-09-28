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
            //......................................................................................Navigation Tab (grid view, List view)
            //string strDisplayNvTb = "";

            //strDisplayNvTb += "<li class=active'>";
            //strDisplayNvTb += "<a href='#grid-view' data-toggle='tab'><i class='zmdi zmdi-view-module'></i></a>";
            //strDisplayNvTb += "</li>";
            //strDisplayNvTb += "<li>";
            //strDisplayNvTb += "<a href='#listview' data-toggle='tab'><i class='zmdi zmdi-view-list-alt'></i></a>";
            //strDisplayNvTb += "</li>";
            //NavTab.InnerHtml = strDisplayNvTb;

            //......................................................................................Product Category List
            string divCategoryDisplay = "";
            dynamic ProductList = from product in db.Products
                                      group product by product.Product_Type into productTypeLst
                                      select productTypeLst.Key;

            foreach (string prdctType in ProductList)
            {

                divCategoryDisplay += " <li class='closed'><a href='CategoryPage.aspx?Category="+ prdctType + "'>"+ prdctType + "</a>";

                dynamic ProductItmLst = (from item in db.Products
                                        where (item.Product_Type.Equals(prdctType)) || (item.Product_IsSpecial == true)
                                        select item).Take(3);
                divCategoryDisplay += "<ul>";
                foreach (Product prdctItm in ProductItmLst)
                {
                    divCategoryDisplay += "<li><a href='ProductPage.aspx?ProductId=" + prdctItm.Product_Id+"'>" + prdctItm.Product_Name + "</a></li>";
                }
                divCategoryDisplay += "<li><a href='CategoryPage.aspx?Category="+prdctType+"'>View All</a></li>";
                divCategoryDisplay += "</ul>";
                divCategoryDisplay += "</li>";
            }

            ulCategoryList.InnerHtml = divCategoryDisplay;

            //.............................................................................................Populate With Image
            string ImgDisplay = "";
            string ImgDisplay2 = "";
            var ProductImgLst = (from productImg in db.Products
                                     where productImg.Product_Type.Equals(Request.QueryString["Category"])
                                     select productImg).Take(9);

            if (!ProductImgLst.Any())
            {
                ProductImgLst = (from productImg in db.Products
                                 select productImg).Take(9);
            }

            //ImgDisplay += "<div class='row'>";
            //ImgDisplay2 += "<div class='row'>";

            foreach (Product prdctImg in ProductImgLst)
            {
                //...................................................................For GridView Display
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
                Session["ProductId"] = prdctImg.Product_Id;
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

                //........................................................................For List View Display
                ImgDisplay2 += " <div class='col-md-12'>";
                ImgDisplay2 += " <div class='shop-list product-item'>";
                ImgDisplay2 += " <div class='product-img'>";
                ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + prdctImg.Product_Id + ">";
                ImgDisplay2 += " <img src=" + prdctImg.Product_Img + " height=300 width=270 alt=/>";
                ImgDisplay2 += " </a>";
                ImgDisplay2 += " </div>";
                ImgDisplay2 += " <div class='clearfix'>";
                ImgDisplay2 += " <h6 class='product-title'>";
                ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + prdctImg.Product_Id + " >" + prdctImg.Product_Name + "</a>";
                ImgDisplay2 += " </h6>";
                //ImgDisplay2 += " <div class='pro-rating'>";
                //ImgDisplay2 += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                //ImgDisplay2 += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                //ImgDisplay2 += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                //ImgDisplay2 += " <a href=#><i class='zmdi zmdi-star-half'></i></a>";
                //ImgDisplay2 += " <a href=#><i class='zmdi zmdi-star-outline'></i></a>";
                //ImgDisplay2 += " </div>";
                ImgDisplay2 += "<h6 class='brand-name mb-30'>" + prdctImg.Product_Brand + "</h6>";
                ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdctImg.Product_Price) + "</h3>";
                ImgDisplay2 += "<p>"+prdctImg.Product_Description+"</p>";
                ImgDisplay2 += " <ul class='action-button'>";
                ImgDisplay2 += " <li>";
                ImgDisplay2 += " <a href=# title=Wishlist><i class='zmdi zmdi-favorite'></i></a>";
                ImgDisplay2 += " </li>";
                ImgDisplay2 += " <li>";
                ImgDisplay2 += " <a href=# data-toggle=modal data-target=#productModal title=Quickview><i class='zmdi zmdi-zoom-in'></i></a>";
                ImgDisplay2 += " </li>";
                ImgDisplay2 += " <li>";
                ImgDisplay2 += " <a href=# title=Compare><i class='zmdi zmdi-refresh'></i></a>";
                ImgDisplay2 += " </li>";
                ImgDisplay2 += " <li>";
                ImgDisplay2 += " <a href=# title=Add to cart><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
                ImgDisplay2 += " </li>";
                ImgDisplay2 += " </ul>";
                ImgDisplay2 += " </div>";
                ImgDisplay2 += " </div>";
                ImgDisplay2 += " </div>";

            }
            //ImgDisplay += "</div>";
            //ImgDisplay2 += "</div>";

            listImg.InnerHtml = ImgDisplay2;
            gridImg.InnerHtml = ImgDisplay;

            //...........................................................................................Populate Recent Products

            dynamic RecentProductList = (from product in db.Products
                                        orderby product.Product_DateAdded descending
                                        select product).Take(3);

            string strDisplayRcnt = "<h6 class='widget-title border-left mb-20'>recent products</h6>";

            foreach(Product prdct in RecentProductList)
            {
                strDisplayRcnt += " <div class='product-item'>";
                strDisplayRcnt += " <div class='product-img'>";
                strDisplayRcnt += " <a href='ProductPage.aspx?ProductId="+prdct.Product_Id+"'>";
                strDisplayRcnt += " <img src='"+prdct.Product_Img+"' alt='' width=90 height=80/>";
                strDisplayRcnt += " </a>";
                strDisplayRcnt += " </div>";
                strDisplayRcnt += " <div class='product-info'>";
                strDisplayRcnt += " <h6 class='product-title'>";
                strDisplayRcnt += " <a href='ProductPage.aspx?ProductId="+prdct.Product_Id +"'>" +prdct.Product_Name + "</a>";
                strDisplayRcnt += " </h6>";
                strDisplayRcnt += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdct.Product_Price) + "</h3>";
                strDisplayRcnt += " </div>";
                strDisplayRcnt += " </div>";
            }

            WidgetProduct.InnerHtml = strDisplayRcnt;
                                        
        }
    }
}