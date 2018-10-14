using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class close : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            var cart = (from Cart c in db.Carts
                        where c.Product_Id.Equals(Request.QueryString["ProductId"])
                        select c).FirstOrDefault();

           db.Carts.DeleteOnSubmit(cart);

            db.SubmitChanges();

            Response.Redirect("Wishlist.aspx");


        }

    }
}