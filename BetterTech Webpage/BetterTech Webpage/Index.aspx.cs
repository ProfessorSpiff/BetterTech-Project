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

            //.............................................................Top Slider for Recently added Active products
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
                strDisplay += "<a href='ProductPage.aspx?ProductId=" + prdct.Product_Id+"' class='button extra-small button-black'>";
                strDisplay += "<span class='text-uppercase'>View Product</span>";
                strDisplay += "</a>";
                strDisplay += "</div>";
                strDisplay += "</div>";
                strDisplay += "</div>";
                strDisplay += "</div>";
            }
            topSldr.InnerHtml = strDisplay;

            //..................................................................................2nd Sldr Brand List

            dynamic BrandList = from prdctlst in db.Products
                                group prdctlst by prdctlst.Product_Brand into prdctTypLst
                                select prdctTypLst.Key;

            string DspInBrndLst = "";
            foreach(string prdctBrnd in BrandList)
            {
                DspInBrndLst += "<div class='col-xs-12'>";
                DspInBrndLst += "<div class='single-brand-product'>";
                DspInBrndLst += "<a href='CategoryPage.aspx?BrndNm="+prdctBrnd+"'><img src='App_Media/Product/Brand_"+prdctBrnd+ ".jpg' width=270 height=300 alt=''></a>";
                DspInBrndLst += "<h3 class='brand-title text-gray'>";
                DspInBrndLst += "<a href='CategoryPage.aspx?BrndNm="+ prdctBrnd + "'>"+prdctBrnd+"</a>";
                DspInBrndLst += "</h3>";
                DspInBrndLst += "</div>";
                DspInBrndLst += "</div>";
            }
            brandLst.InnerHtml = DspInBrndLst;

            //............................................................................3rd Sldr best selling product list

            dynamic bstSllngPrdct = (from prdclst in db.Products
                                     where (prdclst.Product_IsActive == true)
                                     orderby (prdclst.Product_NumSold) descending
                                     select prdclst).Take(10);

            string DspbstSldPrdct = "";
            foreach(Product prdct in bstSllngPrdct)
            {
                DspbstSldPrdct += " <div class='col-md-4 col-sm-4 col-xs-12'>";
                DspbstSldPrdct += " <div class='product-item'>";
                DspbstSldPrdct += " <div class='product-img'>";
                DspbstSldPrdct += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + ">";
                DspbstSldPrdct += " <img src=" + prdct.Product_Img + " height=300 width=270 alt=/>";
                DspbstSldPrdct += " </a>";
                DspbstSldPrdct += " </div>";
                DspbstSldPrdct += " <div class='product-info'>";
                DspbstSldPrdct += " <h6 class='product-title'>";
                DspbstSldPrdct += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + " >" + prdct.Product_Name + "</a>";
                //Session["ProductId"] = prdctImg.Product_Id;
                DspbstSldPrdct += " </h6>";
                DspbstSldPrdct += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdct.Product_Price) + "</h3>";
                DspbstSldPrdct += " <ul class='action-button'>";

                DspbstSldPrdct += " <li>";
                DspbstSldPrdct += " <a href='ProductPage.aspx?AddToWshLst=" + prdct.Product_Id + "' title=Wishlist><i class='zmdi zmdi-favorite'></i></a>";
                DspbstSldPrdct += " </li>";

                //DspbstSldPrdct += " <li>";
                //DspbstSldPrdct += " <a href='#' data-toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID("+ prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //DspbstSldPrdct += " <a href='CategoryPage.aspx?s=<%=Session('"+ prdctImg.Product_Id + "')%> data -toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID(" + prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //DspbstSldPrdct += " <asp:LinkButton href='#' data-toggle=modal data-target=#productModal title=Quickview id='btnQckVw' runat='server' CommandArgument='"+prdctImg.Product_Id+ "' OnClick='btnQckVw_Click'><i class='zmdi zmdi-zoom-in'></i></asp:LinkButton>";
                //DspbstSldPrdct += " </li>";

                //DspbstSldPrdct += " <li>";
                //DspbstSldPrdct += " <a href=# title=Compare><i class='zmdi zmdi-refresh'></i></a>";
                //DspbstSldPrdct += " </li>";

                DspbstSldPrdct += " <li>";
                DspbstSldPrdct += " <a href='ProductPage.aspx?AddToShpCrt=" + prdct.Product_Id + "' title=Add to cart><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
                DspbstSldPrdct += " </li>";

                DspbstSldPrdct += " </ul>";
                DspbstSldPrdct += " </div>";
                DspbstSldPrdct += " </div>";
                DspbstSldPrdct += " </div>";
            }
            bstSldPrdct.InnerHtml = DspbstSldPrdct;

            //............................................................................new arrival product list

            dynamic nwArvlLst = (from prdct in db.Products
                                  where (prdct.Product_IsActive == true)
                                  orderby (prdct.Product_DateAdded) descending
                                  select prdct).Take(8);

            string DspNwArvl = "";
            foreach(Product prdct in nwArvlLst)
            {
                DspNwArvl += " <div class='col-md-3 col-sm-4 col-xs-12'>";
                DspNwArvl += " <div class='product-item'>";
                DspNwArvl += " <div class='product-img'>";
                DspNwArvl += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + ">";
                DspNwArvl += " <img src=" + prdct.Product_Img + " height=300 width=270 alt=/>";
                DspNwArvl += " </a>";
                DspNwArvl += " </div>";
                DspNwArvl += " <div class='product-info'>";
                DspNwArvl += " <h6 class='product-title'>";
                DspNwArvl += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + " >" + prdct.Product_Name + "</a>";
                //Session["ProductId"] = prdctImg.Product_Id;
                DspNwArvl += " </h6>";
                DspNwArvl += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdct.Product_Price) + "</h3>";
                DspNwArvl += " <ul class='action-button'>";

                DspNwArvl += " <li>";
                DspNwArvl += " <a href='ProductPage.aspx?AddToWshLst=" + prdct.Product_Id + "' title=Wishlist><i class='zmdi zmdi-favorite'></i></a>";
                DspNwArvl += " </li>";

                //DspNwArvl += " <li>";
                //DspNwArvl += " <a href='#' data-toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID("+ prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //DspNwArvl += " <a href='CategoryPage.aspx?s=<%=Session('"+ prdctImg.Product_Id + "')%> data -toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID(" + prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //DspNwArvl += " <asp:LinkButton href='#' data-toggle=modal data-target=#productModal title=Quickview id='btnQckVw' runat='server' CommandArgument='"+prdctImg.Product_Id+ "' OnClick='btnQckVw_Click'><i class='zmdi zmdi-zoom-in'></i></asp:LinkButton>";
                //DspNwArvl += " </li>";

                //DspNwArvl += " <li>";
                //DspNwArvl += " <a href=# title=Compare><i class='zmdi zmdi-refresh'></i></a>";
                //DspNwArvl += " </li>";

                DspNwArvl += " <li>";
                DspNwArvl += " <a href='ProductPage.aspx?AddToShpCrt=" + prdct.Product_Id + "' title=Add to cart><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
                DspNwArvl += " </li>";

                DspNwArvl += " </ul>";
                DspNwArvl += " </div>";
                DspNwArvl += " </div>";
                DspNwArvl += " </div>";
            }
            nwArrvl.InnerHtml = DspNwArvl;

            //............................................................................Special products list

            dynamic SpclPrdctLst = (from prdct in db.Products
                                    where (prdct.Product_IsActive == true) &&
                                    (prdct.Product_IsSpecial == true)
                                    select prdct).Take(8);

            string DspSpclPrdct = "";
            foreach(Product prdct in SpclPrdctLst)
            {
                DspSpclPrdct += " <div class='col-md-3 col-sm-4 col-xs-12'>";
                DspSpclPrdct += " <div class='product-item'>";
                DspSpclPrdct += " <div class='product-img'>";
                DspSpclPrdct += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + ">";
                DspSpclPrdct += " <img src=" + prdct.Product_Img + " height=300 width=270 alt=/>";
                DspSpclPrdct += " </a>";
                DspSpclPrdct += " </div>";
                DspSpclPrdct += " <div class='product-info'>";
                DspSpclPrdct += " <h6 class='product-title'>";
                DspSpclPrdct += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + " >" + prdct.Product_Name + "</a>";
                //Session["ProductId"] = prdctImg.Product_Id;
                DspSpclPrdct += " </h6>";
                DspSpclPrdct += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdct.Product_Price) + "</h3>";
                DspSpclPrdct += " <ul class='action-button'>";

                DspSpclPrdct += " <li>";
                DspSpclPrdct += " <a href='ProductPage.aspx?AddToWshLst=" + prdct.Product_Id + "' title=Wishlist><i class='zmdi zmdi-favorite'></i></a>";
                DspSpclPrdct += " </li>";

                //DspSpclPrdct += " <li>";
                //DspSpclPrdct += " <a href='#' data-toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID("+ prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //DspSpclPrdct += " <a href='CategoryPage.aspx?s=<%=Session('"+ prdctImg.Product_Id + "')%> data -toggle=modal data-target=#productModal title=Quickview id='QckVw' OnServerClick='setProductID(" + prdctImg.Product_Id + ")'><i class='zmdi zmdi-zoom-in'></i></a>";
                //DspSpclPrdct += " <asp:LinkButton href='#' data-toggle=modal data-target=#productModal title=Quickview id='btnQckVw' runat='server' CommandArgument='"+prdctImg.Product_Id+ "' OnClick='btnQckVw_Click'><i class='zmdi zmdi-zoom-in'></i></asp:LinkButton>";
                //DspSpclPrdct += " </li>";

                //DspSpclPrdct += " <li>";
                //DspSpclPrdct += " <a href=# title=Compare><i class='zmdi zmdi-refresh'></i></a>";
                //DspSpclPrdct += " </li>";

                DspSpclPrdct += " <li>";
                DspSpclPrdct += " <a href='ProductPage.aspx?AddToShpCrt=" + prdct.Product_Id + "' title=Add to cart><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
                DspSpclPrdct += " </li>";

                DspSpclPrdct += " </ul>";
                DspSpclPrdct += " </div>";
                DspSpclPrdct += " </div>";
                DspSpclPrdct += " </div>";
            }
            spclPrdcts.InnerHtml = DspSpclPrdct;
        }
    }
}