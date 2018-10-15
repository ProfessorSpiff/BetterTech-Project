using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Reflection;

namespace BetterTech_Webpage
{
   
    public partial class CategoryPage : System.Web.UI.Page
    {
        protected string strPrcRng = "";
        protected string strSrch = "";

        //protected int intNumToShow = 3;
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();
        
            //...........................................................................................Product Category List
            string divCategoryDisplay = "";
            
            dynamic ProductList = from product in db.Products
                                      group product by product.Product_Type into productTypeLst
                                      select productTypeLst.Key;

            divCategoryDisplay += " <li class='closed'><a href='CategoryPage.aspx?Category=AllSpecial'>View All Special Products</a></li>";
            foreach (string prdctType in ProductList)
            {

                divCategoryDisplay += " <li class='closed'><a href='CategoryPage.aspx?Category="+ prdctType + "'>"+ prdctType + "</a>";

                dynamic ProductItmLst = (from item in db.Products
                                        where (item.Product_Type.Equals(prdctType) &&
                                        (item.Product_IsActive == true))
                                        select item).Take(3);
                divCategoryDisplay += "<ul>";
                divCategoryDisplay += "<li><a href='CategoryPage.aspx?CategorySpcl=" + prdctType + "'>View All " + prdctType + " Specials</a></li>";
                foreach (Product prdctItm in ProductItmLst)
                {
                    divCategoryDisplay += "<li><a href='ProductPage.aspx?ProductId=" + prdctItm.Product_Id+"'>" + prdctItm.Product_Name + "</a></li>";
                }
                divCategoryDisplay += "<li><a href='CategoryPage.aspx?Category="+prdctType+"'>View All "+prdctType+"</a></li>";
                divCategoryDisplay += "</ul>";
                divCategoryDisplay += "</li>";
            }

            ulCategoryList.InnerHtml = divCategoryDisplay;

            //.............................................................................................Populate Web page With Image
            string ImgDisplay = "";
            string ImgDisplay2 = "";

            //...........................Search value
            if(strSrch.Equals(""))
            {
                strSrch = txtSrch.Value;
            }
            strPrcRng = amount.Value;//.........................amount range value

            int intVal1 = 0;
            int intVal2 = 0;
            
            var ProductImgLst = (from productImg in db.Products
                                 where productImg.Product_Type.Equals(Request.QueryString["Category"])
                                 select productImg);
            
            //..............................................where price range match for particular category
            //if (!strPrcRng.Equals(""))
            //{
            //    ProductImgLst = (from productImg in db.Products
            //                     where (productImg.Product_Type.Equals(Request.QueryString["Category"]))
            //                     //&& ((productImg.Product_Price) >= intVal1 && (productImg.Product_Price) <= intVal2)
            //                     select productImg);
            //}

            //............................................................................View Products by Brand
            if(Request.QueryString["BrndNm"] != null)
            {
                ProductImgLst = from productImg in db.Products
                                where (productImg.Product_Brand.Equals(Request.QueryString["BrndNm"]))
                                select productImg;
            }
           
            //............................................................................Default start Page Image Load
            if (!ProductImgLst.Any())
            {
                ProductImgLst = (from productImg in db.Products
                                 select productImg);
                //...............................................make price range on default list
                if (!strPrcRng.Equals(""))
                {
                    ProductImgLst = (from productImg in db.Products
                                     where ((productImg.Product_Price) > intVal1 && (productImg.Product_Price) < intVal2)
                                     select productImg);
                }
            }

            //.............................................................................Specials for particular category
            if ((Request.QueryString["CategorySpcl"]) != null)
            {
                //strSrch = "";
                ProductImgLst = from productImg in db.Products
                                where ((productImg.Product_Type).Equals(Request.QueryString["CategorySpcl"])) &&
                                ((productImg.Product_IsSpecial).Equals(true)) 
                                select productImg;
            }

            //...................................................................Specials for all products
            if ((Request.QueryString["Category"]) == "AllSpecial")
            {
                //strSrch = "";
                ProductImgLst = (from productImg in db.Products
                                 where ((productImg.Product_IsSpecial).Equals(true))
                                 
                                 select productImg);
            }

            //..............................................................Search for product
            if ((!strSrch.Equals("")))
            {
                ProductImgLst = (from productImg in db.Products
                                 where (((productImg.Product_Name).ToLower()).Contains(strSrch.ToLower()))
                                 select productImg);
            }

            
            if(HttpContext.Current.Session["PgNum"] == null)
            {
                Session["PgNum"] = 9;
            }

            if (!strPrcRng.Equals(""))
            {
                intVal1 = Convert.ToInt32(strPrcRng.Substring(strPrcRng.IndexOf("R") + 1, strPrcRng.IndexOf("-") - 1));
                intVal2 = Convert.ToInt32(strPrcRng.Substring(strPrcRng.IndexOf("-") + 3));

                ProductImgLst = (from productImg in ProductImgLst
                                 where ((productImg.Product_IsActive) == true)
                                 && ((productImg.Product_Price) >= intVal1 && (productImg.Product_Price) <= intVal2)
                                 select productImg).Take(Convert.ToInt16(HttpContext.Current.Session["PgNum"]));
            }
            else
            {
                ProductImgLst = (from productImg in ProductImgLst
                                 where ((productImg.Product_IsActive) == true)
                                 select productImg).Take(Convert.ToInt16(HttpContext.Current.Session["PgNum"]));
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
                ImgDisplay += " <a href='ProductPage.aspx?AddToWshLst="+ prdctImg.Product_Id+ "' title=Wishlist><i class='zmdi zmdi-favorite'></i></a>";
                ImgDisplay += " </li>";

                //ImgDisplay += " <li>";
                //ImgDisplay += " <a href='#' data-toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID("+ prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //ImgDisplay += " <a href='CategoryPage.aspx?s=<%=Session('"+ prdctImg.Product_Id + "')%> data -toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID(" + prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //ImgDisplay += " <asp:LinkButton href='#' data-toggle=modal data-target=#productModal title=Quickview id='btnQckVw' runat='server' CommandArgument='"+prdctImg.Product_Id+ "' OnClick='btnQckVw_Click'><i class='zmdi zmdi-zoom-in'></i></asp:LinkButton>";
                //ImgDisplay += " </li>";

                //ImgDisplay += " <li>";
                //ImgDisplay += " <a href=# title=Compare><i class='zmdi zmdi-refresh'></i></a>";
                //ImgDisplay += " </li>";

                ImgDisplay += " <li>";
                ImgDisplay += " <a href='ProductPage.aspx?AddToShpCrt="+prdctImg.Product_Id+"' title=Add to cart><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
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

                //ImgDisplay += " <li>";
                //ImgDisplay += " <a href='#' data-toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID("+ prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //ImgDisplay += " <a href='CategoryPage.aspx?s=<%=Session('"+ prdctImg.Product_Id + "')%> data -toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID(" + prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //ImgDisplay += " <asp:LinkButton href='#' data-toggle=modal data-target=#productModal title=Quickview id='btnQckVw' runat='server' CommandArgument='"+prdctImg.Product_Id+ "' OnClick='btnQckVw_Click'><i class='zmdi zmdi-zoom-in'></i></asp:LinkButton>";
                //ImgDisplay += " </li>";

                //ImgDisplay += " <li>";
                //ImgDisplay += " <a href=# title=Compare><i class='zmdi zmdi-refresh'></i></a>";
                //ImgDisplay += " </li>";

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
                                         where (product.Product_IsActive == true)
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

        }//..........................................................end of page load
        
        protected void btnSrchPrc_Click(object sender, EventArgs e)
        {
            //strPrcRng = amount.Value;
            
        }

        protected void btnSrchLst_Click(object sender, EventArgs e)
        {
            //strSrch = txtSrch.Value;
        }

        protected void btnShwMore_Click(object sender, EventArgs e)
        {
            int intNum = Convert.ToInt16(HttpContext.Current.Session["PgNum"]);
            Session["PgNum"] = (intNum + 3);
            
            Page.Response.Redirect(Page.Request.Url.ToString());
        }

        protected void btnShwLess_Click(object sender, EventArgs e)
        {
            Session["PgNum"] = null;
            
            Page.Response.Redirect(Page.Request.Url.ToString());
        }
    }
}