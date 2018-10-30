using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
	public partial class Finalise : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            var db = new DataLinqDataContext();
            var cpu = (from Product b in db.Products
                       where b.Product_Id.Equals(Request.QueryString["cpu"])
                       select b).FirstOrDefault();
            var mobo = (from Product c in db.Products
                       where c.Product_Id.Equals(Request.QueryString["mobo"])
                       select c).FirstOrDefault();
            var cool = (from Product d in db.Products
                       where d.Product_Id.Equals(Request.QueryString["cool"])
                       select d).FirstOrDefault();
            var gpu = (from Product f in db.Products
                       where f.Product_Id.Equals(Request.QueryString["gpu"])
                       select f).FirstOrDefault();
            var mem = (from Product g in db.Products
                       where g.Product_Id.Equals(Request.QueryString["mem"])
                       select g).FirstOrDefault();
            var hard = (from Product h in db.Products
                       where h.Product_Id.Equals(Request.QueryString["hard"])
                       select h).FirstOrDefault();
            var psu = (from Product i in db.Products
                       where i.Product_Id.Equals(Request.QueryString["psu"])
                       select i).FirstOrDefault();
            var casee = (from Product j in db.Products
                       where j.Product_Id.Equals(Request.QueryString["case"])
                       select j).FirstOrDefault();
            string display = "";
            display += "<table class=text-center>";
            display += "<thead>";
            display += "<tr>";
            display += "<th class=product-thumbnail>product</th>";
            display += "<th class=product-price>price</th>";
            display += "</tr>";
            display += "</thead>";

            display += "<tbody>";
            display += "<tr>";
            display += "<td class=\"product-thumbnail\">";
            display += "<div class=\"pro-thumbnail-img\">";
            display += "<img src=" + cpu.Product_Img + " alt=>";
            display += "</div>";
            display += "<div class=\"pro-thumbnail-info text-left\">";
            display += "<h6 class=\"product-title-2\">";
            display += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu.Product_Id + ">" + cpu.Product_Name + "</a>";
            display += "</h6>";
            display += "<p>Brand: " + cpu.Product_Brand + "</p>";
            display += "</div>";
            display += "</td>";
            display += "<td class=\"product-price\">" + cpu.Product_Price + "</td>";

            display += "<tbody>";
            display += "<tr>";
            display += "<td class=\"product-thumbnail\">";
            display += "<div class=\"pro-thumbnail-img\">";
            display += "<img src=" + mobo.Product_Img + " alt=>";
            display += "</div>";
            display += "<div class=\"pro-thumbnail-info text-left\">";
            display += "<h6 class=\"product-title-2\">";
            display += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo.Product_Id + ">" + mobo.Product_Name + "</a>";
            display += "</h6>";
            display += "<p>Brand: " + mobo.Product_Brand + "</p>";
            display += "</div>";
            display += "</td>";
            display += "<td class=\"product-price\">" + mobo.Product_Price + "</td>";

            display += "<tbody>";
            display += "<tr>";
            display += "<td class=\"product-thumbnail\">";
            display += "<div class=\"pro-thumbnail-img\">";
            display += "<img src=" + cool.Product_Img + " alt=>";
            display += "</div>";
            display += "<div class=\"pro-thumbnail-info text-left\">";
            display += "<h6 class=\"product-title-2\">";
            display += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool.Product_Id + ">" + cool.Product_Name + "</a>";
            display += "</h6>";
            display += "<p>Brand: " + cool.Product_Brand + "</p>";
            display += "</div>";
            display += "</td>";
            display += "<td class=\"product-price\">" + cool.Product_Price + "</td>";

            display += "<tbody>";
            display += "<tr>";
            display += "<td class=\"product-thumbnail\">";
            display += "<div class=\"pro-thumbnail-img\">";
            display += "<img src=" + gpu.Product_Img + " alt=>";
            display += "</div>";
            display += "<div class=\"pro-thumbnail-info text-left\">";
            display += "<h6 class=\"product-title-2\">";
            display += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu.Product_Id + ">" + gpu.Product_Name + "</a>";
            display += "</h6>";
            display += "<p>Brand: " + gpu.Product_Brand + "</p>";
            display += "</div>";
            display += "</td>";
            display += "<td class=\"product-price\">" + gpu.Product_Price + "</td>";

            display += "<tbody>";
            display += "<tr>";
            display += "<td class=\"product-thumbnail\">";
            display += "<div class=\"pro-thumbnail-img\">";
            display += "<img src=" + mem.Product_Img + " alt=>";
            display += "</div>";
            display += "<div class=\"pro-thumbnail-info text-left\">";
            display += "<h6 class=\"product-title-2\">";
            display += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem.Product_Id + ">" + mem.Product_Name + "</a>";
            display += "</h6>";
            display += "<p>Brand: " + mem.Product_Brand + "</p>";
            display += "</div>";
            display += "</td>";
            display += "<td class=\"product-price\">" + mem.Product_Price + "</td>";

            display += "<tbody>";
            display += "<tr>";
            display += "<td class=\"product-thumbnail\">";
            display += "<div class=\"pro-thumbnail-img\">";
            display += "<img src=" + hard.Product_Img + " alt=>";
            display += "</div>";
            display += "<div class=\"pro-thumbnail-info text-left\">";
            display += "<h6 class=\"product-title-2\">";
            display += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard.Product_Id + ">" + hard.Product_Name + "</a>";
            display += "</h6>";
            display += "<p>Brand: " + hard.Product_Brand + "</p>";
            display += "</div>";
            display += "</td>";
            display += "<td class=\"product-price\">" + hard.Product_Price + "</td>";

            display += "<tr>";
            display += "<td class=\"product-thumbnail\">";
            display += "<div class=\"pro-thumbnail-img\">";
            display += "<img src=" + psu.Product_Img + " alt=>";
            display += "</div>";
            display += "<div class=\"pro-thumbnail-info text-left\">";
            display += "<h6 class=\"product-title-2\">";
            display += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu.Product_Id + ">" + psu.Product_Name + "</a>";
            display += "</h6>";
            display += "<p>Brand: " + psu.Product_Brand + "</p>";
            display += "</div>";
            display += "</td>";
            display += "<td class=\"product-price\">" + psu.Product_Price + "</td>";

            display += "<tr>";
            display += "<td class=\"product-thumbnail\">";
            display += "<div class=\"pro-thumbnail-img\">";
            display += "<img src=" + casee.Product_Img + " alt=>";
            display += "</div>";
            display += "<div class=\"pro-thumbnail-info text-left\">";
            display += "<h6 class=\"product-title-2\">";
            display += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + casee.Product_Id + ">" + casee.Product_Name + "</a>";
            display += "</h6>";
            display += "<p>Brand: " + casee.Product_Brand + "</p>";
            display += "</div>";
            display += "</td>";
            display += "<td class=\"product-price\">" + casee.Product_Price + "</td>";

            display += "</tr>";
            display += "</tbody>";
            display += "</table>";
        }

        protected void final_Click(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();
            var cpu = (from Product b in db.Products
                       where b.Product_Id.Equals(Request.QueryString["cpu"])
                       select b).FirstOrDefault();
            var mobo = (from Product c in db.Products
                        where c.Product_Id.Equals(Request.QueryString["mobo"])
                        select c).FirstOrDefault();
            var cool = (from Product d in db.Products
                        where d.Product_Id.Equals(Request.QueryString["cool"])
                        select d).FirstOrDefault();
            var gpu = (from Product f in db.Products
                       where f.Product_Id.Equals(Request.QueryString["gpu"])
                       select f).FirstOrDefault();
            var mem = (from Product g in db.Products
                       where g.Product_Id.Equals(Request.QueryString["mem"])
                       select g).FirstOrDefault();
            var hard = (from Product h in db.Products
                        where h.Product_Id.Equals(Request.QueryString["hard"])
                        select h).FirstOrDefault();
            var psu = (from Product i in db.Products
                       where i.Product_Id.Equals(Request.QueryString["psu"])
                       select i).FirstOrDefault();
            var casee = (from Product j in db.Products
                         where j.Product_Id.Equals(Request.QueryString["case"])
                         select j).FirstOrDefault();
        }
    }
}