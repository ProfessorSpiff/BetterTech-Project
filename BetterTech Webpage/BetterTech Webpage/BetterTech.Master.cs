using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace BetterTech_Webpage
{
    public partial class BetterTech : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["Username"] != null)
            {
                myaccountlink.Visible = true;
                loginlink.Visible = false;
                logoutlink.Visible = true;
            }

            if ((String)HttpContext.Current.Session["AuthLevel"] == "Administrator")
            {
                cspecialslink.Visible = true;
            }

            //.............................................................................QuickView Product(not working)
            //if (HttpContext.Current.Session["ProductId"] != null)
            //{

            //    var db = new DataLinqDataContext();

            //    dynamic ProductQkVw = (from product in db.Products
            //                       where (product.Product_Id).Equals(Request.QueryString["ProductId"])
            //                       select product).FirstOrDefault();



            //    QckVwImg.InnerHtml = "<img alt='' src='" + ProductQkVw.Product_Img + "' width=270 height=300>";
            //    QckVwPrdctPrc.InnerHtml = "<span class='new-price'>R " + ProductQkVw.Product_Price + "</span>";
            //    QckVwPrdctSpecs.InnerHtml = ProductQkVw.Product_Description;


            //}

            if (Session["username"] != null)
            {
                var db = new DataLinqDataContext();

                var list = from w in db.Wishlists
                           where w.Username.Equals(Session["username"])
                           select w;

                int tot = 0;

                foreach (Wishlist w in list)
                {
                    ++tot;
                }

                wishlist.InnerHtml ="           <i class='zmdi zmdi-favorite'></i>" +  
                                                "Wish List("+Convert.ToString(tot)+")";

                wishlist.Visible = true;
            }
        }

        protected void Btnsearch_Click(object sender, EventArgs e)
        {
            String thingtosearch = "SearchPage.aspx?search=" + searchtext.Value;
            Response.Redirect(thingtosearch);
        }
    }
}