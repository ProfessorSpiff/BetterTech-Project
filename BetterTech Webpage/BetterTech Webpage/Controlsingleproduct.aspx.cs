using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace BetterTech_Webpage
{
    public partial class Controlsingleproduct : System.Web.UI.Page
    {
        public int ProductID=0; 

        protected void Page_Load(object sender, EventArgs e)
        {

            var db = new DataLinqDataContext();
            string todisplay = "<p> Updating of price of product </p>";
            Product Pro = (from p in db.Products
                           where p.Product_Id.Equals(Request.QueryString["ProductId"])
                           select p).FirstOrDefault();

            todisplay = todisplay + "<img src=" + Pro.Product_Img + " alt=''>";
            todisplay = todisplay + "<p>" + Pro.Product_Name + "</p>";
            todisplay = todisplay + "<p>Current Product price:R " + Pro.Product_Price + "</p>";
            todisplay = todisplay + "<p>Current Discount Percentage: " + Pro.Product_SpclPercantage + "</p>";

            //if (Pro.Product_IsSpecial == true)
            //{
            //    Cbspecial.Checked = true;
            //}
            //else
            //{
            //    Cbspecial.Checked = false;
            //}

            singlepro.InnerHtml = todisplay;
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {

            ProductID = Convert.ToInt32(Request.QueryString["ProductId"]);
            if (ProductID == 0)
            {
               Response.Redirect("ControlSpecials.aspx",false);
            }
            else
            {
                var db = new DataLinqDataContext();
                string todisplay = "<p> Updating of price of product </p>";
                Product Pro = (from p in db.Products
                               where p.Product_Id.Equals(ProductID)
                               select p).FirstOrDefault();

                int newpercent = Convert.ToInt32(newper.Value);
                Pro.Product_SpclPercantage = newpercent;
                int newcostdiff = Convert.ToInt32(Pro.Product_Price*(newpercent/100));
                int totalcost= Convert.ToInt32(Pro.Product_Price - newcostdiff);

                //if (Cbspecial.Checked==true)
                //{
                //    Debug.WriteLine("Checked");
                //    Pro.Product_IsSpecial = true;
                //}
                //else if (Cbspecial.Checked == false)
                //{
                //    Pro.Product_IsSpecial = false;
                //}

                if (newpercent == 0)
                {
                    Pro.Product_IsSpecial = false;
                }
                else
                {
                    Pro.Product_IsSpecial = true;
                }
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception exep) { exep.GetBaseException(); }

                todisplay = todisplay + "New Price:R " + totalcost;
                singlepro.InnerHtml = todisplay;
                Response.Redirect("ControlSpecials.aspx", false);
            }
        }
    }
}