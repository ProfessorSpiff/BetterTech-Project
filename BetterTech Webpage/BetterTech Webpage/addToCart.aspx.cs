using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class addToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();


            var wishlist = (from Wishlist w in db.Wishlists
                           where w.Product_Id.Equals(Request.QueryString["ProductId"])
                           select w).FirstOrDefault();

            var newCart = new Cart
            {
                
                Quantity = 1,
                Product_Id = wishlist.Product_Id,
                Username = Convert.ToString(Session["Username"])

            };

            db.Carts.InsertOnSubmit(newCart);
            db.SubmitChanges();
            
            db.Wishlists.DeleteOnSubmit(wishlist);
            db.SubmitChanges();

            Response.Redirect("Wishlist.aspx");
        }
    }
}