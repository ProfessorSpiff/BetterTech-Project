using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace BetterTech_Webpage
{
   
    public partial class CategoryPage : System.Web.UI.Page
    {
        protected string strPrcRng = "";
        protected string strSrch = "";
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

            strSrch = txtSrch.Value;//...........................Search value
            strPrcRng = amount.Value;//.........................amount range value

            int intVal1 = 0;
            int intVal2 = 0;

            //...............................................seperating val1 and val2
            if (!strPrcRng.Equals(""))
            {
                intVal1 = Convert.ToInt32(strPrcRng.Substring(strPrcRng.IndexOf("R") + 1, strPrcRng.IndexOf("-") - 1));
                intVal2 = Convert.ToInt32(strPrcRng.Substring(strPrcRng.IndexOf("-") + 3));
            }
            

            var ProductImgLst = (from productImg in db.Products
                                                 where productImg.Product_Type.Equals(Request.QueryString["Category"])
                                                 select productImg).Take(9);
            
            //.....................................................search where price match and search match
            if ((!strSrch.Equals("")) && (!strPrcRng.Equals("")))
            {
                ProductImgLst = (from productImg in db.Products
                                 where (((productImg.Product_Name).ToLower()).Contains(strSrch.ToLower())) && (((productImg.Product_Price) >= intVal1 && (productImg.Product_Price) <= intVal2))
                                 select productImg).Take(9);
            }
            //..............................................where price range for particular category
            else if (!strPrcRng.Equals(""))
            {
                ProductImgLst = (from productImg in db.Products
                                 where (productImg.Product_Type.Equals(Request.QueryString["Category"])) && 
                                 ((productImg.Product_Price) >= intVal1 && (productImg.Product_Price) <= intVal2)
                                 select productImg).Take(9);
            }
            //...............................................search
            else if (!strSrch.Equals(""))
            {
                ProductImgLst = (from productImg in db.Products
                                 where (((productImg.Product_Name).ToLower()).Contains(strSrch.ToLower()))
                                 select productImg).Take(9);
            }
            
            //............................................................................Default start Page Image Load
            if (!ProductImgLst.Any())
            {
                ProductImgLst = (from productImg in db.Products
                                 select productImg).Take(9);
                //...............................................make price range on default list
                if (!strPrcRng.Equals(""))
                {
                    ProductImgLst = (from productImg in db.Products
                                     where ((productImg.Product_Price) > intVal1 && (productImg.Product_Price) < intVal2)
                                     select productImg).Take(9);
                }
            }

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
                //Session["ProductId"] = prdctImg.Product_Id;
                ImgDisplay += " </h6>";
                ImgDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdctImg.Product_Price) + "</h3>";
                ImgDisplay += " <ul class='action-button'>";
                ImgDisplay += " <li>";
                ImgDisplay += " <a href=# title=Wishlist><i class='zmdi zmdi-favorite'></i></a>";
                ImgDisplay += " </li>";

                ImgDisplay += " <li>";
                //ImgDisplay += " <a href='#' data-toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID("+ prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                ImgDisplay += " <asp:LinkButton href='#' data-toggle=modal data-target=#productModal title=Quickview id='btnQckVw' runat='server' CommandArgument='"+prdctImg.Product_Id+ "' OnClick='btnQckVw_Click'><i class='zmdi zmdi-zoom-in'></i></asp:LinkButton>";
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

            strSrch = "";
            strPrcRng = "";

        }

        void btnQckVw_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("/////////////////////Selected");
            LinkButton btn = (LinkButton)(sender);
            string val = btn.CommandArgument;
            Session["ProductId"] = val;
        }

        protected void btnSrchPrc_Click(object sender, EventArgs e)
        {
            //strPrcRng = amount.Value;
        }

        protected void btnSrchLst_Click(object sender, EventArgs e)
        {
            //strSrch = txtSrch.Value;
        }
    }
}