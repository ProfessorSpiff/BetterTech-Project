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

            //......................................................................................Product Category List
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
        }
    }
}