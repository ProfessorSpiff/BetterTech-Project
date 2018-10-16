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
        int totalSubCart = 0;
        int numOfProducts = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            string displayW = "";
            //check if user is in session
            if (Session["username"] != null)
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
                displayW += "<table class='text-center'>";
                displayW += "<thead>";
                displayW += "                                      <tr>";
                displayW += "                                           <th class='product-thumbnail'>product</th>";
                displayW +="                                            <th class='product-price'>price</th>";
                displayW +="                                            <th class='product-stock'>Stock status</th>";
                displayW +="                                            <th class='product-add-cart'>add to cart</th>";
                displayW +="                                            <th class='product-remove'>remove</th>";
                displayW += "                                        </tr>";
                displayW += "                                  </thead>";
                displayW += "</thead>";
                displayW += "<tbody>";

                foreach (Wishlist w in wishlist)
                {
                    //getting the product infromation, relative to the user, from the table
                    var product = (from Product p in db.Products
                                   where p.Product_Id.Equals(w.Product_Id)
                                   select p).FirstOrDefault();

                    //display all the infromation using innerHTML
                    //         display += "<div>";
                    displayW += "<tr>";
                    displayW += "<td class='product-thumbnail'>";
                    displayW += "<div class='pro-thumbnail-img'>";
                    displayW += "<img src ='" + product.Product_Img + "' alt='' width='10' hight='10'>";
                    displayW += "</div>";
                    displayW += "<div class='pro-thumbnail-info text-left'>";
                    displayW += "<h6 class='product-title-2'>";
                    displayW += "<a href = '#'>" + product.Product_Name +"</a>";
                    displayW += "</h6>";
                    displayW += "<p>Brand:" + product.Product_Brand + "</p>";
                    //                    display += "<p>Model:" + product.+" </p>";
                    //                    display += "<p> Color: Black, White</p>
                    displayW += "</div>";
                    displayW += "</td>"; 

                    displayW += "                                        <td class='product-price'>" + String.Format("{0:0.00}", product.Product_Price) + "</td>";
                    if (product.Product_OnHand > 0)
                    {
                        displayW += "                                        <td class='product-stock text-uppercase'>" + "in stock" + "</td>";
                    }else
                    {
                        displayW += "                                        <td class='product-stock text-uppercase'>" + "Not in Stock" + "</td>";
                    }
                    displayW += "                                         <td class='product-add-cart'>";
                    displayW += "                                             <a href = '#' title = 'Add To Cart'>";
                    displayW += "                                                <a href= 'addToCart.aspx?ProductId="+ w.Product_Id +"'><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
                    displayW += "                                            </a>";
                    displayW += "                                        </td>";
                    displayW += "                                        <td class='product-remove'>";
                    displayW += "                                            <a href = 'removeFromWishlist.aspx?ProductId=" + w.Product_Id + "'><i class='zmdi zmdi-close'></i></a>";
                    displayW += "                                        </td>";

                    displayW += "</tr>";
                } 

                displayW += "</tbody>";
                displayW += "</table>";
                b.InnerHtml = displayW;
                
                ////////////////

                var displayCart = "";
                var vat = 0.00;

            var cart = from Cart c in db.Carts
                           where c.Username.Equals(Session["username"])
                           select c;

                displayCart += "<table class='text-center'>";
                displayCart += "<thead>";
                displayCart += "                                      <tr>";
                displayCart+= "                                           <th class='product-thumbnail'>product</th>";
                displayCart += "                                            <th class='product-price'>price</th>";
                displayCart += "                                            <th class='product-quantity'>Quantity</th>";
                displayCart += "                                            <th class='product-subtotal'>total</th>";
                displayCart += "                                            <th class='product-remove'>remove</th>";
                displayCart += "                                        </tr>";
                displayCart += "                                  </thead>";
                displayCart += "</thead>";
                displayCart += "<tbody>";

                var shipping = 0.00;

                foreach (Cart c in cart)
                {
                    //getting the product infromation, relative to the user, from the table
                    var product = (from Product p in db.Products
                                   where p.Product_Id.Equals(c.Product_Id)
                                   select p).FirstOrDefault();


                    var totalProductPrice = product.Product_Price * c.Quantity;

                    //display all the infromation using innerHTML
                    //         display += "<div>";
                    displayCart += "<tr>";
                    displayCart += "<td class='product-thumbnail'>";
                    displayCart += "<div class='pro-thumbnail-img'>";
                    displayCart += "<img src ='" + product.Product_Img + "' alt='' width='10' hight='10'>";
                    displayCart += "</div>";
                    displayCart += "<div class='pro-thumbnail-info text-left'>";
                    displayCart += "<h6 class='product-title-2'>";
                    displayCart += "<a href = '#'>" + product.Product_Name + "</a>";
                    displayCart += "</h6>";
                    displayCart += "<p>Brand:" + product.Product_Brand + "</p>";
                    //                    display += "<p>Model:" + product.+" </p>";
                    //                    display += "<p> Color: Black, White</p>
                    displayCart += "</div>";
                    displayCart += "</td>";

                    displayCart += "                                        <td class='product-price'>" + String.Format("{0:0.00}" ,product.Product_Price) + "</td>";
                    displayCart += "                                     <td class='product-quantity'>";
                    displayCart += "                                            <div>";
                    displayCart += "                                               <a href = 'minusQuantity.aspx?ProductId=" + product.Product_Id + "'>-</a>";
                    displayCart += "                                               <label>" + c.Quantity +"</lable>";

                    displayCart += "                                               <a href = 'addQuantity.aspx?ProductId=" + product.Product_Id + "'>+</a>";
                    displayCart += "                                            </div>";
                    displayCart += "                                        </td>";
                    displayCart += "                                         <td class='product - subtotal'>" + String.Format("{0:0.00}", totalProductPrice) + "</td>";
                    displayCart += "                                        <td class='product-remove'>";
                    displayCart += "                                            <a href = 'close.aspx?ProductId=" + product.Product_Id+ "'><i class='zmdi zmdi-close'></i></a>";
                    displayCart += "                                        </td>";

                    displayCart += "</tr>";

                    ++numOfProducts;
                    totalSubCart += Convert.ToInt32(totalProductPrice);
                    vat += Convert.ToInt64(totalProductPrice * 15/100);
                    shipping += Convert.ToInt64(totalProductPrice * 5 / 100);
                }
                
                displayCart += "</tbody>";
                displayCart += "</table>";
            
                var orderTotal = vat + shipping + totalSubCart;

                tdCartSubtotal.InnerText = "R" + String.Format("{0:0.00}",totalSubCart);
                tdShipping.InnerText = "R" + shipping;
                tdVat.InnerText = "R" + vat;
                tdTotalPrice.InnerText = "R" + String.Format("{0:0.00}", orderTotal);
                cartDisplay.InnerHtml = displayCart;

                //////

                var displayOrder = "";

                displayOrder += "                                      <h6 class='widget -title border-left mb-20'>Your order</h6>";
                displayOrder += "                                        <table>";

                foreach (Cart c in cart)
                {
                    var product = (from Product p in db.Products
                                   where p.Product_Id.Equals(c.Product_Id)
                                   select p).FirstOrDefault();

                    displayOrder += "                                            <tr>";
                    if (c.Quantity > 1)
                    {
                        displayOrder += "                                                <td class='td -title-1'>" + product.Product_Name + " X" + c.Quantity +"</td>";
                    }else
                    {
                        displayOrder += "                                                <td class='td -title-1'>" + product.Product_Name + "</td>";

                    }
                    displayOrder += "                                                <td class='td -title-2'>R" + String.Format("{0: 0.00}", product.Product_Price) + "</td>";
                    displayOrder += "                                            </tr>";
                }

                displayOrder += "                                            <tr>";
                displayOrder += "                                                <td class='td -title-1'>Cart Subtotal</td>";
                displayOrder += "                                                <td class='td -title-2'>R" + String.Format("{0:0.00}", totalSubCart) + "</td>";
                displayOrder += "                                            </tr>";

                displayOrder += "                                            <tr>";
                displayOrder += "                                                <td class='td -title-1'>Shipping and Handing</td>";
                displayOrder += "                                                <td class='td -title-2'>" + shipping +"</td>";
                displayOrder += "                                            </tr>";
                displayOrder += "                                            <tr>";
                displayOrder += "                                                <td class='td -title-1'>Vat</td>";
                displayOrder += "                                                <td class='td -title-2'>R"+ vat +"</td>";
                displayOrder += "                                            </tr>";
                displayOrder += "                                            <tr>";
                displayOrder += "                                                <td class='order -total'>Order Total</td>";
                displayOrder += "                                                <td class='order -total-price'>R"+ String.Format("{0:0.00}", orderTotal)  + "</td>";
                displayOrder += "                                            </tr>";
                displayOrder += "                                       </table>";
                
                checkoutOrder.InnerHtml = displayOrder;
                displayOrderComplete.InnerHtml = displayOrder;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(numOfProducts > 0)
            {
                var address = txtAddress.Value.Trim();

                var db = new DataLinqDataContext();

                var newInvoice = new Invoice
                {
                    Invoice_Date = DateTime.Now,
                    Username = Convert.ToString(Session["username"]),
                    Invoice_Total = totalSubCart
                };

                db.Invoices.InsertOnSubmit(newInvoice);
                db.SubmitChanges();

                liAddress.InnerText = address;

                var cart = from Cart c in db.Carts
                           where c.Username.Equals(Session["username"])
                           select c;

                foreach (Cart c in cart)
                {
                    db.Carts.DeleteOnSubmit(c);
                    db.SubmitChanges();

                    var product = (from Product p in db.Products
                                   where p.Product_Id.Equals(c.Product_Id)
                                   select p).FirstOrDefault();

                    product.Product_OnHand -= c.Quantity;
                    db.SubmitChanges();
                }

                displayOrderNo1.InnerText = Convert.ToString(newInvoice.Invoice_Id);

                // Response.Redirect("Wishlist.aspx#order-complete");
                //  liPhone = phone;

                //preferences.Attributes.Remove("class");
                //preferences.Attributes.Add("class", "tab-pane");
                //cpuBut.Attributes.Add("class", "active");
                //cpu.Attributes.Remove("class");
                //cpu.Attributes.Add("class", "tab-pane active");

            }
        }
       
    }
}