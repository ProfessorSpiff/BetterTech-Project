﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class CRUDProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var db = new DataLinqDataContext();

            dynamic products = from a in db.Products
                               select a;
            string displayDelete = "";
            string displayEdit = "";
            foreach (Product p in products)
            {
                if(p.Product_IsActive == true)
                {
                    displayDelete += "<p>Product ID: " + p.Product_Id + "   </p>";
                    displayDelete += "<p>Product Name: " + p.Product_Name + "</p></br>";
                }
                displayEdit += "<p>Product ID: " + p.Product_Id + "   </p>";
                displayEdit += "<p>Product Name: " + p.Product_Name + "</p></br>";
            }
            removeProd.InnerHtml = displayDelete;
            editProd.InnerHtml = displayEdit;
        }

        protected void removeBtn_Click(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            int id = int.Parse(deleteId.Value);

            var deleteP = (from p in db.Products
                          where p.Product_Id == id
                          select p).FirstOrDefault();
            deleteP.Product_IsActive = false;
            db.SubmitChanges();
            Response.Redirect("AdminHomePage.aspx");
        }

        protected void addProd_Click(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();
            dynamic products = from a in db.Products
                               select a;
            bool isReg = false;
            if (isReg == false)
            {
                Product newProd = new Product
                {
                    Product_Name = prodName.Value,
                    Product_Price = Convert.ToDecimal(prodPrice.Value),
                    Product_Description = prodDesc.Value,
                    Product_Type = prodType.Value,
                    Product_Img = prodImg.Value,
                    Product_OnHand = int.Parse(prodOnHand.Value),
                    Product_Brand = prodBrand.Value,
                    Product_DateAdded = DateTime.Now,
                    Product_IsActive = true,
                    Product_IsSpecial = false,
                    Product_NumSold = 0,
                    Product_SpclPercantage = 0
                };
                db.Products.InsertOnSubmit(newProd);
                try
                {
                    db.SubmitChanges();
                    Response.Redirect("AdminHomePage.aspx");
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    addResponse.InnerHtml = "<div class=alert alert-danger><strong>Warning!</strong> An error occurred, please try again.</div>";
                }
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            int productID = int.Parse(prodId.Value);
            var prodd = (from Product a in db.Products
                         where a.Product_Id.Equals(productID)
                         select a).FirstOrDefault();
            var thingtochange = edit.Value;
            string value = prodEdit1.Value;
            if (thingtochange.Equals("editName"))
            {
                prodd.Product_Name = value;
            }
            if (thingtochange.Equals("editPrice"))
            {
                prodd.Product_Price = Convert.ToDecimal(value);
            }
            if (thingtochange.Equals("editDesc"))
            {
                prodd.Product_Description = value;
            }
            if (thingtochange.Equals("editType"))
            {
                prodd.Product_Type = value;
            }
            if (thingtochange.Equals("editImg"))
            {
                prodd.Product_Img = value;
            }
            if (thingtochange.Equals("editOH"))
            {
                prodd.Product_OnHand = int.Parse(value);
            }
            if (thingtochange.Equals("editBrand"))
            {
                prodd.Product_Brand = value;
            }
            db.SubmitChanges();
        }
    }
}