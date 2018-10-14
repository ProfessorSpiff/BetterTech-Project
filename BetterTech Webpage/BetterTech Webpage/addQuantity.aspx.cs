using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class addQuantity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var db = new DataLinqDataContext();

            var cart = (from Cart c in db.Carts
                        where c.Product_Id.Equals(Request.QueryString["ProductId"])
                        select c).FirstOrDefault();

            var product = (from Product p in db.Products
                           where p.Product_Id.Equals(cart.Product_Id)
                           select p).FirstOrDefault();

            if(cart.Quantity < product.Product_OnHand)
            {
                cart.Quantity += 1;
            }
            
            
            db.SubmitChanges();
            
            Response.Redirect("Wishlist.aspx");
        }
    }
}