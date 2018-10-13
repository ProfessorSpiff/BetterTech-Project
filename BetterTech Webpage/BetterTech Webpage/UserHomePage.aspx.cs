using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class UserHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["Username"] != null)
            {
                String sessionuname = (String)HttpContext.Current.Session["Username"];
                var db = new DataLinqDataContext();
                var userdetails = (from g in db.Users
                                   where sessionuname.Equals(g.Username)
                                   select g).FirstOrDefault();

                lblun.InnerText = "Username: " + userdetails.Username;
                lblfn.InnerText = "First Name: " + userdetails.FirstName;
                Labelln.InnerText = "Surname: " + userdetails.Surname;
                Lble.InnerText = "E-Mail: " + userdetails.Email;
                Labelp.InnerText = "Province/city: " + userdetails.AddressLine1;
                Lblc.InnerText = "Physical Address: " + userdetails.AddressLine2;
                Lblzip.InnerText = "Zip Code: " + userdetails.ZipCode;

                //this code is copied from brij's attempt with the useraccountinfopage.aspx
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
                        strDisplay += "</div>";

                        strMnDisplay += strDisplay;
                    }
                    Invoices.InnerHtml = strMnDisplay;
                }

            }
        }

        protected void savebtn_Click(object sender, EventArgs e)
        {

            if (HttpContext.Current.Session["Username"] != null)
            {
                String sessionuname = (String)HttpContext.Current.Session["Username"];
                var db = new DataLinqDataContext();
                User userd = (from g in db.Users
                                   where sessionuname.Equals(g.Username)
                                   select g).FirstOrDefault();

                if (pass1.Value.Equals(pass2.Value))
                {
                userd.Username = UName.Value;
                userd.FirstName = fname.Value;
                userd.Surname =lname.Value;
                userd.Email =email.Value;
                userd.AddressLine1 =location1.Value;
                userd.AddressLine2 =location2.Value;
                userd.ZipCode =zipcode.Value;
                userd.Password = Secrecy.Secrecy.HashPassword(pass1.Value);
                }
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception exep) { exep.GetBaseException(); }
                Response.Redirect("UserHomePage.aspx");
            }
        }
    }
}