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
                ifloggedin.Visible = true;
                if ((String)HttpContext.Current.Session["AuthLevel"] == "Admin")
                {
                    myadminaccountlink.Visible = true;
                    footaccAdmin.Visible = true;
                }
                if ((String)HttpContext.Current.Session["AuthLevel"] == "User")
                {
                    myuseraccountlink.Visible = true;
                    footaccuser.Visible = true;
                }
                loginlink.Visible = false;
                logoutlink.Visible = true;
            }

            



            //......................................................Show number of items in whishlist

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

            //......................................................Shopping cart preview
            if(HttpContext.Current.Session["Username"] != null)
            {
                string DspCart = "";
                var db = new DataLinqDataContext();
                dynamic UserCart = from cart in db.Carts
                                   where ((cart.Username).Equals(HttpContext.Current.Session["Username"]))
                                   select cart;

                int itmCnt = (from cart in db.Carts
                              where ((cart.Username).Equals(HttpContext.Current.Session["Username"]))
                              select cart).Count();
                
                DspCart += "<div class='total-cart-in'>";
                DspCart += "<div class='cart-toggler'>";
                DspCart += "<a href='Wishlist.aspx'>";
                
                DspCart += "<span class='cart-quantity'>" + itmCnt + "</span><br>";
                DspCart += "<span class='cart-icon'>";
                DspCart += "<i class='zmdi zmdi-shopping-cart-plus'></i>";
                DspCart += "</span>";
                DspCart += "</a>";
                DspCart += "</div>";
                DspCart += "<ul>";
                DspCart += "<li>";
                DspCart += "<div class='top-cart-inner your-cart'>";
                DspCart += "<h5 class='text-capitalize'>"+ HttpContext.Current.Session["Username"] + "'s Cart</h5>";
                DspCart += "</div>";
                DspCart += "</li>";
                DspCart += "<li>";
                DspCart += "<div class='total-cart-pro'>";

                Decimal Total = 0;
                if (UserCart != null)
                {
                    foreach(Cart crt in UserCart)
                    {
                        var UserProduct = (from product in db.Products
                                           where (crt.Product_Id).Equals(product.Product_Id)
                                           select product).FirstOrDefault();

                        DspCart += "<div class='single-cart clearfix'>";
                        DspCart += "<div class='cart-img f-left'>";
                        DspCart += "<a href='ProductPage.aspx?ProductId=" + crt.Product_Id + "'>";
                        DspCart += "<img src='" + UserProduct.Product_Img + "' alt='Cart Product' width=100 height=111 />";
                        DspCart += "</a>";
                        DspCart += "<div class='del-icon'>";
                        DspCart += "<a href='ProductPage.aspx?DelFrmShpCrt="+crt.Product_Id+"'>";
                        DspCart += "<i class='zmdi zmdi-close'></i>";
                        DspCart += "</a>";
                        DspCart += "</div>";
                        DspCart += "</div>";
                        DspCart += "<div class='cart-info f-left'>";
                        DspCart += "<h6 class='text-capitalize'>";
                        DspCart += "<a href='ProductPage.aspx?ProductId=" + crt.Product_Id + "'>" + UserProduct.Product_Name + "</a>";
                        DspCart += "</h6>";
                        DspCart += "<p>";
                        DspCart += "<span>Brand <strong>:</strong></span>" + UserProduct.Product_Brand;
                        DspCart += "</p>";
                        DspCart += "<p>";
                        if(UserProduct.Product_IsSpecial == true)
                        {
                            decimal prc = ((UserProduct.Product_Price) - Convert.ToDecimal((UserProduct.Product_Price) * Convert.ToDecimal(UserProduct.Product_SpclPercantage / 100)));
                            Total += ((crt.Quantity) * prc);
                            DspCart += "<span>Price <strong>:</strong></span>R " + String.Format("{0:0.00}", prc);
                        }
                        else
                        {
                            Decimal prc2 = UserProduct.Product_Price;
                            Total += ((crt.Quantity) * prc2);
                            DspCart += "<span>Price <strong>:</strong></span>R " + String.Format("{0:0.00}", prc2);
                        }
                        DspCart += "</p>";
                        DspCart += "<p>";
                        DspCart += "<span>Quantity <strong>:</strong></span>" + crt.Quantity;
                        DspCart += "</p>";
                        DspCart += "</div>";
                        DspCart += "</div>";
                    }//...............................end of forloop
                    DspCart += "</div>";
                    DspCart += "</li>";
                    DspCart += "<li>";
                    DspCart += "<div class='top-cart-inner subtotal'>";
                    DspCart += "<h4 class='text-uppercase g-font-2'>Total  =";
                    DspCart += "<span>R "+ String.Format("{0:0.00}", Total) + "</span>";
                    DspCart += "</h4>";
                    DspCart += "</div>";
                    DspCart += "</li>";
                    DspCart += "<li>";
                    DspCart += "<div class='top-cart-inner view-cart'>";
                    DspCart += "<h4 class='text-uppercase'>";
                    DspCart += "<a href='Wishlist.aspx'>View cart</a>";
                    DspCart += "</h4>";
                    DspCart += "</div>";
                    DspCart += "</li>";
                    DspCart += "</ul>";
                }//..................................................end of if
                PrvwCart.InnerHtml = DspCart;
            }
        }

        protected void Btnsearch_Click(object sender, EventArgs e)
        {
            String thingtosearch = "SearchPage.aspx?search=" + searchtext.Value;
            Response.Redirect(thingtosearch);
        }
    }
}