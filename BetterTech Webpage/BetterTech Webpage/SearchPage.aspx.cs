using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class SearchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String searchterm = Request.QueryString["Search"];
            String todisplay = "<p>You are searching for: " + searchterm + "</p>";
            String searchtermupper = searchterm.ToUpper();
             var db = new DataLinqDataContext();
            dynamic pro = from p in db.Products
                          select p;
            Boolean productfound = false;
            foreach (Product pr in pro)
            {
                String PName = pr.Product_Name.ToUpper();
                String PType = pr.Product_Type.ToUpper();
                String PBrand = pr.Product_Brand.ToUpper();
                if (searchtermupper.Contains(PName))
                {
                    productfound = true;
                    todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                    todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                    todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                    todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                } else if (searchtermupper.Contains(PType))
                {
                    productfound = true;
                    todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                    todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                    todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                    todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                } else if (searchtermupper.Contains(PBrand))
                {
                    productfound = true;
                    todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                    todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                    todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                    todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                }else
                {
                    productfound = false;
                }
                todisplay = todisplay + "<hr>";
            }
            if (productfound == false)
            {
                todisplay = todisplay + "Cannot find result";
            }
            productsearchdetails.InnerHtml = todisplay;
        }

        protected void btnsort_Click(object sender, EventArgs e)
        {
            String sorting = selectsection.Value;
            productsearchdetails.InnerHtml = "<p> Sorted by: " + sorting;
            var db = new DataLinqDataContext();
            if (sorting == "SortbyName")
            {
                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Name ascending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else
                    {
                        productfound = false;
                    }
                    todisplay = todisplay + "<hr>";
                }
                if (productfound == false)
                {
                    todisplay = todisplay + "Cannot find result";
                }
                productsearchdetails.InnerHtml = todisplay;
            }
            else if (sorting == "Sortbytype")
            {
                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Type ascending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else
                    {
                        productfound = false;
                    }
                    todisplay = todisplay + "<hr>";
                }
                if (productfound == false)
                {
                    todisplay = todisplay + "Cannot find result";
                }
                productsearchdetails.InnerHtml = todisplay;
            }
            else if (sorting == "SortbypriceHigh")
            {
                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Price descending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else
                    {
                        productfound = false;
                    }
                    todisplay = todisplay + "<hr>";
                }
                if (productfound == false)
                {
                    todisplay = todisplay + "Cannot find result";
                }
                productsearchdetails.InnerHtml = todisplay;
            }
            else if (sorting == "SortbypriceLow")
            {
                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Price ascending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else
                    {
                        productfound = false;
                    }
                    todisplay = todisplay + "<hr>";
                }
                if (productfound == false)
                {
                    todisplay = todisplay + "Cannot find result";
                }
                productsearchdetails.InnerHtml = todisplay;
            }
            else if (sorting == "Sortbybrand")
            {

                String searchterm = Request.QueryString["Search"];
                String todisplay = "<p>You are searching for: " + searchterm + "</p>";
                String searchtermupper = searchterm.ToUpper();
                dynamic pro = from p in db.Products
                              orderby p.Product_Brand ascending
                              select p;
                Boolean productfound = false;
                foreach (Product pr in pro)
                {
                    String PName = pr.Product_Name.ToUpper();
                    String PType = pr.Product_Type.ToUpper();
                    String PBrand = pr.Product_Brand.ToUpper();
                    if (searchtermupper.Contains(PName))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PType))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else if (searchtermupper.Contains(PBrand))
                    {
                        productfound = true;
                        todisplay = todisplay + "<img src=" + pr.Product_Img + " alt=''>";
                        todisplay = todisplay + "<a href=ProductPage.aspx?ProductId=" + pr.Product_Id + ">" + pr.Product_Name + "</a>";
                        todisplay = todisplay + "<p>" + pr.Product_Type + "</p>";
                        todisplay = todisplay + "<p>Product price: " + pr.Product_Price + "</p>";
                    }
                    else
                    {
                        productfound = false;
                    }
                    todisplay = todisplay + "<hr>";
                }
                if (productfound == false)
                {
                    todisplay = todisplay + "Cannot find result";
                }
                productsearchdetails.InnerHtml = todisplay;

            }

        }
    }
}