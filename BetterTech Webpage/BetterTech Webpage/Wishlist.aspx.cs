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
                display += "<table class='text-center'>";
                display += "<thead>";
                display += "                                      <tr>";
                display += "                                           <th class='product-thumbnail'>product</th>";
                display +="                                            <th class='product-price'>price</th>";
                display +="                                            <th class='product-stock'>Stock status</th>";
                display +="                                            <th class='product-add-cart'>add to cart</th>";
                display +="                                            <th class='product-remove'>remove</th>";
                display += "                                        </tr>";
                display += "                                  </thead>";
                display += "</thead>";
                display += "<tbody>";



              /*  display += "                                        <tr>";
                display += "                                            <td class='product-thumbnail'>";
                display += "                                                 <div class='pro -thumbnail-img'>";
                display += "                                                     <img src = 'img /cart/2.jpg' alt=''>";
                display += "                                                 </div>";
                display += "                                                 <div class='pro -thumbnail-info text-left'>";
                display += "                                                    <h6 class='product -title-2'>";
                display += "                                                        <a href = '#' > dummy product name</a>";
                display += "                                                    </h6>";
                display += "                                                    <p>Brand: Brand Name</p>";
                display += "                                                    <p>Model: Grand s2</p>";
                display += "                                                    <p> Color: Black, White</p>";
                display += "                                                    </div>";
                display += "                                            </td>";
                display += "                                            <td class='product -price'>$560.00</td>";
                display += "                                            <td class='product -stock text-uppercase'>in stoct</td>";
                display += "                                            <td class='product -add-cart'>";
                display += "                                                <a href = '#' title='Add To Cart'>";
                display += "                                                    <i class='zmdi zmdi-shopping-cart-plus'></i>";
                display += "                                                </a>";
                display += "                                            </td>";
                display += "                                            <td class='product -remove'>";
                display += "                                                <a href = '#' ><i class='zmdi zmdi-close'></i></a>";
                display += "                                            </td>";
                display += "                                        </tr>"; */

                foreach (Wishlist w in wishlist)
                {
                    //getting the product infromation, relative to the user, from the table
                    var product = (from Product p in db.Products
                                   where p.Product_Id.Equals(w.Product_Id)
                                   select p).FirstOrDefault();

                    //display all the infromation using innerHTML
                    //         display += "<div>";
                    display += "<tr>";
                    display += "<td class='product-thumbnail'>";
                    display += "<div class='pro-thumbnail-img'>";
                    display += "<img src ='" + product.Product_Img + "' alt='' width='10' hight='10'>";
                    display += "</div>";
                    display += "<div class='pro-thumbnail-info text-left'>";
                    display += "<h6 class='product-title-2'>";
                    display += "<a href = '#'>" + product.Product_Name +"</a>";
                    display += "</h6>";
                    display += "<p>Brand:" + product.Product_Brand + "</p>";
                    //                    display += "<p>Model:" + product.+" </p>";
                    //                    display += "<p> Color: Black, White</p>
                    display += "</div>";
                    display += "</td>"; 

                    display += "                                        <td class='product-price'>" + product.Product_Price +"</td>";
                    display += "                                        <td class='product-stock text-uppercase'>" + "in stoct" + "</td>";
                    display += "                                         <td class='product-add-cart'>";
                    display += "                                             <a href = '#' title = 'Add To Cart'>";
                    display += "                                                <i class='zmdi zmdi-shopping-cart-plus'></i>";
                    display += "                                            </a>";
                    display += "                                        </td>";
                    display += "                                        <td class='product-remove'>";
                    display += "                                            <a href = '#'><i class='zmdi zmdi-close'></i></a>";
                    display += "                                        </td>";
                    //        display += "</div>"; 

                    display += "</tr>";
                } 

                display += "</tbody>";
                display += "</table>";
                b.InnerHtml = display;
            }
        }
    }
}