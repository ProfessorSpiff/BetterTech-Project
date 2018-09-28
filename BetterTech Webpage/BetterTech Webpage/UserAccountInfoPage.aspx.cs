using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class InvoicesPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //.....................................................................For Displaying Logged-In User's Invoices

            var db = new DataLinqDataContext();

            dynamic InvoicesList = from invoices in db.Invoices
                                       //where (invoices.Username).Equals(Session["Username"])
                                   where (invoices.Username).Equals("Eva")//.....checking purpose only
                                   select invoices;

            if (InvoicesList != null)
            {
                string strMnDisplay = "";
                foreach (Invoice inv in InvoicesList)
                {
                    string strDisplay = "<div class='payment-details p-30'>";
                    strDisplay += "<table>";

                    dynamic ItemsList = from item in db.Items
                                        where (inv.Invoice_Id).Equals(item.Invoice_Id)
                                        select item;

                    foreach (Item itm in ItemsList)
                    {
                        var Product = (from product in db.Products
                                       where (product.Product_Id).Equals(itm.Product_Id)
                                       select product).FirstOrDefault();
                        
                        strDisplay += "<tr>";
                        strDisplay += "<td class='td-title-1'>" + Product.Product_Name + " X " + itm.Item_Qty + "</td>";
                        strDisplay += "<td class='td-title-2'>R" + String.Format("{0:0.00}", itm.Item_SellingPrice) + "</td>";
                        strDisplay += "</tr>"; 
                    }
                    strDisplay += "<tr>";
                    strDisplay += "<td class='order-total'>Order Total</td>";
                    strDisplay += "<td class='order-total-price'>R" + String.Format("{0:0.00}", inv.Invoice_Total) + "</td>";
                    strDisplay += "</tr>";
                    strDisplay += "</table>"; 

                    strDisplay += "<button class='submit-btn-1 mt-20 btn-hover-1' type='submit' value='register'>Save</button>";
                    strDisplay += "</div>";

                    strMnDisplay += strDisplay;
                }
                Invoices.InnerHtml = strMnDisplay;
            }
        }
    }
}