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
                string strDisplay = "<h3>Invoice History:</h3>";

                //this code is copied from brij's attempt with the useraccountinfopage.aspx
                dynamic InvoicesList = from invoices in db.Invoices
                                        where (invoices.Username).Equals(Session["Username"])
                                      // where (invoices.Username).Equals("Eva")//.....checking purpose only
                                       select invoices;

                if (InvoicesList != null)
                {
                    foreach (Invoice inv in InvoicesList)
                    {
                        strDisplay += "<p></p>";
                        strDisplay += "<div class='payment-details p-30'>";
                        strDisplay += "<h4>Invoice:  " + inv.Invoice_Id + "</h4>";
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
                    }
                    Invoices.InnerHtml = strDisplay;
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

                if (!(fname.Value.Equals("")))
                {
                    userd.FirstName = fname.Value;
                }
                if (!(lname.Value.Equals("")))
                {
                    userd.Surname = lname.Value;
                }
                if (!(email.Value.Equals("")))
                {
                    userd.Email = email.Value;
                }
                if (!(location1.Value.Equals("")))
                {
                    userd.AddressLine1 = location1.Value;
                }
                if (!(location2.Value.Equals("")))
                {
                    userd.AddressLine2 = location2.Value;
                }
                if (!(zipcode.Value.Equals("")))
                {
                    userd.ZipCode = zipcode.Value;
                }

                if (Secrecy.Secrecy.HashPassword(oldPassword.Value).Equals(userd.Password))
                {                 
                    if (!(pass1.Value.Equals("")))
                    {
                        if (pass1.Value.Equals(pass2.Value))
                        {
                            userd.Password = Secrecy.Secrecy.HashPassword(pass1.Value);
                            result.InnerText = "Password Changed";
                        }
                    }
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