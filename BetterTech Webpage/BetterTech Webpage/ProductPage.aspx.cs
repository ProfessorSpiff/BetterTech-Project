using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace BetterTech_Webpage
{
    public partial class ProductPage : System.Web.UI.Page
    {
        private static int PrdctQty = 1;
        private static int PrdctID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var db = new DataLinqDataContext();

            //...........................................................................................Product Category List
            string divCategoryDisplay = "";

            dynamic ProductList = from product in db.Products
                                  group product by product.Product_Type into productTypeLst
                                  select productTypeLst.Key;

            divCategoryDisplay += " <li class='closed'><a href='CategoryPage.aspx?Category=AllSpecial'>View All Special Products</a></li>";
            foreach (string prdctType in ProductList)
            {

                divCategoryDisplay += " <li class=closed><a href=CategoryPage.aspx?Category=" + prdctType + ">" + prdctType + "</a>";

                //dynamic ProductItmLst = (from item in db.Products
                //                         where (item.Product_Type.Equals(prdctType)) || (item.Product_IsSpecial == true)
                //                         select item).Take(3);

                dynamic ProductItmLst = (from item in db.Products
                                         where (item.Product_Type.Equals(prdctType) &&
                                        (item.Product_IsActive == true))
                                         select item).Take(3);

                divCategoryDisplay += "<ul>";
                divCategoryDisplay += "<li><a href='CategoryPage.aspx?CategorySpcl=" + prdctType + "'>View All " + prdctType + " Specials</a></li>";
                foreach (Product prdctItm in ProductItmLst)
                {
                    //divCategoryDisplay += "<li><a href=#>" + prdctItm.Product_Name + "</a></li>";
                    divCategoryDisplay += "<li><a href='ProductPage.aspx?ProductId=" + prdctItm.Product_Id + "'>" + prdctItm.Product_Name + "</a></li>";
                }
                divCategoryDisplay += "<li><a href='CategoryPage.aspx?Category=" + prdctType + "'>View All</a></li>";
                divCategoryDisplay += "</ul>";
                divCategoryDisplay += "</li>";
            }

            ulCategoryList.InnerHtml = divCategoryDisplay;

            //..............................................................................Populate Recent Products

            dynamic RecentProductList = (from product in db.Products
                                         where (product.Product_IsActive == true)
                                         orderby product.Product_DateAdded descending
                                         select product).Take(3);

            string strDisplayRcnt = "";
            strDisplayRcnt += "<h6 class='widget-title border-left mb-20'>recent products</h6>";
            foreach (Product prdct in RecentProductList)
            {
                strDisplayRcnt += " <div class='product-item'>";
                strDisplayRcnt += " <div class='product-img'>";
                strDisplayRcnt += " <a href='ProductPage.aspx?ProductId=" + prdct.Product_Id + "'>";
                strDisplayRcnt += " <img src='" + prdct.Product_Img + "' alt='' width=90 height=80/>";
                strDisplayRcnt += " </a>";
                strDisplayRcnt += " </div>";
                strDisplayRcnt += " <div class='product-info'>";
                strDisplayRcnt += " <h6 class='product-title'>";
                strDisplayRcnt += " <a href='ProductPage.aspx?ProductId=" + prdct.Product_Id + "'>" + prdct.Product_Name + "</a>";
                strDisplayRcnt += " </h6>";
                strDisplayRcnt += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdct.Product_Price) + "</h3>";
                strDisplayRcnt += " </div>";
                strDisplayRcnt += " </div>";
            }

            WidgetProduct.InnerHtml = strDisplayRcnt;

            //.............................................................................Show Details of Selected Product
            if (Request.QueryString["ProductId"] != null)
            {
                //PrdctID = Convert.ToInt32(Request.QueryString["ProductId"]);
                if(!PrdctID.Equals(Convert.ToInt32(Request.QueryString["ProductId"])))
                {
                    PrdctID = Convert.ToInt32(Request.QueryString["ProductId"]);
                    PrdctQty = 1;
                }

                //..................................................................Selected Product Specifications

                var Product = (from product in db.Products
                               where (product.Product_Id).Equals(Request.QueryString["ProductId"])
                               select product).FirstOrDefault();

                PrdctNmBrnd.InnerHtml = "<h3 class='text-black-1'>" + Product.Product_Name + "</h3>" + " <h6 class='brand-name-2'>" + Product.Product_Brand + "</h6>";

                description.InnerHtml = "<p>" + Product.Product_Description + "</p>";

                ProductImg.InnerHtml = "<img id='zoom_03' src='" + Product.Product_Img + "' data-zoom-image='" + Product.Product_Img + "' alt=''>";

                string DspPrc = "";
                if (Product.Product_IsSpecial == true)
                {
                    decimal prc1 = (Product.Product_Price) - ((Product.Product_Price) * Convert.ToDecimal(Product.Product_SpclPercantage / 100));
                    DspPrc += "<h5>Old Price</h5>";
                    DspPrc += "<s>" + String.Format("{0:0.00}", Product.Product_Price) + "</s>";
                    DspPrc += "<h5>Special Price</h5>";
                    DspPrc += "<h6><mark>" + String.Format("{0:0.00}", prc1) + "</mark></h6>";
                }
                else
                {
                    DspPrc += "<h5>Price</h5>";
                    DspPrc += "<h6><mark>" + String.Format("{0:0.00}", Product.Product_Price) + "</mark></h6>";
                }
                PriceDsp.InnerHtml = DspPrc;

                string strBtnActnDsply = "";

                strBtnActnDsply += "<ul class='action-button'>";

                strBtnActnDsply += "<li>";
                strBtnActnDsply += "<a href='ProductPage.aspx?AddToWshLst="+(Request.QueryString["ProductId"]) +"' title='Wishlist' tabindex='0'><i class='zmdi zmdi-favorite'></i></a>";
                strBtnActnDsply += "</li>";

                strBtnActnDsply += "<li>";
                strBtnActnDsply += "<a href='ProductPage.aspx?AddToShpCrt="+(Request.QueryString["ProductId"]) +"' title='Add to cart' tabindex='0'><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
                strBtnActnDsply += "</li>";

                if ((HttpContext.Current.Session["AuthLevel"] != null) && (HttpContext.Current.Session["AuthLevel"].Equals("Admin"))) {
                    strBtnActnDsply += "<li>";
                    strBtnActnDsply += "<a href='EditProductPage.aspx?EdtPrdctID=" + (Request.QueryString["ProductId"]) + "' title='Edit Product' tabindex='0'><i class='zmdi zmdi zmdi-edit'></i></a>";
                    strBtnActnDsply += "</li>";
                }
                
                strBtnActnDsply += "</ul>";

                btnAction.InnerHtml = strBtnActnDsply;



                //.............................................................................Related Product Images


                var RelatedProduct = (from product in db.Products
                                      where (product.Product_Id).Equals(Request.QueryString["ProductId"])
                                      select product).FirstOrDefault();

                dynamic RelatedPrdctLst = (from product in db.Products
                                           where (product.Product_Type).Equals(RelatedProduct.Product_Type) &&
                                           (!(product.Product_Id).Equals(RelatedProduct.Product_Id)) &&
                                           (product.Product_IsActive == true)
                                           select product).Take(3);

                string strDisplay = "";
                foreach (Product prdct in RelatedPrdctLst)
                {
                    strDisplay += " <div class='col-xs-12'>";
                    strDisplay += " <div class='product-item'>";
                    strDisplay += " <div class='product-img'>";
                    strDisplay += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + ">";
                    strDisplay += " <img src=" + prdct.Product_Img + " height=300 width=270 alt=/>";
                    strDisplay += " </a>";
                    strDisplay += " </div>";
                    strDisplay += " <div class='product-info'>";
                    strDisplay += " <h6 class='product-title'>";
                    strDisplay += " <a href=ProductPage.aspx?ProductId=" + prdct.Product_Id + " >" + prdct.Product_Name + "</a>";
                    strDisplay += " </h6>";
                    //strDisplay += " <div class='pro-rating'>";
                    //strDisplay += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                    //strDisplay += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                    //strDisplay += " <a href=#><i class='zmdi zmdi-star'></i></a>";
                    //strDisplay += " <a href=#><i class='zmdi zmdi-star-half'></i></a>";
                    //strDisplay += " <a href=#><i class='zmdi zmdi-star-outline'></i></a>";
                    //strDisplay += " </div>";
                    strDisplay += " <h3 class='pro-price'>R" + String.Format("{0:0.00}", prdct.Product_Price) + "</h3>";
                    strDisplay += " <ul class='action-button'>";

                    strDisplay += " <li>";
                    strDisplay += " <a href='ProductPage.aspx?AddToWshLst=" + prdct.Product_Id + "' title=Wishlist><i class='zmdi zmdi-favorite'></i></a>";
                    strDisplay += " </li>";

                    //strDisplay += " <li>";
                    //strDisplay += " <a href=# data-toggle=modal data-target=#productModal title=Quickview><i class='zmdi zmdi-zoom-in'></i></a>";
                    //strDisplay += " </li>";

                    //strDisplay += " <li>";
                    //strDisplay += " <a href=# title=Compare><i class='zmdi zmdi-refresh'></i></a>";
                    //strDisplay += " </li>";

                    strDisplay += " <li>";
                    strDisplay += " <a href='ProductPage.aspx?AddToShpCrt=" + prdct.Product_Id + "' title=Add to cart><i class='zmdi zmdi-shopping-cart-plus'></i></a>";
                    strDisplay += " </li>";

                    strDisplay += " </ul>";
                    strDisplay += " </div>";
                    strDisplay += " </div>";
                    strDisplay += " </div>";
                }//...........................................end of foreach
                RelatedPrdct.InnerHtml = strDisplay;
            }//.................................................................end of if

            //.......................................................add to wishlist of the user
            else if(Request.QueryString["AddToWshLst"] != null)
            {
                if (!PrdctID.Equals(Convert.ToInt32(Request.QueryString["AddToWshLst"])))
                {
                    PrdctID = Convert.ToInt32(Request.QueryString["AddToWshLst"]);
                    PrdctQty = 1;
                }

                if (HttpContext.Current.Session["Username"] != null)
                {
                    var chkWshLst = (from wishlst in db.Wishlists
                                     where ((wishlst.Username).Equals(HttpContext.Current.Session["Username"])) &&
                                     ((wishlst.Product_Id).Equals(Request.QueryString["AddToShpCrt"]))
                                     select wishlst).FirstOrDefault();

                    if (chkWshLst == null)
                    {
                        var AddToWshList = new Wishlist
                        {
                            Username = Convert.ToString(HttpContext.Current.Session["Username"]),
                            Product_Id = Convert.ToInt32(Request.QueryString["AddToWshLst"]),
                        };
                        db.Wishlists.InsertOnSubmit(AddToWshList);

                        try
                        {
                            db.SubmitChanges();
                            Response.Redirect("CategoryPage.aspx");
                        }
                        catch (Exception ex)
                        {
                            ex.GetBaseException();
                        }
                    }
                    
                }
                else
                {
                    Session["AddListItm"] = Request.QueryString["AddToWshLst"];
                    Response.Redirect("Login.aspx");
                }
            }//...............................................................end of else if

            //...........................................................Adding to shopping cart
            else if(Request.QueryString["AddToShpCrt"] != null)
            {
                if (!PrdctID.Equals(Convert.ToInt32(Request.QueryString["AddToShpCrt"])))
                {
                    PrdctID = Convert.ToInt32(Request.QueryString["AddToShpCrt"]);
                    PrdctQty = 1;
                }

                if (HttpContext.Current.Session["Username"] != null)
                {
                    //.................................................check if item exist in cart
                    var ChckCart = (from cart in db.Carts
                                    where ((cart.Product_Id).Equals(Request.QueryString["AddToShpCrt"])) &&
                                    ((cart.Username).Equals(HttpContext.Current.Session["Username"]))
                                    select cart).FirstOrDefault();
                    
                    if(ChckCart != null)
                    {
                        int RlQty = ChckCart.Quantity;
                        RlQty = RlQty + PrdctQty;
                        

                        int getPrdct = (from product in db.Products
                                        where (product.Product_Id.Equals(Request.QueryString["AddToShpCrt"]))
                                        select product.Product_OnHand).FirstOrDefault();
                        if(ChckCart.Quantity < getPrdct)
                        {
                            ChckCart.Quantity = RlQty;
                            try
                            {
                                db.SubmitChanges();
                            }
                            catch (Exception ex)
                            {
                                ex.GetBaseException();
                            }
                        }
                        
                    }else
                    {
                        //.................................................adding to cart table
                        Debug.WriteLine(PrdctQty);
                        var AddToCart = new Cart
                        {
                            Product_Id = Convert.ToInt32(Request.QueryString["AddToShpCrt"]),
                            Quantity = PrdctQty,
                            Username = Convert.ToString(HttpContext.Current.Session["Username"]),
                        };
                        db.Carts.InsertOnSubmit(AddToCart);
                        try
                        {
                            db.SubmitChanges();
                            //Response.Redirect("CategoryPage.aspx");
                        }
                        catch (Exception ex)
                        {
                            ex.GetBaseException();
                        }
                    }
                    
                    //.............................................deleting item from wishlist if exists
                    var CheckWshLst = (from wishlst in db.Wishlists
                                       where ((wishlst.Username).Equals(HttpContext.Current.Session["Username"])) &&
                                       ((wishlst.Product_Id).Equals(Request.QueryString["AddToShpCrt"]))
                                       select wishlst).FirstOrDefault();

                    if(CheckWshLst != null)
                    {
                        db.Wishlists.DeleteOnSubmit(CheckWshLst);
                        try
                        {
                            db.SubmitChanges();
                        }catch(Exception ex)
                        {
                            ex.GetBaseException();
                        }
                    }

                    Response.Redirect("CategoryPage.aspx");
                }
                else
                {
                    Session["AddListItm"] = Request.QueryString["AddToShpCrt"];
                    Response.Redirect("Login.aspx");
                }
            }//................................................................end of else if

            //.................................................................Removing from Shopping cart
            else if(Request.QueryString["DelFrmShpCrt"] != null)
            {
                var DelFromShopCart = (from cart in db.Carts
                                       where ((cart.Username).Equals(HttpContext.Current.Session["Username"])) &&
                                       ((cart.Product_Id).Equals(Request.QueryString["DelFrmShpCrt"]))
                                       select cart).FirstOrDefault();

                db.Carts.DeleteOnSubmit(DelFromShopCart);
                try
                {
                    db.SubmitChanges();
                    Response.Redirect("CategoryPage.aspx");
                }catch(Exception ex)
                {
                    ex.GetBaseException();
                }
            }

        }//.......................................................................................end of pageload

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            
            int intQty = Convert.ToInt32(lblQty.Text);

            var db = new DataLinqDataContext();
            int getPrdct = (from product in db.Products
                           where (product.Product_Id.Equals(Request.QueryString["AddToShpCrt"])) ||
                           (product.Product_Id.Equals(Request.QueryString["AddToWshLst"])) ||
                           (product.Product_Id.Equals(Request.QueryString["ProductId"]))
                            select product.Product_OnHand).FirstOrDefault();
            
            if(intQty < getPrdct)
            {
                lblQty.Text =(Convert.ToString(intQty + 1));
                PrdctQty = Convert.ToInt32(lblQty.Text);


            }
            Debug.WriteLine(lblQty.Text);
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            int intQty = Convert.ToInt32(lblQty.Text);
            if(intQty > 1)
            {
                lblQty.Text = Convert.ToString(intQty - 1);
                PrdctQty = Convert.ToInt32(lblQty.Text);
            }
        }
    }
}