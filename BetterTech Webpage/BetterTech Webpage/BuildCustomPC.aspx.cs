using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class BuildCustomPC : System.Web.UI.Page
    {
        public double cpuPer{ get; set; }
        public double gpuPer { get; set; }
        public double moboPer { get; set; }
        public double ramPer { get; set; }
        public double hardPer { get; set; }
        public double psuPer { get; set; }
        public double accPer { get; set; }
        public double casePer { get; set; }
        public double coolPer { get; set; }
        public bool chosen { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            moboPer = 0.12;
            ramPer = 0.12;
            hardPer = 0.08;
            psuPer = 0.08;
            casePer = 0.05;
            coolPer = 0.05;
            accPer = 0.05;
        }

        protected void videoChoose_Click(object sender, EventArgs e)
        {
            cpuPer = 0.2;
            gpuPer = 0.3;
            chosen = true;
            var db = new DataLinqDataContext();

            dynamic products = from a in db.Products
                               select a;

            int bud = int.Parse(budget.Value);
            var cpuBud = bud * cpuPer;
            var gpuBud = bud * gpuPer;
            var moboBud = bud * moboPer;
            var ramBud = bud * ramPer;
            var hardBud = bud * hardPer;
            var psuBud = bud * psuPer;
            var caseBud = bud * casePer;
            var coolBud = bud * coolPer;
            var accBud = bud * accPer;
            var differential = bud * 0.1;
            string cpuDis = "";

            cpuDis += "<table class=text-center>";
            cpuDis += "<thead>";
            cpuDis += "<tr>";
            cpuDis += "<th class=product-thumbnail>product</th>";
            cpuDis += "<th class=product-price>price</th>";
            cpuDis += "<th class=product-price>select</th>";

            cpuDis += "</tr>";
            cpuDis += "</thead>";
            cpuDis += "<tbody>";

            var cpu1 = (from Product b in db.Products
                       where b.Product_IsActive.Equals(true)
                       where b.Product_Type.Equals("CPU")
                       where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(cpuBud - differential/2))
                       select b).FirstOrDefault();

            if (cpu1 != null)
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-img\">";
                cpuDis += "<img src=" + cpu1.Product_Img + " alt=>";
                cpuDis += "</div>";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu1.Product_Id + ">Below Budget: " + cpu1.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpuDis += "<p>Brand: " + cpu1.Product_Brand + "</p>";
                cpuDis += "</div>";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\">" + cpu1.Product_Price + "</td>";
                cpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"cpur\" id=\"cpu1r1\"/></td>";
                cpuDis += "</tr>";
            }
            else
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\"></td>";
                cpuDis += "</tr>";
            }


            var cpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential/2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential/2))
                        select b).FirstOrDefault();
            if (cpu2 != null)
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-img\">";
                cpuDis += "<img src=" + cpu2.Product_Img + " alt=>";
                cpuDis += "</div>";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu2.Product_Id + ">On Budget: " + cpu2.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpuDis += "<p>Brand: " + cpu2.Product_Brand + "</p>";
                cpuDis += "</div>";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\">" + cpu2.Product_Price + "</td>";
                cpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"cpur\" id=\"cpu1r2\"/></td>";
                cpuDis += "</tr>";
            }
            else
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\"></td>";
                cpuDis += "</tr>";
            }

            var cpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud + differential/2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential))
                        select b).FirstOrDefault();

            if (cpu3 != null)
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-img\">";
                cpuDis += "<img src=" + cpu3.Product_Img + " alt=>";
                cpuDis += "</div>";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu3.Product_Id + ">Above Budget: " + cpu3.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpuDis += "<p>Brand: " + cpu3.Product_Brand + "</p>";
                cpuDis += "</div>";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\">" + cpu3.Product_Price + "</td>";
                cpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"cpur\" id=\"cpu1r3\"/></td>";
                cpuDis += "</tr>";
            }
            else
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\"></td>";
                cpuDis += "</tr>";
            }


            cpuDis += "</tbody>";
            cpuDis += "</table>";

            cpuDiv.InnerHtml = cpuDis;


            string moboDis = "";

            moboDis += "<table class=text-center>";
            moboDis += "<thead>";
            moboDis += "<tr>";
            moboDis += "<th class=product-thumbnail>product</th>";
            moboDis += "<th class=product-price>price</th>";
            moboDis += "<th class=product-price>select</th>";
            moboDis += "</tr>";
            moboDis += "</thead>";
            moboDis += "<tbody>";

            var mobo1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Motherboard")
                        where b.Product_Price >= (Convert.ToDecimal(moboBud - differential)) && b.Product_Price <= (Convert.ToDecimal(moboBud - differential / 2))
                        select b).FirstOrDefault();

            if (mobo1 != null)
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-img\">";
                moboDis += "<img src=" + mobo1.Product_Img + " alt=>";
                moboDis += "</div>";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo1.Product_Id + ">Below Budget: " + mobo1.Product_Name + "</a>";
                moboDis += "</h6>";
                moboDis += "<p>Brand: " + mobo1.Product_Brand + "</p>";
                moboDis += "</div>";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\">" + mobo1.Product_Price + "</td>";
                moboDis += "<td class=\"product-price\"><input type=\"radio\" name=\"mobor\" id=\"mobo1r\" runat=\"server\"/></td>";
                moboDis += "</tr>";
            }
            else
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\"></td>";
                moboDis += "</tr>";
            }


            var mobo2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Motherboard")
                        where b.Product_Price >= (Convert.ToDecimal(moboBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential / 2))
                        select b).FirstOrDefault();

            if (mobo2 != null)
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-img\">";
                moboDis += "<img src=" + mobo2.Product_Img + " alt=>";
                moboDis += "</div>";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo2.Product_Id + ">On Budget: " + mobo2.Product_Name + "</a>";
                moboDis += "</h6>";
                moboDis += "<p>Brand: " + mobo2.Product_Brand + "</p>";
                moboDis += "</div>";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\">" + mobo2.Product_Price + "</td>";
                moboDis += "<td class=\"product-price\"><input type=\"radio\" name=\"mobor\" id=\"mobo2r\" runat=\"server\"/></td>";
                moboDis += "</tr>";
            }
            else
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\"></td>";
                moboDis += "</tr>";
            }

            var mobo3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Motherboard")
                        where b.Product_Price >= (Convert.ToDecimal(moboBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential))
                        select b).FirstOrDefault();

            if (mobo3 != null)
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-img\">";
                moboDis += "<img src=" + mobo3.Product_Img + " alt=>";
                moboDis += "</div>";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo3.Product_Id + ">Above Budget: " + mobo3.Product_Name + "</a>";
                moboDis += "</h6>";
                moboDis += "<p>Brand: " + mobo3.Product_Brand + "</p>";
                moboDis += "</div>";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\">" + mobo3.Product_Price + "</td>";
                moboDis += "<td class=\"product-price\"><input type=\"radio\" name=\"mobor\" id=\"mobo3r\" runat=\"server\"/></td>";
                moboDis += "</tr>";
            }
            else
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\"></td>";
                moboDis += "</tr>";
            }


            moboDis += "</tbody>";
            moboDis += "</table>";

            moboDiv.InnerHtml = moboDis;

            string coolDis = "";

            coolDis += "<table class=text-center>";
            coolDis += "<thead>";
            coolDis += "<tr>";
            coolDis += "<th class=product-thumbnail>product</th>";
            coolDis += "<th class=product-price>price</th>";
            coolDis += "<th class=product-price>select</th>";
            coolDis += "</tr>";
            coolDis += "</thead>";
            coolDis += "<tbody>";

            var cool1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(coolBud - differential / 4))
                         select b).FirstOrDefault();

            if (cool1 != null)
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-img\">";
                coolDis += "<img src=" + cool1.Product_Img + " alt=>";
                coolDis += "</div>";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool1.Product_Id + ">Below Budget: " + cool1.Product_Name + "</a>";
                coolDis += "</h6>";
                coolDis += "<p>Brand: " + cool1.Product_Brand + "</p>";
                coolDis += "</div>";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\">" + cool1.Product_Price + "</td>";
                coolDis += "<td class=\"product-price\"><input type=\"radio\" name=\"coolr\" id=\"cool1r\" runat=\"server\"/></td>";
                coolDis += "</tr>";
            }
            else
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\"></td>";
                coolDis += "</tr>";
            }


            var cool2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential / 4))
                         select b).FirstOrDefault();

            if (cool2 != null)
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-img\">";
                coolDis += "<img src=" + cool2.Product_Img + " alt=>";
                coolDis += "</div>";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool2.Product_Id + ">On Budget: " + cool2.Product_Name + "</a>";
                coolDis += "</h6>";
                coolDis += "<p>Brand: " + cool2.Product_Brand + "</p>";
                coolDis += "</div>";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\">" + cool2.Product_Price + "</td>";
                coolDis += "<td class=\"product-price\"><input type=\"radio\" name=\"coolr\" id=\"cool2r\" runat=\"server\"/></td>";
                coolDis += "</tr>";
            }
            else
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\"></td>";
                coolDis += "</tr>";
            }

            var cool3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud + differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential))
                         select b).FirstOrDefault();

            if (cool3 != null)
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-img\">";
                coolDis += "<img src=" + cool3.Product_Img + " alt=>";
                coolDis += "</div>";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool3.Product_Id + ">Above Budget: " + cool3.Product_Name + "</a>";
                coolDis += "</h6>";
                coolDis += "<p>Brand: " + cool3.Product_Brand + "</p>";
                coolDis += "</div>";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\">" + cool3.Product_Price + "</td>";
                coolDis += "<td class=\"product-price\"><input type=\"radio\" name=\"coolr\" id=\"cool3r\" runat=\"server\"/></td>";
                coolDis += "</tr>";
            }
            else
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\"></td>";
                coolDis += "</tr>";
            }


            coolDis += "</tbody>";
            coolDis += "</table>";

            coolDiv.InnerHtml = coolDis;

            string gpuDis = "";


            gpuDis += "<table class=text-center>";
            gpuDis += "<thead>";
            gpuDis += "<tr>";
            gpuDis += "<th class=product-thumbnail>product</th>";
            gpuDis += "<th class=product-price>price</th>";
            gpuDis += "<th class=product-price>select</th>";
            gpuDis += "</tr>";
            gpuDis += "</thead>";
            gpuDis += "<tbody>";

            var gpu1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("GPU")
                         where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(gpuBud - differential / 2))
                         select b).FirstOrDefault();

            if (gpu1 != null)
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-img\">";
                gpuDis += "<img src=" + gpu1.Product_Img + " alt=>";
                gpuDis += "</div>";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu1.Product_Id + ">Below Budget: " + gpu1.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpuDis += "<p>Brand: " + gpu1.Product_Brand + "</p>";
                gpuDis += "</div>";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\">" + gpu1.Product_Price + "</td>";
                gpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"gpur\" id=\"gpu1r\" runat=\"server\"/></td>";
                gpuDis += "</tr>";
            }
            else
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\"></td>";
                gpuDis += "</tr>";
            }


            var gpu2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("GPU")
                         where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential / 2))
                         select b).FirstOrDefault();

            if (gpu2 != null)
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-img\">";
                gpuDis += "<img src=" + gpu2.Product_Img + " alt=>";
                gpuDis += "</div>";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu2.Product_Id + ">On Budget: " + gpu2.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpuDis += "<p>Brand: " + gpu2.Product_Brand + "</p>";
                gpuDis += "</div>";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\">" + gpu2.Product_Price + "</td>";
                gpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"gpur\" id=\"gpu2r\" runat=\"server\"/></td>";
                gpuDis += "</tr>";
            }
            else
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\"></td>";
                gpuDis += "</tr>";
            }

            var gpu3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("GPU")
                         where b.Product_Price >= (Convert.ToDecimal(gpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential))
                         select b).FirstOrDefault();

            if (gpu3 != null)
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-img\">";
                gpuDis += "<img src=" + gpu3.Product_Img + " alt=>";
                gpuDis += "</div>";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu3.Product_Id + ">Above Budget: " + gpu3.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpuDis += "<p>Brand: " + gpu3.Product_Brand + "</p>";
                gpuDis += "</div>";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\">" + gpu3.Product_Price + "</td>";
                gpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"gpur\" id=\"gpu3r\" runat=\"server\"/></td>";
                gpuDis += "</tr>";
            }
            else
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\"></td>";
                gpuDis += "</tr>";
            }


            gpuDis += "</tbody>";
            gpuDis += "</table>";

            gpuDiv.InnerHtml = gpuDis;

            string memDis = "";

            memDis += "<table class=text-center>";
            memDis += "<thead>";
            memDis += "<tr>";
            memDis += "<th class=product-thumbnail>product</th>";
            memDis += "<th class=product-price>price</th>";
            memDis += "<th class=product-price>select</th>";
            memDis += "</tr>";
            memDis += "</thead>";
            memDis += "<tbody>";

            var mem1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential)) && b.Product_Price <= (Convert.ToDecimal(ramBud - differential / 2))
                        select b).FirstOrDefault();

            if (mem1 != null)
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-img\">";
                memDis += "<img src=" + mem1.Product_Img + " alt=>";
                memDis += "</div>";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem1.Product_Id + ">Below Budget: " + mem1.Product_Name + "</a>";
                memDis += "</h6>";
                memDis += "<p>Brand: " + mem1.Product_Brand + "</p>";
                memDis += "</div>";
                memDis += "</td>";
                memDis += "<td class=\"product-price\">" + mem1.Product_Price + "</td>";
                memDis += "<td class=\"product-price\"><input type=\"radio\" name=\"memr\" id=\"mem1r\" runat=\"server\"/></td>";
                memDis += "</tr>";
            }
            else
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</td>";
                memDis += "<td class=\"product-price\"></td>";
                memDis += "</tr>";
            }


            var mem2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential / 2))
                        select b).FirstOrDefault();

            if (mem2 != null)
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-img\">";
                memDis += "<img src=" + mem2.Product_Img + " alt=>";
                memDis += "</div>";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem2.Product_Id + ">On Budget: " + mem2.Product_Name + "</a>";
                memDis += "</h6>";
                memDis += "<p>Brand: " + mem2.Product_Brand + "</p>";
                memDis += "</div>";
                memDis += "</td>";
                memDis += "<td class=\"product-price\">" + mem2.Product_Price + "</td>";
                memDis += "<td class=\"product-price\"><input type=\"radio\" name=\"memr\" id=\"mem2r\" runat=\"server\"/></td>";
                memDis += "</tr>";
            }
            else
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</td>";
                memDis += "<td class=\"product-price\"></td>";
                memDis += "</tr>";
            }

            var mem3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential*2))
                        select b).FirstOrDefault();

            if (mem3 != null)
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-img\">";
                memDis += "<img src=" + mem3.Product_Img + " alt=>";
                memDis += "</div>";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem3.Product_Id + ">Above Budget: " + mem3.Product_Name + "</a>";
                memDis += "</h6>";
                memDis += "<p>Brand: " + mem3.Product_Brand + "</p>";
                memDis += "</div>";
                memDis += "</td>";
                memDis += "<td class=\"product-price\">" + mem3.Product_Price + "</td>";
                memDis += "<td class=\"product-price\"><input type=\"radio\" name=\"memr\" id=\"mem3r\" runat=\"server\"/></td>";
                memDis += "</tr>";
            }
            else
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</td>";
                memDis += "<td class=\"product-price\"></td>";
                memDis += "</tr>";
            }


            memDis += "</tbody>";
            memDis += "</table>";

            memDiv.InnerHtml = memDis;

            string hardDis = "";

            hardDis += "<table class=text-center>";
            hardDis += "<thead>";
            hardDis += "<tr>";
            hardDis += "<th class=product-thumbnail>product</th>";
            hardDis += "<th class=product-price>price</th>";
            hardDis += "<th class=product-price>select</th>";
            hardDis += "</tr>";
            hardDis += "</thead>";
            hardDis += "<tbody>";

            var hard1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Hard Drive")
                        where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(hardBud - differential / 4))
                        select b).FirstOrDefault();

            if (hard1 != null)
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-img\">";
                hardDis += "<img src=" + hard1.Product_Img + " alt=>";
                hardDis += "</div>";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard1.Product_Id + ">Below Budget: " + hard1.Product_Name + "</a>";
                hardDis += "</h6>";
                hardDis += "<p>Brand: " + hard1.Product_Brand + "</p>";
                hardDis += "</div>";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\">" + hard1.Product_Price + "</td>";
                hardDis += "<td class=\"product-price\"><input type=\"radio\" name=\"hardr\" id=\"hard1r\" runat=\"server\"/></td>";
                hardDis += "</tr>";
            }
            else
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\"></td>";
                hardDis += "</tr>";
            }


            var hard2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Hard Drive")
                        where b.Product_Price >= (Convert.ToDecimal(hardBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential / 2))
                        select b).FirstOrDefault();

            if (hard2 != null)
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-img\">";
                hardDis += "<img src=" + hard2.Product_Img + " alt=>";
                hardDis += "</div>";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard2.Product_Id + ">On Budget: " + hard2.Product_Name + "</a>";
                hardDis += "</h6>";
                hardDis += "<p>Brand: " + hard2.Product_Brand + "</p>";
                hardDis += "</div>";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\">" + hard2.Product_Price + "</td>";
                hardDis += "<td class=\"product-price\"><input type=\"radio\" name=\"hardr\" id=\"hard2r\" runat=\"server\"/></td>";
                hardDis += "</tr>";
            }
            else
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\"></td>";
                hardDis += "</tr>";
            }

            var hard3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Hard Drive")
                        where b.Product_Price >= (Convert.ToDecimal(hardBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential))
                        select b).FirstOrDefault();

            if (hard3 != null)
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-img\">";
                hardDis += "<img src=" + hard3.Product_Img + " alt=>";
                hardDis += "</div>";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard3.Product_Id + ">Above Budget: " + hard3.Product_Name + "</a>";
                hardDis += "</h6>";
                hardDis += "<p>Brand: " + hard3.Product_Brand + "</p>";
                hardDis += "</div>";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\">" + hard3.Product_Price + "</td>";
                hardDis += "<td class=\"product-price\"><input type=\"radio\" name=\"hardr\" id=\"hard3r\" runat=\"server\"/></td>";
                hardDis += "</tr>";
            }
            else
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\"></td>";
                hardDis += "</tr>";
            }


            hardDis += "</tbody>";
            hardDis += "</table>";

            hardDiv.InnerHtml = hardDis;

            string psuDis = "";

            psuDis += "<table class=text-center>";
            psuDis += "<thead>";
            psuDis += "<tr>";
            psuDis += "<th class=product-thumbnail>product</th>";
            psuDis += "<th class=product-price>price</th>";
            psuDis += "<th class=product-price>select</th>";
            psuDis += "</tr>";
            psuDis += "</thead>";
            psuDis += "<tbody>";

            var psu1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("PSU")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(1800))
                         select b).FirstOrDefault();

            if (psu1 != null)
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-img\">";
                psuDis += "<img src=" + psu1.Product_Img + " alt=>";
                psuDis += "</div>";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu1.Product_Id + ">Below Budget: " + psu1.Product_Name + "</a>";
                psuDis += "</h6>";
                psuDis += "<p>Brand: " + psu1.Product_Brand + "</p>";
                psuDis += "</div>";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\">" + psu1.Product_Price + "</td>";
                psuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"psur\" id=\"psu1r\" runat=\"server\"/></td>";
                psuDis += "</tr>";
            }
            else
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\"></td>";
                psuDis += "</tr>";
            }


            var psu2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("PSU")
                         where b.Product_Price >= (Convert.ToDecimal(1800)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential / 2))
                         select b).FirstOrDefault();

            if (psu2 != null)
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-img\">";
                psuDis += "<img src=" + psu2.Product_Img + " alt=>";
                psuDis += "</div>";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu2.Product_Id + ">On Budget: " + psu2.Product_Name + "</a>";
                psuDis += "</h6>";
                psuDis += "<p>Brand: " + psu2.Product_Brand + "</p>";
                psuDis += "</div>";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\">" + psu2.Product_Price + "</td>";
                psuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"psur\" id=\"psu2r\" runat=\"server\"/></td>";
                psuDis += "</tr>";
            }
            else
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\"></td>";
                psuDis += "</tr>";
            }

            var psu3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("PSU")
                         where b.Product_Price >= (Convert.ToDecimal(psuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential))
                         select b).FirstOrDefault();

            if (psu3 != null)
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-img\">";
                psuDis += "<img src=" + psu3.Product_Img + " alt=>";
                psuDis += "</div>";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu3.Product_Id + ">Above Budget: " + psu3.Product_Name + "</a>";
                psuDis += "</h6>";
                psuDis += "<p>Brand: " + psu3.Product_Brand + "</p>";
                psuDis += "</div>";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\">" + psu3.Product_Price + "</td>";
                psuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"psur\" id=\"psu3r\" runat=\"server\"/></td>";
                psuDis += "</tr>";
            }
            else
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\"></td>";
                psuDis += "</tr>";
            }


            psuDis += "</tbody>";
            psuDis += "</table>";

            psuDiv.InnerHtml = psuDis;

            string caseDis = "";

            caseDis += "<table class=text-center>";
            caseDis += "<thead>";
            caseDis += "<tr>";
            caseDis += "<th class=product-thumbnail>product</th>";
            caseDis += "<th class=product-price>price</th>";
            caseDis += "<th class=product-price>select</th>";
            caseDis += "</tr>";
            caseDis += "</thead>";
            caseDis += "<tbody>";

            var case1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Gaming Case")
                        where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(caseBud - differential / 4))
                        select b).FirstOrDefault();

            if (case1 != null)
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-img\">";
                caseDis += "<img src=" + case1.Product_Img + " alt=>";
                caseDis += "</div>";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case1.Product_Id + ">Below Budget: " + case1.Product_Name + "</a>";
                caseDis += "</h6>";
                caseDis += "<p>Brand: " + case1.Product_Brand + "</p>";
                caseDis += "</div>";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\">" + case1.Product_Price + "</td>";
                caseDis += "<td class=\"product-price\"><input type=\"radio\" name=\"caser\" id=\"case1r\" runat=\"server\"/></td>";
                caseDis += "</tr>";
            }
            else
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\"></td>";
                caseDis += "</tr>";
            }


            var case2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Gaming Case")
                        where b.Product_Price >= (Convert.ToDecimal(caseBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential / 2))
                        select b).FirstOrDefault();

            if (case2 != null)
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-img\">";
                caseDis += "<img src=" + case2.Product_Img + " alt=>";
                caseDis += "</div>";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case2.Product_Id + ">On Budget: " + case2.Product_Name + "</a>";
                caseDis += "</h6>";
                caseDis += "<p>Brand: " + case2.Product_Brand + "</p>";
                caseDis += "</div>";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\">" + case2.Product_Price + "</td>";
                caseDis += "<td class=\"product-price\"><input type=\"radio\" name=\"caser\" id=\"case2r\" runat=\"server\"/></td>";
                caseDis += "</tr>";
            }
            else
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\"></td>";
                caseDis += "</tr>";
            }

            var case3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Gaming Case")
                        where b.Product_Price >= (Convert.ToDecimal(caseBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential))
                        select b).FirstOrDefault();

            if (case3 != null)
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-img\">";
                caseDis += "<img src=" + case3.Product_Img + " alt=>";
                caseDis += "</div>";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case3.Product_Id + ">Above Budget: " + case3.Product_Name + "</a>";
                caseDis += "</h6>";
                caseDis += "<p>Brand: " + case3.Product_Brand + "</p>";
                caseDis += "</div>";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\">" + case3.Product_Price + "</td>";
                caseDis += "<td class=\"product-price\"><input type=\"radio\" name=\"caser\" id=\"case3r\" runat=\"server\"/></td>";
                caseDis += "</tr>";
            }
            else
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\"></td>";
                caseDis += "</tr>";
            }


            caseDis += "</tbody>";
            caseDis += "</table>";

            caseDiv.InnerHtml = caseDis;
        }

        protected void gaming1_Click(object sender, EventArgs e)
        {
            cpuPer = 0.2;
            gpuPer = 0.3;
            chosen = true;
            var db = new DataLinqDataContext();

            dynamic products = from a in db.Products
                               select a;

            int bud = int.Parse(budget.Value);
            var cpuBud = bud * cpuPer;
            var gpuBud = bud * gpuPer;
            var moboBud = bud * moboPer;
            var ramBud = bud * ramPer;
            var hardBud = bud * hardPer;
            var psuBud = bud * psuPer;
            var caseBud = bud * casePer;
            var coolBud = bud * coolPer;
            var accBud = bud * accPer;
            var differential = bud * 0.1;

            string cpuDis = "";

            cpuDis += "<table class=text-center>";
            cpuDis += "<thead>";
            cpuDis += "<tr>";
            cpuDis += "<th class=product-thumbnail>product</th>";
            cpuDis += "<th class=product-price>price</th>";
            cpuDis += "<th class=product-price>select</th>";

            cpuDis += "</tr>";
            cpuDis += "</thead>";
            cpuDis += "<tbody>";

            var cpu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(cpuBud - differential / 2))
                        select b).FirstOrDefault();

            if (cpu1 != null)
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-img\">";
                cpuDis += "<img src=" + cpu1.Product_Img + " alt=>";
                cpuDis += "</div>";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu1.Product_Id + ">Below Budget: " + cpu1.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpuDis += "<p>Brand: " + cpu1.Product_Brand + "</p>";
                cpuDis += "</div>";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\">" + cpu1.Product_Price + "</td>";
                cpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"cpur\" id=\"cpu1r1\" runat=\"server\"/></td>";
                cpuDis += "</tr>";
            }
            else
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\"></td>";
                cpuDis += "</tr>";
            }


            var cpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential / 2))
                        select b).FirstOrDefault();
            if (cpu2 != null)
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-img\">";
                cpuDis += "<img src=" + cpu2.Product_Img + " alt=>";
                cpuDis += "</div>";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu2.Product_Id + ">On Budget: " + cpu2.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpuDis += "<p>Brand: " + cpu2.Product_Brand + "</p>";
                cpuDis += "</div>";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\">" + cpu2.Product_Price + "</td>";
                cpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"cpur\" id=\"cpu1r2\" runat=\"server\"/></td>";
                cpuDis += "</tr>";
            }
            else
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\"></td>";
                cpuDis += "</tr>";
            }

            var cpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential))
                        select b).FirstOrDefault();

            if (cpu3 != null)
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-img\">";
                cpuDis += "<img src=" + cpu3.Product_Img + " alt=>";
                cpuDis += "</div>";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu3.Product_Id + ">Above Budget: " + cpu3.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpuDis += "<p>Brand: " + cpu3.Product_Brand + "</p>";
                cpuDis += "</div>";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\">" + cpu3.Product_Price + "</td>";
                cpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"cpur\" id=\"cpu1r3\" runat=\"server\"/></td>";
                cpuDis += "</tr>";
            }
            else
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\"></td>";
                cpuDis += "</tr>";
            }


            cpuDis += "</tbody>";
            cpuDis += "</table>";

            cpuDiv.InnerHtml = cpuDis;


            string moboDis = "";

            moboDis += "<table class=text-center>";
            moboDis += "<thead>";
            moboDis += "<tr>";
            moboDis += "<th class=product-thumbnail>product</th>";
            moboDis += "<th class=product-price>price</th>";
            moboDis += "<th class=product-price>select</th>";
            moboDis += "</tr>";
            moboDis += "</thead>";
            moboDis += "<tbody>";

            var mobo1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud - differential)) && b.Product_Price <= (Convert.ToDecimal(moboBud - differential / 2))
                         select b).FirstOrDefault();

            if (mobo1 != null)
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-img\">";
                moboDis += "<img src=" + mobo1.Product_Img + " alt=>";
                moboDis += "</div>";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo1.Product_Id + ">Below Budget: " + mobo1.Product_Name + "</a>";
                moboDis += "</h6>";
                moboDis += "<p>Brand: " + mobo1.Product_Brand + "</p>";
                moboDis += "</div>";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\">" + mobo1.Product_Price + "</td>";
                moboDis += "<td class=\"product-price\"><input type=\"radio\" name=\"mobor\" id=\"mobo1r\" runat=\"server\"/></td>";
                moboDis += "</tr>";
            }
            else
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\"></td>";
                moboDis += "</tr>";
            }


            var mobo2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential / 2))
                         select b).FirstOrDefault();

            if (mobo2 != null)
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-img\">";
                moboDis += "<img src=" + mobo2.Product_Img + " alt=>";
                moboDis += "</div>";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo2.Product_Id + ">On Budget: " + mobo2.Product_Name + "</a>";
                moboDis += "</h6>";
                moboDis += "<p>Brand: " + mobo2.Product_Brand + "</p>";
                moboDis += "</div>";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\">" + mobo2.Product_Price + "</td>";
                moboDis += "<td class=\"product-price\"><input type=\"radio\" name=\"mobor\" id=\"mobo2r\" runat=\"server\"/></td>";
                moboDis += "</tr>";
            }
            else
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\"></td>";
                moboDis += "</tr>";
            }

            var mobo3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential))
                         select b).FirstOrDefault();

            if (mobo3 != null)
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-img\">";
                moboDis += "<img src=" + mobo3.Product_Img + " alt=>";
                moboDis += "</div>";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo3.Product_Id + ">Above Budget: " + mobo3.Product_Name + "</a>";
                moboDis += "</h6>";
                moboDis += "<p>Brand: " + mobo3.Product_Brand + "</p>";
                moboDis += "</div>";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\">" + mobo3.Product_Price + "</td>";
                moboDis += "<td class=\"product-price\"><input type=\"radio\" name=\"mobor\" id=\"mobo3r\" runat=\"server\"/></td>";
                moboDis += "</tr>";
            }
            else
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\"></td>";
                moboDis += "</tr>";
            }


            moboDis += "</tbody>";
            moboDis += "</table>";

            moboDiv.InnerHtml = moboDis;

            string coolDis = "";

            coolDis += "<table class=text-center>";
            coolDis += "<thead>";
            coolDis += "<tr>";
            coolDis += "<th class=product-thumbnail>product</th>";
            coolDis += "<th class=product-price>price</th>";
            coolDis += "<th class=product-price>select</th>";
            coolDis += "</tr>";
            coolDis += "</thead>";
            coolDis += "<tbody>";

            var cool1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(coolBud - differential / 4))
                         select b).FirstOrDefault();

            if (cool1 != null)
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-img\">";
                coolDis += "<img src=" + cool1.Product_Img + " alt=>";
                coolDis += "</div>";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool1.Product_Id + ">Below Budget: " + cool1.Product_Name + "</a>";
                coolDis += "</h6>";
                coolDis += "<p>Brand: " + cool1.Product_Brand + "</p>";
                coolDis += "</div>";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\">" + cool1.Product_Price + "</td>";
                coolDis += "<td class=\"product-price\"><input type=\"radio\" name=\"coolr\" id=\"cool1r\" runat=\"server\"/></td>";
                coolDis += "</tr>";
            }
            else
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\"></td>";
                coolDis += "</tr>";
            }


            var cool2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential / 4))
                         select b).FirstOrDefault();

            if (cool2 != null)
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-img\">";
                coolDis += "<img src=" + cool2.Product_Img + " alt=>";
                coolDis += "</div>";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool2.Product_Id + ">On Budget: " + cool2.Product_Name + "</a>";
                coolDis += "</h6>";
                coolDis += "<p>Brand: " + cool2.Product_Brand + "</p>";
                coolDis += "</div>";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\">" + cool2.Product_Price + "</td>";
                coolDis += "<td class=\"product-price\"><input type=\"radio\" name=\"coolr\" id=\"cool2r\" runat=\"server\"/></td>";
                coolDis += "</tr>";
            }
            else
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\"></td>";
                coolDis += "</tr>";
            }

            var cool3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud + differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential))
                         select b).FirstOrDefault();

            if (cool3 != null)
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-img\">";
                coolDis += "<img src=" + cool3.Product_Img + " alt=>";
                coolDis += "</div>";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool3.Product_Id + ">Above Budget: " + cool3.Product_Name + "</a>";
                coolDis += "</h6>";
                coolDis += "<p>Brand: " + cool3.Product_Brand + "</p>";
                coolDis += "</div>";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\">" + cool3.Product_Price + "</td>";
                coolDis += "<td class=\"product-price\"><input type=\"radio\" name=\"coolr\" id=\"cool3r\" runat=\"server\"/></td>";
                coolDis += "</tr>";
            }
            else
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\"></td>";
                coolDis += "</tr>";
            }


            coolDis += "</tbody>";
            coolDis += "</table>";

            coolDiv.InnerHtml = coolDis;

            string gpuDis = "";


            gpuDis += "<table class=text-center>";
            gpuDis += "<thead>";
            gpuDis += "<tr>";
            gpuDis += "<th class=product-thumbnail>product</th>";
            gpuDis += "<th class=product-price>price</th>";
            gpuDis += "<th class=product-price>select</th>";
            gpuDis += "</tr>";
            gpuDis += "</thead>";
            gpuDis += "<tbody>";

            var gpu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(gpuBud - differential / 2))
                        select b).FirstOrDefault();

            if (gpu1 != null)
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-img\">";
                gpuDis += "<img src=" + gpu1.Product_Img + " alt=>";
                gpuDis += "</div>";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu1.Product_Id + ">Below Budget: " + gpu1.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpuDis += "<p>Brand: " + gpu1.Product_Brand + "</p>";
                gpuDis += "</div>";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\">" + gpu1.Product_Price + "</td>";
                gpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"gpur\" id=\"gpu1r\" runat=\"server\"/></td>";
                gpuDis += "</tr>";
            }
            else
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\"></td>";
                gpuDis += "</tr>";
            }


            var gpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential / 2))
                        select b).FirstOrDefault();

            if (gpu2 != null)
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-img\">";
                gpuDis += "<img src=" + gpu2.Product_Img + " alt=>";
                gpuDis += "</div>";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu2.Product_Id + ">On Budget: " + gpu2.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpuDis += "<p>Brand: " + gpu2.Product_Brand + "</p>";
                gpuDis += "</div>";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\">" + gpu2.Product_Price + "</td>";
                gpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"gpur\" id=\"gpu2r\" runat=\"server\"/></td>";
                gpuDis += "</tr>";
            }
            else
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\"></td>";
                gpuDis += "</tr>";
            }

            var gpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential))
                        select b).FirstOrDefault();

            if (gpu3 != null)
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-img\">";
                gpuDis += "<img src=" + gpu3.Product_Img + " alt=>";
                gpuDis += "</div>";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu3.Product_Id + ">Above Budget: " + gpu3.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpuDis += "<p>Brand: " + gpu3.Product_Brand + "</p>";
                gpuDis += "</div>";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\">" + gpu3.Product_Price + "</td>";
                gpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"gpur\" id=\"gpu3r\" runat=\"server\"/></td>";
                gpuDis += "</tr>";
            }
            else
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\"></td>";
                gpuDis += "</tr>";
            }


            gpuDis += "</tbody>";
            gpuDis += "</table>";

            gpuDiv.InnerHtml = gpuDis;

            string memDis = "";

            memDis += "<table class=text-center>";
            memDis += "<thead>";
            memDis += "<tr>";
            memDis += "<th class=product-thumbnail>product</th>";
            memDis += "<th class=product-price>price</th>";
            memDis += "<th class=product-price>select</th>";
            memDis += "</tr>";
            memDis += "</thead>";
            memDis += "<tbody>";

            var mem1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential)) && b.Product_Price <= (Convert.ToDecimal(ramBud - differential / 2))
                        select b).FirstOrDefault();

            if (mem1 != null)
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-img\">";
                memDis += "<img src=" + mem1.Product_Img + " alt=>";
                memDis += "</div>";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem1.Product_Id + ">Below Budget: " + mem1.Product_Name + "</a>";
                memDis += "</h6>";
                memDis += "<p>Brand: " + mem1.Product_Brand + "</p>";
                memDis += "</div>";
                memDis += "</td>";
                memDis += "<td class=\"product-price\">" + mem1.Product_Price + "</td>";
                memDis += "<td class=\"product-price\"><input type=\"radio\" name=\"memr\" id=\"mem1r\" runat=\"server\"/></td>";
                memDis += "</tr>";
            }
            else
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</td>";
                memDis += "<td class=\"product-price\"></td>";
                memDis += "</tr>";
            }


            var mem2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential / 2))
                        select b).FirstOrDefault();

            if (mem2 != null)
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-img\">";
                memDis += "<img src=" + mem2.Product_Img + " alt=>";
                memDis += "</div>";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem2.Product_Id + ">On Budget: " + mem2.Product_Name + "</a>";
                memDis += "</h6>";
                memDis += "<p>Brand: " + mem2.Product_Brand + "</p>";
                memDis += "</div>";
                memDis += "</td>";
                memDis += "<td class=\"product-price\">" + mem2.Product_Price + "</td>";
                memDis += "<td class=\"product-price\"><input type=\"radio\" name=\"memr\" id=\"mem2r\" runat=\"server\"/></td>";
                memDis += "</tr>";
            }
            else
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</td>";
                memDis += "<td class=\"product-price\"></td>";
                memDis += "</tr>";
            }

            var mem3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential * 2))
                        select b).FirstOrDefault();

            if (mem3 != null)
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-img\">";
                memDis += "<img src=" + mem3.Product_Img + " alt=>";
                memDis += "</div>";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem3.Product_Id + ">Above Budget: " + mem3.Product_Name + "</a>";
                memDis += "</h6>";
                memDis += "<p>Brand: " + mem3.Product_Brand + "</p>";
                memDis += "</div>";
                memDis += "</td>";
                memDis += "<td class=\"product-price\">" + mem3.Product_Price + "</td>";
                memDis += "<td class=\"product-price\"><input type=\"radio\" name=\"memr\" id=\"mem3r\" runat=\"server\"/></td>";
                memDis += "</tr>";
            }
            else
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</td>";
                memDis += "<td class=\"product-price\"></td>";
                memDis += "</tr>";
            }


            memDis += "</tbody>";
            memDis += "</table>";

            memDiv.InnerHtml = memDis;

            string hardDis = "";

            hardDis += "<table class=text-center>";
            hardDis += "<thead>";
            hardDis += "<tr>";
            hardDis += "<th class=product-thumbnail>product</th>";
            hardDis += "<th class=product-price>price</th>";
            hardDis += "<th class=product-price>select</th>";
            hardDis += "</tr>";
            hardDis += "</thead>";
            hardDis += "<tbody>";

            var hard1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(hardBud - differential / 4))
                         select b).FirstOrDefault();

            if (hard1 != null)
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-img\">";
                hardDis += "<img src=" + hard1.Product_Img + " alt=>";
                hardDis += "</div>";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard1.Product_Id + ">Below Budget: " + hard1.Product_Name + "</a>";
                hardDis += "</h6>";
                hardDis += "<p>Brand: " + hard1.Product_Brand + "</p>";
                hardDis += "</div>";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\">" + hard1.Product_Price + "</td>";
                hardDis += "<td class=\"product-price\"><input type=\"radio\" name=\"hardr\" id=\"hard1r\" runat=\"server\"/></td>";
                hardDis += "</tr>";
            }
            else
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\"></td>";
                hardDis += "</tr>";
            }


            var hard2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential / 2))
                         select b).FirstOrDefault();

            if (hard2 != null)
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-img\">";
                hardDis += "<img src=" + hard2.Product_Img + " alt=>";
                hardDis += "</div>";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard2.Product_Id + ">On Budget: " + hard2.Product_Name + "</a>";
                hardDis += "</h6>";
                hardDis += "<p>Brand: " + hard2.Product_Brand + "</p>";
                hardDis += "</div>";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\">" + hard2.Product_Price + "</td>";
                hardDis += "<td class=\"product-price\"><input type=\"radio\" name=\"hardr\" id=\"hard2r\" runat=\"server\"/></td>";
                hardDis += "</tr>";
            }
            else
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\"></td>";
                hardDis += "</tr>";
            }

            var hard3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential))
                         select b).FirstOrDefault();

            if (hard3 != null)
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-img\">";
                hardDis += "<img src=" + hard3.Product_Img + " alt=>";
                hardDis += "</div>";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard3.Product_Id + ">Above Budget: " + hard3.Product_Name + "</a>";
                hardDis += "</h6>";
                hardDis += "<p>Brand: " + hard3.Product_Brand + "</p>";
                hardDis += "</div>";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\">" + hard3.Product_Price + "</td>";
                hardDis += "<td class=\"product-price\"><input type=\"radio\" name=\"hardr\" id=\"hard3r\" runat=\"server\"/></td>";
                hardDis += "</tr>";
            }
            else
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\"></td>";
                hardDis += "</tr>";
            }


            hardDis += "</tbody>";
            hardDis += "</table>";

            hardDiv.InnerHtml = hardDis;

            string psuDis = "";

            psuDis += "<table class=text-center>";
            psuDis += "<thead>";
            psuDis += "<tr>";
            psuDis += "<th class=product-thumbnail>product</th>";
            psuDis += "<th class=product-price>price</th>";
            psuDis += "<th class=product-price>select</th>";
            psuDis += "</tr>";
            psuDis += "</thead>";
            psuDis += "<tbody>";

            var psu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(1800))
                        select b).FirstOrDefault();

            if (psu1 != null)
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-img\">";
                psuDis += "<img src=" + psu1.Product_Img + " alt=>";
                psuDis += "</div>";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu1.Product_Id + ">Below Budget: " + psu1.Product_Name + "</a>";
                psuDis += "</h6>";
                psuDis += "<p>Brand: " + psu1.Product_Brand + "</p>";
                psuDis += "</div>";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\">" + psu1.Product_Price + "</td>";
                psuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"psur\" id=\"psu1r\" runat=\"server\"/></td>";
                psuDis += "</tr>";
            }
            else
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\"></td>";
                psuDis += "</tr>";
            }


            var psu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(1800)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential / 2))
                        select b).FirstOrDefault();

            if (psu2 != null)
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-img\">";
                psuDis += "<img src=" + psu2.Product_Img + " alt=>";
                psuDis += "</div>";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu2.Product_Id + ">On Budget: " + psu2.Product_Name + "</a>";
                psuDis += "</h6>";
                psuDis += "<p>Brand: " + psu2.Product_Brand + "</p>";
                psuDis += "</div>";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\">" + psu2.Product_Price + "</td>";
                psuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"psur\" id=\"psu2r\" runat=\"server\"/></td>";
                psuDis += "</tr>";
            }
            else
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\"></td>";
                psuDis += "</tr>";
            }

            var psu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(psuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential))
                        select b).FirstOrDefault();

            if (psu3 != null)
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-img\">";
                psuDis += "<img src=" + psu3.Product_Img + " alt=>";
                psuDis += "</div>";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu3.Product_Id + ">Above Budget: " + psu3.Product_Name + "</a>";
                psuDis += "</h6>";
                psuDis += "<p>Brand: " + psu3.Product_Brand + "</p>";
                psuDis += "</div>";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\">" + psu3.Product_Price + "</td>";
                psuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"psur\" id=\"psu3r\" runat=\"server\"/></td>";
                psuDis += "</tr>";
            }
            else
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\"></td>";
                psuDis += "</tr>";
            }


            psuDis += "</tbody>";
            psuDis += "</table>";

            psuDiv.InnerHtml = psuDis;

            string caseDis = "";

            caseDis += "<table class=text-center>";
            caseDis += "<thead>";
            caseDis += "<tr>";
            caseDis += "<th class=product-thumbnail>product</th>";
            caseDis += "<th class=product-price>price</th>";
            caseDis += "<th class=product-price>select</th>";
            caseDis += "</tr>";
            caseDis += "</thead>";
            caseDis += "<tbody>";

            var case1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Gaming Case")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(caseBud - differential / 4))
                         select b).FirstOrDefault();

            if (case1 != null)
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-img\">";
                caseDis += "<img src=" + case1.Product_Img + " alt=>";
                caseDis += "</div>";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case1.Product_Id + ">Below Budget: " + case1.Product_Name + "</a>";
                caseDis += "</h6>";
                caseDis += "<p>Brand: " + case1.Product_Brand + "</p>";
                caseDis += "</div>";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\">" + case1.Product_Price + "</td>";
                caseDis += "<td class=\"product-price\"><input type=\"radio\" name=\"caser\" id=\"case1r\" runat=\"server\"/></td>";
                caseDis += "</tr>";
            }
            else
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\"></td>";
                caseDis += "</tr>";
            }


            var case2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Gaming Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential / 2))
                         select b).FirstOrDefault();

            if (case2 != null)
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-img\">";
                caseDis += "<img src=" + case2.Product_Img + " alt=>";
                caseDis += "</div>";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case2.Product_Id + ">On Budget: " + case2.Product_Name + "</a>";
                caseDis += "</h6>";
                caseDis += "<p>Brand: " + case2.Product_Brand + "</p>";
                caseDis += "</div>";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\">" + case2.Product_Price + "</td>";
                caseDis += "<td class=\"product-price\"><input type=\"radio\" name=\"caser\" id=\"case2r\" runat=\"server\"/></td>";
                caseDis += "</tr>";
            }
            else
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\"></td>";
                caseDis += "</tr>";
            }

            var case3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Gaming Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential))
                         select b).FirstOrDefault();

            if (case3 != null)
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-img\">";
                caseDis += "<img src=" + case3.Product_Img + " alt=>";
                caseDis += "</div>";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case3.Product_Id + ">Above Budget: " + case3.Product_Name + "</a>";
                caseDis += "</h6>";
                caseDis += "<p>Brand: " + case3.Product_Brand + "</p>";
                caseDis += "</div>";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\">" + case3.Product_Price + "</td>";
                caseDis += "<td class=\"product-price\"><input type=\"radio\" name=\"caser\" id=\"case3r\" runat=\"server\"/></td>";
                caseDis += "</tr>";
            }
            else
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\"></td>";
                caseDis += "</tr>";
            }


            caseDis += "</tbody>";
            caseDis += "</table>";

            caseDiv.InnerHtml = caseDis;
        }
    

        protected void general_Click(object sender, EventArgs e)
        {
            cpuPer = 0.25;
            gpuPer = 0.25;
            chosen = true;

            var db = new DataLinqDataContext();

            dynamic products = from a in db.Products
                               select a;

            int bud = int.Parse(budget.Value);
            var cpuBud = bud * cpuPer;
            var gpuBud = bud * gpuPer;
            var moboBud = bud * moboPer;
            var ramBud = bud * ramPer;
            var hardBud = bud * hardPer;
            var psuBud = bud * psuPer;
            var caseBud = bud * casePer;
            var coolBud = bud * coolPer;
            var accBud = bud * accPer;
            var differential = bud * 0.1;

            string cpuDis = "";

            cpuDis += "<table class=text-center>";
            cpuDis += "<thead>";
            cpuDis += "<tr>";
            cpuDis += "<th class=product-thumbnail>product</th>";
            cpuDis += "<th class=product-price>price</th>";
            cpuDis += "<th class=product-price>select</th>";

            cpuDis += "</tr>";
            cpuDis += "</thead>";
            cpuDis += "<tbody>";

            var cpu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(cpuBud - differential / 2))
                        select b).FirstOrDefault();

            if (cpu1 != null)
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-img\">";
                cpuDis += "<img src=" + cpu1.Product_Img + " alt=>";
                cpuDis += "</div>";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu1.Product_Id + ">Below Budget: " + cpu1.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpuDis += "<p>Brand: " + cpu1.Product_Brand + "</p>";
                cpuDis += "</div>";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\">" + cpu1.Product_Price + "</td>";
                cpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"cpur\" id=\"cpu1r1\" runat=\"server\"/></td>";
                cpuDis += "</tr>";
            }
            else
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\"></td>";
                cpuDis += "</tr>";
            }


            var cpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential / 2))
                        select b).FirstOrDefault();
            if (cpu2 != null)
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-img\">";
                cpuDis += "<img src=" + cpu2.Product_Img + " alt=>";
                cpuDis += "</div>";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu2.Product_Id + ">On Budget: " + cpu2.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpuDis += "<p>Brand: " + cpu2.Product_Brand + "</p>";
                cpuDis += "</div>";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\">" + cpu2.Product_Price + "</td>";
                cpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"cpur\" id=\"cpu1r2\" runat=\"server\"/></td>";
                cpuDis += "</tr>";
            }
            else
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\"></td>";
                cpuDis += "</tr>";
            }

            var cpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential))
                        select b).FirstOrDefault();

            if (cpu3 != null)
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-img\">";
                cpuDis += "<img src=" + cpu3.Product_Img + " alt=>";
                cpuDis += "</div>";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu3.Product_Id + ">Above Budget: " + cpu3.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpuDis += "<p>Brand: " + cpu3.Product_Brand + "</p>";
                cpuDis += "</div>";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\">" + cpu3.Product_Price + "</td>";
                cpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"cpur\" id=\"cpu1r3\" runat=\"server\"/></td>";
                cpuDis += "</tr>";
            }
            else
            {
                cpuDis += "<tr>";
                cpuDis += "<td class=\"product-thumbnail\">";
                cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</td>";
                cpuDis += "<td class=\"product-price\"></td>";
                cpuDis += "</tr>";
            }


            cpuDis += "</tbody>";
            cpuDis += "</table>";

            cpuDiv.InnerHtml = cpuDis;


            string moboDis = "";

            moboDis += "<table class=text-center>";
            moboDis += "<thead>";
            moboDis += "<tr>";
            moboDis += "<th class=product-thumbnail>product</th>";
            moboDis += "<th class=product-price>price</th>";
            moboDis += "<th class=product-price>select</th>";
            moboDis += "</tr>";
            moboDis += "</thead>";
            moboDis += "<tbody>";

            var mobo1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud - differential)) && b.Product_Price <= (Convert.ToDecimal(moboBud - differential / 2))
                         select b).FirstOrDefault();

            if (mobo1 != null)
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-img\">";
                moboDis += "<img src=" + mobo1.Product_Img + " alt=>";
                moboDis += "</div>";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo1.Product_Id + ">Below Budget: " + mobo1.Product_Name + "</a>";
                moboDis += "</h6>";
                moboDis += "<p>Brand: " + mobo1.Product_Brand + "</p>";
                moboDis += "</div>";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\">" + mobo1.Product_Price + "</td>";
                moboDis += "<td class=\"product-price\"><input type=\"radio\" name=\"mobor\" id=\"mobo1r\" runat=\"server\"/></td>";
                moboDis += "</tr>";
            }
            else
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\"></td>";
                moboDis += "</tr>";
            }


            var mobo2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential / 2))
                         select b).FirstOrDefault();

            if (mobo2 != null)
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-img\">";
                moboDis += "<img src=" + mobo2.Product_Img + " alt=>";
                moboDis += "</div>";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo2.Product_Id + ">On Budget: " + mobo2.Product_Name + "</a>";
                moboDis += "</h6>";
                moboDis += "<p>Brand: " + mobo2.Product_Brand + "</p>";
                moboDis += "</div>";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\">" + mobo2.Product_Price + "</td>";
                moboDis += "<td class=\"product-price\"><input type=\"radio\" name=\"mobor\" id=\"mobo2r\" runat=\"server\"/></td>";
                moboDis += "</tr>";
            }
            else
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\"></td>";
                moboDis += "</tr>";
            }

            var mobo3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential))
                         select b).FirstOrDefault();

            if (mobo3 != null)
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-img\">";
                moboDis += "<img src=" + mobo3.Product_Img + " alt=>";
                moboDis += "</div>";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo3.Product_Id + ">Above Budget: " + mobo3.Product_Name + "</a>";
                moboDis += "</h6>";
                moboDis += "<p>Brand: " + mobo3.Product_Brand + "</p>";
                moboDis += "</div>";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\">" + mobo3.Product_Price + "</td>";
                moboDis += "<td class=\"product-price\"><input type=\"radio\" name=\"mobor\" id=\"mobo3r\" runat=\"server\"/></td>";
                moboDis += "</tr>";
            }
            else
            {
                moboDis += "<tr>";
                moboDis += "<td class=\"product-thumbnail\">";
                moboDis += "<div class=\"pro-thumbnail-info text-left\">";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</td>";
                moboDis += "<td class=\"product-price\"></td>";
                moboDis += "</tr>";
            }


            moboDis += "</tbody>";
            moboDis += "</table>";

            moboDiv.InnerHtml = moboDis;

            string coolDis = "";

            coolDis += "<table class=text-center>";
            coolDis += "<thead>";
            coolDis += "<tr>";
            coolDis += "<th class=product-thumbnail>product</th>";
            coolDis += "<th class=product-price>price</th>";
            coolDis += "<th class=product-price>select</th>";
            coolDis += "</tr>";
            coolDis += "</thead>";
            coolDis += "<tbody>";

            var cool1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(coolBud - differential / 4))
                         select b).FirstOrDefault();

            if (cool1 != null)
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-img\">";
                coolDis += "<img src=" + cool1.Product_Img + " alt=>";
                coolDis += "</div>";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool1.Product_Id + ">Below Budget: " + cool1.Product_Name + "</a>";
                coolDis += "</h6>";
                coolDis += "<p>Brand: " + cool1.Product_Brand + "</p>";
                coolDis += "</div>";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\">" + cool1.Product_Price + "</td>";
                coolDis += "<td class=\"product-price\"><input type=\"radio\" name=\"coolr\" id=\"cool1r\" runat=\"server\"/></td>";
                coolDis += "</tr>";
            }
            else
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\"></td>";
                coolDis += "</tr>";
            }


            var cool2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential / 4))
                         select b).FirstOrDefault();

            if (cool2 != null)
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-img\">";
                coolDis += "<img src=" + cool2.Product_Img + " alt=>";
                coolDis += "</div>";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool2.Product_Id + ">On Budget: " + cool2.Product_Name + "</a>";
                coolDis += "</h6>";
                coolDis += "<p>Brand: " + cool2.Product_Brand + "</p>";
                coolDis += "</div>";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\">" + cool2.Product_Price + "</td>";
                coolDis += "<td class=\"product-price\"><input type=\"radio\" name=\"coolr\" id=\"cool2r\" runat=\"server\"/></td>";
                coolDis += "</tr>";
            }
            else
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\"></td>";
                coolDis += "</tr>";
            }

            var cool3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud + differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential))
                         select b).FirstOrDefault();

            if (cool3 != null)
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-img\">";
                coolDis += "<img src=" + cool3.Product_Img + " alt=>";
                coolDis += "</div>";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool3.Product_Id + ">Above Budget: " + cool3.Product_Name + "</a>";
                coolDis += "</h6>";
                coolDis += "<p>Brand: " + cool3.Product_Brand + "</p>";
                coolDis += "</div>";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\">" + cool3.Product_Price + "</td>";
                coolDis += "<td class=\"product-price\"><input type=\"radio\" name=\"coolr\" id=\"cool3r\" runat=\"server\"/></td>";
                coolDis += "</tr>";
            }
            else
            {
                coolDis += "<tr>";
                coolDis += "<td class=\"product-thumbnail\">";
                coolDis += "<div class=\"pro-thumbnail-info text-left\">";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</td>";
                coolDis += "<td class=\"product-price\"></td>";
                coolDis += "</tr>";
            }


            coolDis += "</tbody>";
            coolDis += "</table>";

            coolDiv.InnerHtml = coolDis;

            string gpuDis = "";


            gpuDis += "<table class=text-center>";
            gpuDis += "<thead>";
            gpuDis += "<tr>";
            gpuDis += "<th class=product-thumbnail>product</th>";
            gpuDis += "<th class=product-price>price</th>";
            gpuDis += "<th class=product-price>select</th>";
            gpuDis += "</tr>";
            gpuDis += "</thead>";
            gpuDis += "<tbody>";

            var gpu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(gpuBud - differential / 2))
                        select b).FirstOrDefault();

            if (gpu1 != null)
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-img\">";
                gpuDis += "<img src=" + gpu1.Product_Img + " alt=>";
                gpuDis += "</div>";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu1.Product_Id + ">Below Budget: " + gpu1.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpuDis += "<p>Brand: " + gpu1.Product_Brand + "</p>";
                gpuDis += "</div>";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\">" + gpu1.Product_Price + "</td>";
                gpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"gpur\" id=\"gpu1r\" runat=\"server\"/></td>";
                gpuDis += "</tr>";
            }
            else
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\"></td>";
                gpuDis += "</tr>";
            }


            var gpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential / 2))
                        select b).FirstOrDefault();

            if (gpu2 != null)
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-img\">";
                gpuDis += "<img src=" + gpu2.Product_Img + " alt=>";
                gpuDis += "</div>";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu2.Product_Id + ">On Budget: " + gpu2.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpuDis += "<p>Brand: " + gpu2.Product_Brand + "</p>";
                gpuDis += "</div>";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\">" + gpu2.Product_Price + "</td>";
                gpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"gpur\" id=\"gpu2r\" runat=\"server\"/></td>";
                gpuDis += "</tr>";
            }
            else
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\"></td>";
                gpuDis += "</tr>";
            }

            var gpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential))
                        select b).FirstOrDefault();

            if (gpu3 != null)
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-img\">";
                gpuDis += "<img src=" + gpu3.Product_Img + " alt=>";
                gpuDis += "</div>";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu3.Product_Id + ">Above Budget: " + gpu3.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpuDis += "<p>Brand: " + gpu3.Product_Brand + "</p>";
                gpuDis += "</div>";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\">" + gpu3.Product_Price + "</td>";
                gpuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"gpur\" id=\"gpu3r\" runat=\"server\"/></td>";
                gpuDis += "</tr>";
            }
            else
            {
                gpuDis += "<tr>";
                gpuDis += "<td class=\"product-thumbnail\">";
                gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</td>";
                gpuDis += "<td class=\"product-price\"></td>";
                gpuDis += "</tr>";
            }


            gpuDis += "</tbody>";
            gpuDis += "</table>";

            gpuDiv.InnerHtml = gpuDis;

            string memDis = "";

            memDis += "<table class=text-center>";
            memDis += "<thead>";
            memDis += "<tr>";
            memDis += "<th class=product-thumbnail>product</th>";
            memDis += "<th class=product-price>price</th>";
            memDis += "<th class=product-price>select</th>";
            memDis += "</tr>";
            memDis += "</thead>";
            memDis += "<tbody>";

            var mem1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential)) && b.Product_Price <= (Convert.ToDecimal(ramBud - differential / 2))
                        select b).FirstOrDefault();

            if (mem1 != null)
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-img\">";
                memDis += "<img src=" + mem1.Product_Img + " alt=>";
                memDis += "</div>";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem1.Product_Id + ">Below Budget: " + mem1.Product_Name + "</a>";
                memDis += "</h6>";
                memDis += "<p>Brand: " + mem1.Product_Brand + "</p>";
                memDis += "</div>";
                memDis += "</td>";
                memDis += "<td class=\"product-price\">" + mem1.Product_Price + "</td>";
                memDis += "<td class=\"product-price\"><input type=\"radio\" name=\"memr\" id=\"mem1r\" runat=\"server\"/></td>";
                memDis += "</tr>";
            }
            else
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</td>";
                memDis += "<td class=\"product-price\"></td>";
                memDis += "</tr>";
            }


            var mem2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential / 2))
                        select b).FirstOrDefault();

            if (mem2 != null)
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-img\">";
                memDis += "<img src=" + mem2.Product_Img + " alt=>";
                memDis += "</div>";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem2.Product_Id + ">On Budget: " + mem2.Product_Name + "</a>";
                memDis += "</h6>";
                memDis += "<p>Brand: " + mem2.Product_Brand + "</p>";
                memDis += "</div>";
                memDis += "</td>";
                memDis += "<td class=\"product-price\">" + mem2.Product_Price + "</td>";
                memDis += "<td class=\"product-price\"><input type=\"radio\" name=\"memr\" id=\"mem2r\" runat=\"server\"/></td>";
                memDis += "</tr>";
            }
            else
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</td>";
                memDis += "<td class=\"product-price\"></td>";
                memDis += "</tr>";
            }

            var mem3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential * 2))
                        select b).FirstOrDefault();

            if (mem3 != null)
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-img\">";
                memDis += "<img src=" + mem3.Product_Img + " alt=>";
                memDis += "</div>";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem3.Product_Id + ">Above Budget: " + mem3.Product_Name + "</a>";
                memDis += "</h6>";
                memDis += "<p>Brand: " + mem3.Product_Brand + "</p>";
                memDis += "</div>";
                memDis += "</td>";
                memDis += "<td class=\"product-price\">" + mem3.Product_Price + "</td>";
                memDis += "<td class=\"product-price\"><input type=\"radio\" name=\"memr\" id=\"mem3r\" runat=\"server\"/></td>";
                memDis += "</tr>";
            }
            else
            {
                memDis += "<tr>";
                memDis += "<td class=\"product-thumbnail\">";
                memDis += "<div class=\"pro-thumbnail-info text-left\">";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</td>";
                memDis += "<td class=\"product-price\"></td>";
                memDis += "</tr>";
            }


            memDis += "</tbody>";
            memDis += "</table>";

            memDiv.InnerHtml = memDis;

            string hardDis = "";

            hardDis += "<table class=text-center>";
            hardDis += "<thead>";
            hardDis += "<tr>";
            hardDis += "<th class=product-thumbnail>product</th>";
            hardDis += "<th class=product-price>price</th>";
            hardDis += "<th class=product-price>select</th>";
            hardDis += "</tr>";
            hardDis += "</thead>";
            hardDis += "<tbody>";

            var hard1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(hardBud - differential / 4))
                         select b).FirstOrDefault();

            if (hard1 != null)
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-img\">";
                hardDis += "<img src=" + hard1.Product_Img + " alt=>";
                hardDis += "</div>";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard1.Product_Id + ">Below Budget: " + hard1.Product_Name + "</a>";
                hardDis += "</h6>";
                hardDis += "<p>Brand: " + hard1.Product_Brand + "</p>";
                hardDis += "</div>";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\">" + hard1.Product_Price + "</td>";
                hardDis += "<td class=\"product-price\"><input type=\"radio\" name=\"hardr\" id=\"hard1r\" runat=\"server\"/></td>";
                hardDis += "</tr>";
            }
            else
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\"></td>";
                hardDis += "</tr>";
            }


            var hard2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential / 2))
                         select b).FirstOrDefault();

            if (hard2 != null)
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-img\">";
                hardDis += "<img src=" + hard2.Product_Img + " alt=>";
                hardDis += "</div>";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard2.Product_Id + ">On Budget: " + hard2.Product_Name + "</a>";
                hardDis += "</h6>";
                hardDis += "<p>Brand: " + hard2.Product_Brand + "</p>";
                hardDis += "</div>";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\">" + hard2.Product_Price + "</td>";
                hardDis += "<td class=\"product-price\"><input type=\"radio\" name=\"hardr\" id=\"hard2r\" runat=\"server\"/></td>";
                hardDis += "</tr>";
            }
            else
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\"></td>";
                hardDis += "</tr>";
            }

            var hard3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential))
                         select b).FirstOrDefault();

            if (hard3 != null)
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-img\">";
                hardDis += "<img src=" + hard3.Product_Img + " alt=>";
                hardDis += "</div>";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard3.Product_Id + ">Above Budget: " + hard3.Product_Name + "</a>";
                hardDis += "</h6>";
                hardDis += "<p>Brand: " + hard3.Product_Brand + "</p>";
                hardDis += "</div>";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\">" + hard3.Product_Price + "</td>";
                hardDis += "<td class=\"product-price\"><input type=\"radio\" name=\"hardr\" id=\"hard3r\" runat=\"server\"/></td>";
                hardDis += "</tr>";
            }
            else
            {
                hardDis += "<tr>";
                hardDis += "<td class=\"product-thumbnail\">";
                hardDis += "<div class=\"pro-thumbnail-info text-left\">";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</td>";
                hardDis += "<td class=\"product-price\"></td>";
                hardDis += "</tr>";
            }


            hardDis += "</tbody>";
            hardDis += "</table>";

            hardDiv.InnerHtml = hardDis;

            string psuDis = "";

            psuDis += "<table class=text-center>";
            psuDis += "<thead>";
            psuDis += "<tr>";
            psuDis += "<th class=product-thumbnail>product</th>";
            psuDis += "<th class=product-price>price</th>";
            psuDis += "<th class=product-price>select</th>";
            psuDis += "</tr>";
            psuDis += "</thead>";
            psuDis += "<tbody>";

            var psu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(1800))
                        select b).FirstOrDefault();

            if (psu1 != null)
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-img\">";
                psuDis += "<img src=" + psu1.Product_Img + " alt=>";
                psuDis += "</div>";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu1.Product_Id + ">Below Budget: " + psu1.Product_Name + "</a>";
                psuDis += "</h6>";
                psuDis += "<p>Brand: " + psu1.Product_Brand + "</p>";
                psuDis += "</div>";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\">" + psu1.Product_Price + "</td>";
                psuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"psur\" id=\"psu1r\" runat=\"server\"/></td>";
                psuDis += "</tr>";
            }
            else
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\"></td>";
                psuDis += "</tr>";
            }


            var psu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(1800)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential / 2))
                        select b).FirstOrDefault();

            if (psu2 != null)
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-img\">";
                psuDis += "<img src=" + psu2.Product_Img + " alt=>";
                psuDis += "</div>";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu2.Product_Id + ">On Budget: " + psu2.Product_Name + "</a>";
                psuDis += "</h6>";
                psuDis += "<p>Brand: " + psu2.Product_Brand + "</p>";
                psuDis += "</div>";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\">" + psu2.Product_Price + "</td>";
                psuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"psur\" id=\"psu2r\" runat=\"server\"/></td>";
                psuDis += "</tr>";
            }
            else
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\"></td>";
                psuDis += "</tr>";
            }

            var psu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(psuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential))
                        select b).FirstOrDefault();

            if (psu3 != null)
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-img\">";
                psuDis += "<img src=" + psu3.Product_Img + " alt=>";
                psuDis += "</div>";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu3.Product_Id + ">Above Budget: " + psu3.Product_Name + "</a>";
                psuDis += "</h6>";
                psuDis += "<p>Brand: " + psu3.Product_Brand + "</p>";
                psuDis += "</div>";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\">" + psu3.Product_Price + "</td>";
                psuDis += "<td class=\"product-price\"><input type=\"radio\" name=\"psur\" id=\"psu3r\" runat=\"server\"/></td>";
                psuDis += "</tr>";
            }
            else
            {
                psuDis += "<tr>";
                psuDis += "<td class=\"product-thumbnail\">";
                psuDis += "<div class=\"pro-thumbnail-info text-left\">";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</td>";
                psuDis += "<td class=\"product-price\"></td>";
                psuDis += "</tr>";
            }


            psuDis += "</tbody>";
            psuDis += "</table>";

            psuDiv.InnerHtml = psuDis;

            string caseDis = "";

            caseDis += "<table class=text-center>";
            caseDis += "<thead>";
            caseDis += "<tr>";
            caseDis += "<th class=product-thumbnail>product</th>";
            caseDis += "<th class=product-price>price</th>";
            caseDis += "<th class=product-price>select</th>";
            caseDis += "</tr>";
            caseDis += "</thead>";
            caseDis += "<tbody>";

            var case1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Gaming Case")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(caseBud - differential / 4))
                         select b).FirstOrDefault();

            if (case1 != null)
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-img\">";
                caseDis += "<img src=" + case1.Product_Img + " alt=>";
                caseDis += "</div>";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case1.Product_Id + ">Below Budget: " + case1.Product_Name + "</a>";
                caseDis += "</h6>";
                caseDis += "<p>Brand: " + case1.Product_Brand + "</p>";
                caseDis += "</div>";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\">" + case1.Product_Price + "</td>";
                caseDis += "<td class=\"product-price\"><input type=\"radio\" name=\"caser\" id=\"case1r\" runat=\"server\"/></td>";
                caseDis += "</tr>";
            }
            else
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\"></td>";
                caseDis += "</tr>";
            }


            var case2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Gaming Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential / 2))
                         select b).FirstOrDefault();

            if (case2 != null)
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-img\">";
                caseDis += "<img src=" + case2.Product_Img + " alt=>";
                caseDis += "</div>";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case2.Product_Id + ">On Budget: " + case2.Product_Name + "</a>";
                caseDis += "</h6>";
                caseDis += "<p>Brand: " + case2.Product_Brand + "</p>";
                caseDis += "</div>";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\">" + case2.Product_Price + "</td>";
                caseDis += "<td class=\"product-price\"><input type=\"radio\" name=\"caser\" id=\"case2r\" runat=\"server\"/></td>";
                caseDis += "</tr>";
            }
            else
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\"></td>";
                caseDis += "</tr>";
            }

            var case3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Gaming Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential))
                         select b).FirstOrDefault();

            if (case3 != null)
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-img\">";
                caseDis += "<img src=" + case3.Product_Img + " alt=>";
                caseDis += "</div>";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case3.Product_Id + ">Above Budget: " + case3.Product_Name + "</a>";
                caseDis += "</h6>";
                caseDis += "<p>Brand: " + case3.Product_Brand + "</p>";
                caseDis += "</div>";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\">" + case3.Product_Price + "</td>";
                caseDis += "<td class=\"product-price\"><input type=\"radio\" name=\"caser\" id=\"case3r\" runat=\"server\"/></td>";
                caseDis += "</tr>";
            }
            else
            {
                caseDis += "<tr>";
                caseDis += "<td class=\"product-thumbnail\">";
                caseDis += "<div class=\"pro-thumbnail-info text-left\">";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</td>";
                caseDis += "<td class=\"product-price\"></td>";
                caseDis += "</tr>";
            }


            caseDis += "</tbody>";
            caseDis += "</table>";

            caseDiv.InnerHtml = caseDis;
        }

        protected void finalise_Click(object sender, EventArgs e)
        {
            //string checkedButtonCpu = cpuDiv.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).ID;
            var checkedButtonCpu = cpuDiv.Controls
                             .OfType<RadioButton>()
                             .FirstOrDefault(r => r.GroupName == "cpur" && r.Checked);
            string cpuId = checkedButtonCpu.ID;
            check111.InnerHtml = "<p>" + cpuId + "</p>";
            var checkedButtonMobo = moboDiv.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //String moboID = checkedButtonMobo.ID;
            //var checkedButtonCool = coolDiv.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //String coolID = checkedButtonCool.ID;
            //var checkedButtonGpu = gpuDiv.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //String gpuID = checkedButtonGpu.ID;
            //var checkedButtonMem = memDiv.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //String memID = checkedButtonMem.ID;
            //var checkedButtonHard = hardDiv.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //String hardID = checkedButtonHard.ID;
            //var checkedButtonPsu = psuDiv.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //String psuID = checkedButtonPsu.ID;
            //var checkedButtonCase = caseDiv.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //String caseID = checkedButtonCase.ID;
            //Response.Redirect("Finalise.aspx?cpu=" + cpuID + "&" + "mobo=" + moboID + "&" + "cool=" + coolID + "&" + "gpu=" + gpuID + "&" + "mem=" + memID + " & " + "hard=" + hardID + "&" + "psu=" + psuID + "&" + "case=" + caseID);
        }
    }
}
