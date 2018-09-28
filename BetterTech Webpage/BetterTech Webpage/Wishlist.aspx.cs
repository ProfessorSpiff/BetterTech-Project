using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class Wishlist1 : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";

            //check if user is in session
            if(Session["username"] != null)
            {
                var db = new DataLinqDataContext();

                //get the current user's data
                var user = (from User u in db.Users
                           where Session["username"].Equals(u.Username)
                           select u).FirstOrDefault();

                // find what products on the users wishlist
                var wishlist = from w in db.Wishlists
                           where Session["username"].Equals(w.Username)
                           select w;

                foreach (Wishlist w in wishlist)
                {
                    //getting the product infromation, relative to the user, from the table
                    var product = (from Product p in db.Products
                                   where p.Product_Id.Equals(w.Product_Id)
                                   select p).FirstOrDefault();

                    //display all the infromation using innerHTML
                    display += "< td class='product-thumbnail'>";
                    display += "<div class='pro - thumbnail - img'>";
                    display += "<img src ='" + product.Product_Img + "' alt=''>";
                    display += "</div>";
                    display += "<div class='pro-thumbnail-info text-left'>";
                    display += "<h6 class='product-title-2'>";
                    display += "<a href = '#'>" + product.Product_Name +"</a>";
                    display += "</h6>";
                    display += "<p>Brand:" + product .Product_Brand + "</p>";
                    //                    display += "<p>Model:" + product.+" </p>";
                    //                    display += "<p> Color: Black, White</p>
                    display += "</div>";
                    display += "</td>";
                }
                detials.InnerHtml = display;
            }
        }
    }
}