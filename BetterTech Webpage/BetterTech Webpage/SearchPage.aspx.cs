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
            string ImgDisplay = "";   
            string ImgDisplay2 = "";
            var db = new DataLinqDataContext();
            dynamic pro = from p in db.Products
                          select p;
            Boolean productfound = true;

            foreach (Product pr in pro)
            {
                String PName = pr.Product_Name.ToUpper();
                String PType = pr.Product_Type.ToUpper();
                String PBrand = pr.Product_Brand.ToUpper();
                if (searchtermupper.Contains(PName))
                {
                    productfound = true;
                    //...................................................................For GridView Display
                    ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                    ImgDisplay += " <div class='product-item'>";
                    ImgDisplay += " <div class='product-img'>";
                    ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                    ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                    ImgDisplay += " </a>";
                    ImgDisplay += " </div>";
                    ImgDisplay += " <div class='product-info'>";
                    ImgDisplay += " <h6 class='product-title'>";
                    ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                    Session["ProductId"] = pr.Product_Id;
                    ImgDisplay += " </h6>";
                    ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                    ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                    ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                    ImgDisplay2 += " </a>";
                    ImgDisplay2 += " </div>";
                    ImgDisplay2 += " <div class='clearfix'>";
                    ImgDisplay2 += " <h6 class='product-title'>";
                    ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                    ImgDisplay2 += " </h6>";
                    ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                    ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                    ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                listImg.InnerHtml = ImgDisplay2;
                gridImg.InnerHtml = ImgDisplay;
                
                } else if (searchtermupper.Contains(PType))
                {
                    productfound = true;
                    //...................................................................For GridView Display
                    ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                    ImgDisplay += " <div class='product-item'>";
                    ImgDisplay += " <div class='product-img'>";
                    ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                    ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                    ImgDisplay += " </a>";
                    ImgDisplay += " </div>";
                    ImgDisplay += " <div class='product-info'>";
                    ImgDisplay += " <h6 class='product-title'>";
                    ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                    Session["ProductId"] = pr.Product_Id;
                    ImgDisplay += " </h6>";
                    ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                    ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                    ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                    ImgDisplay2 += " </a>";
                    ImgDisplay2 += " </div>";
                    ImgDisplay2 += " <div class='clearfix'>";
                    ImgDisplay2 += " <h6 class='product-title'>";
                    ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                    ImgDisplay2 += " </h6>";
                    ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                    ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                    ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                    listImg.InnerHtml = ImgDisplay2;
                    gridImg.InnerHtml = ImgDisplay;

                } else if (searchtermupper.Contains(PBrand))
                {
                    productfound = true;
                    //...................................................................For GridView Display
                    ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                    ImgDisplay += " <div class='product-item'>";
                    ImgDisplay += " <div class='product-img'>";
                    ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                    ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                    ImgDisplay += " </a>";
                    ImgDisplay += " </div>";
                    ImgDisplay += " <div class='product-info'>";
                    ImgDisplay += " <h6 class='product-title'>";
                    ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                    Session["ProductId"] = pr.Product_Id;
                    ImgDisplay += " </h6>";
                    ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                    ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                    ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                    ImgDisplay2 += " </a>";
                    ImgDisplay2 += " </div>";
                    ImgDisplay2 += " <div class='clearfix'>";
                    ImgDisplay2 += " <h6 class='product-title'>";
                    ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                    ImgDisplay2 += " </h6>";
                    ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                    ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                    ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                    listImg.InnerHtml = ImgDisplay2;
                    gridImg.InnerHtml = ImgDisplay;
                    
                }else if(productfound==false)
                {
                    todisplay = "Could not find result";
                }
                
            }
            productsearchdetails.InnerHtml = todisplay;
        }

        protected void btnsort_Click(object sender, EventArgs e)
        {
            String sorting = selectsection.Value;
            productsearchdetails.InnerHtml = "<p> Sorted by: " + sorting;
            var db = new DataLinqDataContext();
            string ImgDisplay = "";
            string ImgDisplay2 = "";
            if (sorting == "SortbyName")
            {
                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Name ascending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }else if (productfound == false)
                    {
                        todisplay = "Could not find result";
                    }

                }
                productsearchdetails.InnerHtml = todisplay;
            }
            else if (sorting == "Sortbytype")
            {
                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Type ascending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (productfound == false)
                    {
                        todisplay = "Could not find result";
                    }

                }
               
                productsearchdetails.InnerHtml = todisplay;
            }
            else if (sorting == "SortbypriceHigh")
            {
                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Price descending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (productfound == false)
                    {
                        todisplay = "Could not find result";
                    }

                }
                
                productsearchdetails.InnerHtml = todisplay;
            }
            else if (sorting == "SortbypriceLow")
            {
                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Price ascending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (productfound == false)
                    {
                        todisplay = "Could not find result";
                    }

                }
                
                productsearchdetails.InnerHtml = todisplay;
            }
            else if (sorting == "Sortbybrand")
            {

                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Brand ascending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        //...................................................................For GridView Display
                        ImgDisplay += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                        ImgDisplay += " <div class='product-item'>";
                        ImgDisplay += " <div class='product-img'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay += " </a>";
                        ImgDisplay += " </div>";
                        ImgDisplay += " <div class='product-info'>";
                        ImgDisplay += " <h6 class='product-title'>";
                        ImgDisplay += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        Session["ProductId"] = pr.Product_Id;
                        ImgDisplay += " </h6>";
                        ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
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
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">";
                        ImgDisplay2 += " <img src=" + pr.Product_Img + " height=300 width=270 alt=/>";
                        ImgDisplay2 += " </a>";
                        ImgDisplay2 += " </div>";
                        ImgDisplay2 += " <div class='clearfix'>";
                        ImgDisplay2 += " <h6 class='product-title'>";
                        ImgDisplay2 += " <a href=ProductPage.aspx?ProductId=" + pr.Product_Id + " >" + pr.Product_Name + "</a>";
                        ImgDisplay2 += " </h6>";
                        ImgDisplay2 += "<h6 class='brand-name mb-30'>" + pr.Product_Brand + "</h6>";
                        ImgDisplay2 += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", pr.Product_Price) + "</h3>";
                        ImgDisplay2 += "<p>" + pr.Product_Description + "</p>";
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
                        listImg.InnerHtml = ImgDisplay2;
                        gridImg.InnerHtml = ImgDisplay;
                    }
                    else if (productfound == false)
                    {
                        todisplay = "Could not find result";
                    }

                }
                
                productsearchdetails.InnerHtml = todisplay;

            }

        }
    }
}