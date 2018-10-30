using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class EditProductPage : System.Web.UI.Page
    {
        private static string prdctID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            prdctID = Request.QueryString["EdtPrdctID"];
            txtprdctNmOld.Attributes.Add("readonly", "readonly");
            txtOldPrdctPrc.Attributes.Add("readonly", "readonly");
            txtOldDesrp.Attributes.Add("readonly", "readonly");
            txtOldPrdctTyp.Attributes.Add("readonly", "readonly");
            txtOldPrdctSldNum.Attributes.Add("readonly", "readonly");
            txtOldPrdctHnd.Attributes.Add("readonly", "readonly");
            txtOldPrctSpcl.Attributes.Add("readonly", "readonly");
            txtOldPrdctSpclPerc.Attributes.Add("readonly", "readonly");
            txtOldPrdctBrnd.Attributes.Add("readonly", "readonly");
            txtOldPrdctActv.Attributes.Add("readonly", "readonly");

            var db = new DataLinqDataContext();
            var Product = (from product in db.Products
                           where (product.Product_Id).Equals(Request.QueryString["EdtPrdctID"])
                           select product).FirstOrDefault();

            txtprdctNmOld.Text = Product.Product_Name;
            txtOldPrdctPrc.Text = "R"+String.Format("{0:0.00}", Product.Product_Price);
            txtOldDesrp.InnerText = Product.Product_Description;
            txtOldPrdctTyp.Text = Product.Product_Type;
            txtOldPrdctSldNum.Text = Convert.ToString(Product.Product_NumSold);
            txtOldPrdctHnd.Text = Convert.ToString(Product.Product_OnHand);
            if (Product.Product_IsSpecial == true)
            {
                txtOldPrctSpcl.Checked = true;
                txtOldPrctSpcl.Text = "Product on Special";
            }
            else
            {
                txtOldPrctSpcl.Checked = false;
                txtOldPrctSpcl.Text = "Product not on Special";
            }

            txtOldPrdctSpclPerc.Text = Convert.ToString(Product.Product_SpclPercantage) + "%";
            txtOldPrdctBrnd.Text = Product.Product_Brand;

            if (Product.Product_IsActive == true)
            {
                txtOldPrdctActv.Checked = true;
                txtOldPrdctActv.Text = "Product is Avtive";
            }
            else
            {
                txtOldPrdctActv.Checked = false;
                txtOldPrdctActv.Text = "Product is not Active";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            var Product = (from product in db.Products
                           where (product.Product_Id).Equals(prdctID)
                           select product).FirstOrDefault();

            if (!((txtNwPrdctNm.Text).Trim()).Equals(""))
            {
                Product.Product_Name = txtNwPrdctNm.Text;
            }
            if(!((txtNwPrdctPrc.Text).Trim()).Equals(""))
            {
                Product.Product_Price = Convert.ToDecimal(txtNwPrdctPrc.Text);
            }
            if(!((txtNwDesrp.InnerText).Trim()).Equals(""))
            {
                Product.Product_Description = txtNwDesrp.InnerText;
            }
            if (!((txtNwPrdctTyp.Text).Trim()).Equals(""))
            {
                Product.Product_Type = txtNwPrdctTyp.Text;
            }
            if(!((txtNwPrdctSldNum.Text).Trim()).Equals(""))
            {
                Product.Product_NumSold = Convert.ToInt32(txtNwPrdctSldNum.Text);
            }
            if(!((txtnwPrdctHnd.Text).Trim()).Equals(""))
            {
                Product.Product_OnHand = Convert.ToInt32(txtnwPrdctHnd.Text);
            }

            if(txtNwPrctSpcl.Checked == true)
            {
                Product.Product_IsSpecial = true;
            }
            else
            {
                Product.Product_IsSpecial = false;
            }

            if(!((txtNwPrdctSpclPerc.Text).Trim()).Equals(""))
            {
                Product.Product_SpclPercantage =(float) Convert.ToDouble(txtNwPrdctSpclPerc.Text);
            }

            if(!((txtNwPrdctBrnd.Text).Trim()).Equals(""))
            {
                Product.Product_Brand = txtNwPrdctBrnd.Text;
            }

            if(txtNwPrdctActv.Checked == true)
            {
                Product.Product_IsActive = true;
            }
            else
            {
                Product.Product_IsActive = true;
            }
            try
            {
                db.SubmitChanges();
            }catch(Exception ex)
            {
                ex.GetBaseException();
            }
        }
    }
}