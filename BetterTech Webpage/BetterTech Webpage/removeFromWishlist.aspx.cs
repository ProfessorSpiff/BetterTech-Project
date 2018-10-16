using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class removeFromWishlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            var wish = (from Wishlist w in db.Wishlists
                        where w.Product_Id.Equals(Request.QueryString["ProductId"])
                        select w).FirstOrDefault();

            db.Wishlists.DeleteOnSubmit(wish);

            db.SubmitChanges();

            Response.Redirect("Wishlist.aspx");
        }
    }
}