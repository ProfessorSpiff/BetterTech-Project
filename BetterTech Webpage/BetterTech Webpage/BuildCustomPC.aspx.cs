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
            var differential = bud * 0.05;
            string cpuDis = "";

            cpuDis += "<table class=text-center>";
            cpuDis += "<thead>";
            cpuDis += "<tr>";
            cpuDis += "<th class=product-thumbnail>product</th>";
            cpuDis += "<th class=product-price>price</th>";
            cpuDis += "<th class=product-remove>select</th>";
            cpuDis += "</tr>";
            cpuDis += "</thead>";
            cpuDis += "<tbody>";

            var cpu1 = (from Product b in db.Products
                       where b.Product_IsActive.Equals(true)
                       where b.Product_Type.Equals("CPU")
                       where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(cpuBud - differential/2))
                       select b).FirstOrDefault();


            cpuDis += "<tr>";
            cpuDis += "<td class=\"product-thumbnail\">";
            cpuDis += "<div class=\"pro-thumbnail-img\">";
            cpuDis += "<img src=" + cpu1.Product_Img + " alt=>";
            cpuDis += "</div>";       
            cpuDis += "<div class=\"pro-thumbnail-info text-left\">";                                           
            cpuDis += "<h6 class=\"product-title-2\">";                                
            cpuDis += "<a href=ProductPage.aspx?ID=" + cpu1.Product_Id + ">" + cpu1.Product_Name + "</a>" ;
            cpuDis += "</h6>";
            cpuDis += "<p>Brand: " + cpu1.Product_Brand + "</p>";
            cpuDis += "</div>";
            cpuDis += "</td>";
            cpuDis += "<td class=\"product-price\">" + cpu1.Product_Price + "</td>";           
            cpuDis += "<td class=product-remove>";
            cpuDis += "<input type=\"radio\" runat=\"server\" id=\"cpu1\" name=\"cpu\">Select</input>";     
            cpuDis += "</td>";
            cpuDis += "</tr>";


            var cpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential/2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential/2))
                        select b).FirstOrDefault();

            cpuDis += "<tr>";
            cpuDis += "<td class=\"product-thumbnail\">";
            cpuDis += "<div class=\"pro-thumbnail-img\">";
            cpuDis += "<img src=" + cpu2.Product_Img + " alt=>";
            cpuDis += "</div>";
            cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            cpuDis += "<h6 class=\"product-title-2\">";
            cpuDis += "<a href=ProductPage.aspx?ID=" + cpu2.Product_Id + ">" + cpu2.Product_Name + "</a>";
            cpuDis += "</h6>";
            cpuDis += "<p>Brand: " + cpu2.Product_Brand + "</p>";
            cpuDis += "</div>";
            cpuDis += "</td>";
            cpuDis += "<td class=\"product-price\">" + cpu2.Product_Price + "</td>";
            cpuDis += "<td class=product-remove>";
            cpuDis += "<input type=\"radio\" runat=\"server\" id=\"cpu2\" name=\"cpu\">Select</input>";
            cpuDis += "</td>";
            cpuDis += "</tr>";

            var cpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud + differential/2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential))
                        select b).FirstOrDefault();

            cpuDis += "<tr>";
            cpuDis += "<td class=\"product-thumbnail\">";
            cpuDis += "<div class=\"pro-thumbnail-img\">";
            cpuDis += "<img src=" + cpu3.Product_Img + " alt=>";
            cpuDis += "</div>";
            cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            cpuDis += "<h6 class=\"product-title-2\">";
            cpuDis += "<a href=ProductPage.aspx?ID=" + cpu3.Product_Id + ">" + cpu3.Product_Name + "</a>";
            cpuDis += "</h6>";
            cpuDis += "<p>Brand: " + cpu3.Product_Brand + "</p>";
            cpuDis += "</div>";
            cpuDis += "</td>";
            cpuDis += "<td class=\"product-price\">" + cpu3.Product_Price + "</td>";
            cpuDis += "<td class=product-remove>";
            cpuDis += "<input type =\"radio\" runat=\"server\" id=\"cpu3\" name=\"cpu\">Select</input>";
            cpuDis += "</td>";
            cpuDis += "</tr>";


            cpuDis += "</tbody>";
            cpuDis += "</table>";

            cpuDiv.InnerHtml = cpuDis;
            preferences.Attributes.Remove("class");
            preferences.Attributes.Add("class", "tab-pane");
            cpuBut.Attributes.Add("class", "active");
            cpu.Attributes.Remove("class");
            cpu.Attributes.Add("class", "tab-pane active");

            string moboDis = "";

            moboDis += "<table class=text-center>";
            moboDis += "<thead>";
            moboDis += "<tr>";
            moboDis += "<th class=product-thumbnail>product</th>";
            moboDis += "<th class=product-price>price</th>";
            moboDis += "<th class=product-remove>select</th>";
            moboDis += "</tr>";
            moboDis += "</thead>";
            moboDis += "<tbody>";

            var mobo1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Motherboard")
                        where b.Product_Price >= (Convert.ToDecimal(moboBud - differential)) && b.Product_Price <= (Convert.ToDecimal(moboBud - differential / 2))
                        select b).FirstOrDefault();


            moboDis += "<tr>";
            moboDis += "<td class=\"product-thumbnail\">";
            moboDis += "<div class=\"pro-thumbnail-img\">";
            moboDis += "<img src=" + mobo1.Product_Img + " alt=>";
            moboDis += "</div>";
            moboDis += "<div class=\"pro-thumbnail-info text-left\">";
            moboDis += "<h6 class=\"product-title-2\">";
            moboDis += "<a href=ProductPage.aspx?ID=" + mobo1.Product_Id + ">" + mobo1.Product_Name + "</a>";
            moboDis += "</h6>";
            moboDis += "<p>Brand: " + mobo1.Product_Brand + "</p>";
            moboDis += "</div>";
            moboDis += "</td>";
            moboDis += "<td class=\"product-price\">" + mobo1.Product_Price + "</td>";
            moboDis += "<td class=product-remove>";
            moboDis += "<input type=\"radio\" runat=\"server\" id=\"mobo1\" name=\"mobo\">Select</input>";
            moboDis += "</td>";
            moboDis += "</tr>";


            var mobo2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Motherboard")
                        where b.Product_Price >= (Convert.ToDecimal(moboBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential / 2))
                        select b).FirstOrDefault();

            moboDis += "<tr>";
            moboDis += "<td class=\"product-thumbnail\">";
            moboDis += "<div class=\"pro-thumbnail-img\">";
            moboDis += "<img src=" + mobo2.Product_Img + " alt=>";
            moboDis += "</div>";
            moboDis += "<div class=\"pro-thumbnail-info text-left\">";
            moboDis += "<h6 class=\"product-title-2\">";
            moboDis += "<a href=ProductPage.aspx?ID=" + mobo2.Product_Id + ">" + mobo2.Product_Name + "</a>";
            moboDis += "</h6>";
            moboDis += "<p>Brand: " + mobo2.Product_Brand + "</p>";
            moboDis += "</div>";
            moboDis += "</td>";
            moboDis += "<td class=\"product-price\">" + mobo2.Product_Price + "</td>";
            moboDis += "<td class=product-remove>";
            moboDis += "<input type=\"radio\" runat=\"server\" id=\"mobo2\" name=\"mobo\">Select</input>";
            moboDis += "</td>";
            moboDis += "</tr>";

            var mobo3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Motherboard")
                        where b.Product_Price >= (Convert.ToDecimal(moboBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential))
                        select b).FirstOrDefault();

            moboDis += "<tr>";
            moboDis += "<td class=\"product-thumbnail\">";
            moboDis += "<div class=\"pro-thumbnail-img\">";
            moboDis += "<img src=" + mobo3.Product_Img + " alt=>";
            moboDis += "</div>";
            moboDis += "<div class=\"pro-thumbnail-info text-left\">";
            moboDis += "<h6 class=\"product-title-2\">";
            moboDis += "<a href=ProductPage.aspx?ID=" + mobo3.Product_Id + ">" + mobo3.Product_Name + "</a>";
            moboDis += "</h6>";
            moboDis += "<p>Brand: " + mobo3.Product_Brand + "</p>";
            moboDis += "</div>";
            moboDis += "</td>";
            moboDis += "<td class=\"product-price\">" + mobo3.Product_Price + "</td>";
            moboDis += "<td class=product-remove>";
            moboDis += "<input type=\"radio\" runat=\"server\" id=\"mobo3\" name=\"mobo\">Select</input>";
            moboDis += "</td>";
            moboDis += "</tr>";


            moboDis += "</tbody>";
            moboDis += "</table>";

            moboDiv.InnerHtml = moboDis;

            string coolDis = "";

            coolDis += "<table class=text-center>";
            coolDis += "<thead>";
            coolDis += "<tr>";
            coolDis += "<th class=product-thumbnail>product</th>";
            coolDis += "<th class=product-price>price</th>";
            coolDis += "<th class=product-remove>select</th>";
            coolDis += "</tr>";
            coolDis += "</thead>";
            coolDis += "<tbody>";

            var cool1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential)) && b.Product_Price <= (Convert.ToDecimal(coolBud - differential / 2))
                         select b).FirstOrDefault();


            coolDis += "<tr>";
            coolDis += "<td class=\"product-thumbnail\">";
            coolDis += "<div class=\"pro-thumbnail-img\">";
            coolDis += "<img src=" + cool1.Product_Img + " alt=>";
            coolDis += "</div>";
            coolDis += "<div class=\"pro-thumbnail-info text-left\">";
            coolDis += "<h6 class=\"product-title-2\">";
            coolDis += "<a href=ProductPage.aspx?ID=" + cool1.Product_Id + ">" + cool1.Product_Name + "</a>";
            coolDis += "</h6>";
            coolDis += "<p>Brand: " + cool1.Product_Brand + "</p>";
            coolDis += "</div>";
            coolDis += "</td>";
            coolDis += "<td class=\"product-price\">" + cool1.Product_Price + "</td>";
            coolDis += "<td class=product-remove>";
            coolDis += "<a href=SelectItem.aspx?ID=" + cool1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            coolDis += "</td>";
            coolDis += "</tr>";


            var cool2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential / 2))
                         select b).FirstOrDefault();

            coolDis += "<tr>";
            coolDis += "<td class=\"product-thumbnail\">";
            coolDis += "<div class=\"pro-thumbnail-img\">";
            coolDis += "<img src=" + cool2.Product_Img + " alt=>";
            coolDis += "</div>";
            coolDis += "<div class=\"pro-thumbnail-info text-left\">";
            coolDis += "<h6 class=\"product-title-2\">";
            coolDis += "<a href=ProductPage.aspx?ID=" + cool2.Product_Id + ">" + cool2.Product_Name + "</a>";
            coolDis += "</h6>";
            coolDis += "<p>Brand: " + cool2.Product_Brand + "</p>";
            coolDis += "</div>";
            coolDis += "</td>";
            coolDis += "<td class=\"product-price\">" + cool2.Product_Price + "</td>";
            coolDis += "<td class=product-remove>";
            coolDis += "<a href=SelectItem.aspx?ID=" + cool2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            coolDis += "</td>";
            coolDis += "</tr>";

            var cool3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential))
                         select b).FirstOrDefault();

            coolDis += "<tr>";
            coolDis += "<td class=\"product-thumbnail\">";
            coolDis += "<div class=\"pro-thumbnail-img\">";
            coolDis += "<img src=" + cool3.Product_Img + " alt=>";
            coolDis += "</div>";
            coolDis += "<div class=\"pro-thumbnail-info text-left\">";
            coolDis += "<h6 class=\"product-title-2\">";
            coolDis += "<a href=ProductPage.aspx?ID=" + cool3.Product_Id + ">" + cool3.Product_Name + "</a>";
            coolDis += "</h6>";
            coolDis += "<p>Brand: " + cool3.Product_Brand + "</p>";
            coolDis += "</div>";
            coolDis += "</td>";
            coolDis += "<td class=\"product-price\">" + cool3.Product_Price + "</td>";
            coolDis += "<td class=product-remove>";
            coolDis += "<a href=SelectItem.aspx?ID=" + cool3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            coolDis += "</td>";
            coolDis += "</tr>";


            coolDis += "</tbody>";
            coolDis += "</table>";

            coolDiv.InnerHtml = coolDis;

            string gpuDis = "";

            gpuDis += "<table class=text-center>";
            gpuDis += "<thead>";
            gpuDis += "<tr>";
            gpuDis += "<th class=product-thumbnail>product</th>";
            gpuDis += "<th class=product-price>price</th>";
            gpuDis += "<th class=product-remove>select</th>";
            gpuDis += "</tr>";
            gpuDis += "</thead>";
            gpuDis += "<tbody>";

            var gpu1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("GPU")
                         where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(gpuBud - differential / 2))
                         select b).FirstOrDefault();


            gpuDis += "<tr>";
            gpuDis += "<td class=\"product-thumbnail\">";
            gpuDis += "<div class=\"pro-thumbnail-img\">";
            gpuDis += "<img src=" + gpu1.Product_Img + " alt=>";
            gpuDis += "</div>";
            gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            gpuDis += "<h6 class=\"product-title-2\">";
            gpuDis += "<a href=ProductPage.aspx?ID=" + gpu1.Product_Id + ">" + gpu1.Product_Name + "</a>";
            gpuDis += "</h6>";
            gpuDis += "<p>Brand: " + gpu1.Product_Brand + "</p>";
            gpuDis += "</div>";
            gpuDis += "</td>";
            gpuDis += "<td class=\"product-price\">" + gpu1.Product_Price + "</td>";
            gpuDis += "<td class=product-remove>";
            gpuDis += "<a href=SelectItem.aspx?ID=" + gpu1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            gpuDis += "</td>";
            gpuDis += "</tr>";


            var gpu2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("GPU")
                         where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential / 2))
                         select b).FirstOrDefault();

            gpuDis += "<tr>";
            gpuDis += "<td class=\"product-thumbnail\">";
            gpuDis += "<div class=\"pro-thumbnail-img\">";
            gpuDis += "<img src=" + gpu2.Product_Img + " alt=>";
            gpuDis += "</div>";
            gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            gpuDis += "<h6 class=\"product-title-2\">";
            gpuDis += "<a href=ProductPage.aspx?ID=" + gpu2.Product_Id + ">" + gpu2.Product_Name + "</a>";
            gpuDis += "</h6>";
            gpuDis += "<p>Brand: " + gpu2.Product_Brand + "</p>";
            gpuDis += "</div>";
            gpuDis += "</td>";
            gpuDis += "<td class=\"product-price\">" + gpu2.Product_Price + "</td>";
            gpuDis += "<td class=product-remove>";
            gpuDis += "<a href=SelectItem.aspx?ID=" + gpu2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            gpuDis += "</td>";
            gpuDis += "</tr>";

            var gpu3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("GPU")
                         where b.Product_Price >= (Convert.ToDecimal(gpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential))
                         select b).FirstOrDefault();

            gpuDis += "<tr>";
            gpuDis += "<td class=\"product-thumbnail\">";
            gpuDis += "<div class=\"pro-thumbnail-img\">";
            gpuDis += "<img src=" + gpu3.Product_Img + " alt=>";
            gpuDis += "</div>";
            gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            gpuDis += "<h6 class=\"product-title-2\">";
            gpuDis += "<a href=ProductPage.aspx?ID=" + gpu3.Product_Id + ">" + gpu3.Product_Name + "</a>";
            gpuDis += "</h6>";
            gpuDis += "<p>Brand: " + gpu3.Product_Brand + "</p>";
            gpuDis += "</div>";
            gpuDis += "</td>";
            gpuDis += "<td class=\"product-price\">" + gpu3.Product_Price + "</td>";
            gpuDis += "<td class=product-remove>";
            gpuDis += "<a href=SelectItem.aspx?ID=" + gpu3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            gpuDis += "</td>";
            gpuDis += "</tr>";


            gpuDis += "</tbody>";
            gpuDis += "</table>";

            gpuDiv.InnerHtml = gpuDis;

            string memDis = "";

            memDis += "<table class=text-center>";
            memDis += "<thead>";
            memDis += "<tr>";
            memDis += "<th class=product-thumbnail>product</th>";
            memDis += "<th class=product-price>price</th>";
            memDis += "<th class=product-remove>select</th>";
            memDis += "</tr>";
            memDis += "</thead>";
            memDis += "<tbody>";

            var mem1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential)) && b.Product_Price <= (Convert.ToDecimal(ramBud - differential / 2))
                        select b).FirstOrDefault();


            memDis += "<tr>";
            memDis += "<td class=\"product-thumbnail\">";
            memDis += "<div class=\"pro-thumbnail-img\">";
            memDis += "<img src=" + mem1.Product_Img + " alt=>";
            memDis += "</div>";
            memDis += "<div class=\"pro-thumbnail-info text-left\">";
            memDis += "<h6 class=\"product-title-2\">";
            memDis += "<a href=ProductPage.aspx?ID=" + mem1.Product_Id + ">" + mem1.Product_Name + "</a>";
            memDis += "</h6>";
            memDis += "<p>Brand: " + mem1.Product_Brand + "</p>";
            memDis += "</div>";
            memDis += "</td>";
            memDis += "<td class=\"product-price\">" + mem1.Product_Price + "</td>";
            memDis += "<td class=product-remove>";
            memDis += "<a href=SelectItem.aspx?ID=" + mem1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            memDis += "</td>";
            memDis += "</tr>";


            var mem2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential / 2))
                        select b).FirstOrDefault();

            memDis += "<tr>";
            memDis += "<td class=\"product-thumbnail\">";
            memDis += "<div class=\"pro-thumbnail-img\">";
            memDis += "<img src=" + mem2.Product_Img + " alt=>";
            memDis += "</div>";
            memDis += "<div class=\"pro-thumbnail-info text-left\">";
            memDis += "<h6 class=\"product-title-2\">";
            memDis += "<a href=ProductPage.aspx?ID=" + mem2.Product_Id + ">" + mem2.Product_Name + "</a>";
            memDis += "</h6>";
            memDis += "<p>Brand: " + mem2.Product_Brand + "</p>";
            memDis += "</div>";
            memDis += "</td>";
            memDis += "<td class=\"product-price\">" + mem2.Product_Price + "</td>";
            memDis += "<td class=product-remove>";
            memDis += "<a href=SelectItem.aspx?ID=" + mem2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            memDis += "</td>";
            memDis += "</tr>";

            var mem3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential))
                        select b).FirstOrDefault();

            memDis += "<tr>";
            memDis += "<td class=\"product-thumbnail\">";
            memDis += "<div class=\"pro-thumbnail-img\">";
            memDis += "<img src=" + mem3.Product_Img + " alt=>";
            memDis += "</div>";
            memDis += "<div class=\"pro-thumbnail-info text-left\">";
            memDis += "<h6 class=\"product-title-2\">";
            memDis += "<a href=ProductPage.aspx?ID=" + mem3.Product_Id + ">" + mem3.Product_Name + "</a>";
            memDis += "</h6>";
            memDis += "<p>Brand: " + mem3.Product_Brand + "</p>";
            memDis += "</div>";
            memDis += "</td>";
            memDis += "<td class=\"product-price\">" + mem3.Product_Price + "</td>";
            memDis += "<td class=product-remove>";
            memDis += "<a href=SelectItem.aspx?ID=" + mem3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            memDis += "</td>";
            memDis += "</tr>";


            memDis += "</tbody>";
            memDis += "</table>";

            memDiv.InnerHtml = memDis;

            string hardDis = "";

            hardDis += "<table class=text-center>";
            hardDis += "<thead>";
            hardDis += "<tr>";
            hardDis += "<th class=product-thumbnail>product</th>";
            hardDis += "<th class=product-price>price</th>";
            hardDis += "<th class=product-remove>select</th>";
            hardDis += "</tr>";
            hardDis += "</thead>";
            hardDis += "<tbody>";

            var hard1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Hard Drive")
                        where b.Product_Price >= (Convert.ToDecimal(hardBud - differential)) && b.Product_Price <= (Convert.ToDecimal(hardBud - differential / 2))
                        select b).FirstOrDefault();


            hardDis += "<tr>";
            hardDis += "<td class=\"product-thumbnail\">";
            hardDis += "<div class=\"pro-thumbnail-img\">";
            hardDis += "<img src=" + hard1.Product_Img + " alt=>";
            hardDis += "</div>";
            hardDis += "<div class=\"pro-thumbnail-info text-left\">";
            hardDis += "<h6 class=\"product-title-2\">";
            hardDis += "<a href=ProductPage.aspx?ID=" + hard1.Product_Id + ">" + hard1.Product_Name + "</a>";
            hardDis += "</h6>";
            hardDis += "<p>Brand: " + hard1.Product_Brand + "</p>";
            hardDis += "</div>";
            hardDis += "</td>";
            hardDis += "<td class=\"product-price\">" + hard1.Product_Price + "</td>";
            hardDis += "<td class=product-remove>";
            hardDis += "<a href=SelectItem.aspx?ID=" + hard1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            hardDis += "</td>";
            hardDis += "</tr>";


            var hard2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Hard Drive")
                        where b.Product_Price >= (Convert.ToDecimal(hardBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential / 2))
                        select b).FirstOrDefault();

            hardDis += "<tr>";
            hardDis += "<td class=\"product-thumbnail\">";
            hardDis += "<div class=\"pro-thumbnail-img\">";
            hardDis += "<img src=" + hard2.Product_Img + " alt=>";
            hardDis += "</div>";
            hardDis += "<div class=\"pro-thumbnail-info text-left\">";
            hardDis += "<h6 class=\"product-title-2\">";
            hardDis += "<a href=ProductPage.aspx?ID=" + hard2.Product_Id + ">" + hard2.Product_Name + "</a>";
            hardDis += "</h6>";
            hardDis += "<p>Brand: " + hard2.Product_Brand + "</p>";
            hardDis += "</div>";
            hardDis += "</td>";
            hardDis += "<td class=\"product-price\">" + hard2.Product_Price + "</td>";
            hardDis += "<td class=product-remove>";
            hardDis += "<a href=SelectItem.aspx?ID=" + hard2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            hardDis += "</td>";
            hardDis += "</tr>";

            var hard3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Hard Drive")
                        where b.Product_Price >= (Convert.ToDecimal(hardBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential))
                        select b).FirstOrDefault();

            hardDis += "<tr>";
            hardDis += "<td class=\"product-thumbnail\">";
            hardDis += "<div class=\"pro-thumbnail-img\">";
            hardDis += "<img src=" + hard3.Product_Img + " alt=>";
            hardDis += "</div>";
            hardDis += "<div class=\"pro-thumbnail-info text-left\">";
            hardDis += "<h6 class=\"product-title-2\">";
            hardDis += "<a href=ProductPage.aspx?ID=" + hard3.Product_Id + ">" + hard3.Product_Name + "</a>";
            hardDis += "</h6>";
            hardDis += "<p>Brand: " + hard3.Product_Brand + "</p>";
            hardDis += "</div>";
            hardDis += "</td>";
            hardDis += "<td class=\"product-price\">" + hard3.Product_Price + "</td>";
            hardDis += "<td class=product-remove>";
            hardDis += "<a href=SelectItem.aspx?ID=" + hard3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            hardDis += "</td>";
            hardDis += "</tr>";


            hardDis += "</tbody>";
            hardDis += "</table>";

            hardDiv.InnerHtml = hardDis;

            string psuDis = "";

            psuDis += "<table class=text-center>";
            psuDis += "<thead>";
            psuDis += "<tr>";
            psuDis += "<th class=product-thumbnail>product</th>";
            psuDis += "<th class=product-price>price</th>";
            psuDis += "<th class=product-remove>select</th>";
            psuDis += "</tr>";
            psuDis += "</thead>";
            psuDis += "<tbody>";

            var psu1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("PSU")
                         where b.Product_Price >= (Convert.ToDecimal(psuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(psuBud - differential / 2))
                         select b).FirstOrDefault();


            psuDis += "<tr>";
            psuDis += "<td class=\"product-thumbnail\">";
            psuDis += "<div class=\"pro-thumbnail-img\">";
            psuDis += "<img src=" + psu1.Product_Img + " alt=>";
            psuDis += "</div>";
            psuDis += "<div class=\"pro-thumbnail-info text-left\">";
            psuDis += "<h6 class=\"product-title-2\">";
            psuDis += "<a href=ProductPage.aspx?ID=" + psu1.Product_Id + ">" + psu1.Product_Name + "</a>";
            psuDis += "</h6>";
            psuDis += "<p>Brand: " + psu1.Product_Brand + "</p>";
            psuDis += "</div>";
            psuDis += "</td>";
            psuDis += "<td class=\"product-price\">" + psu1.Product_Price + "</td>";
            psuDis += "<td class=product-remove>";
            psuDis += "<a href=SelectItem.aspx?ID=" + psu1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            psuDis += "</td>";
            psuDis += "</tr>";


            var psu2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("PSU")
                         where b.Product_Price >= (Convert.ToDecimal(psuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential / 2))
                         select b).FirstOrDefault();

            psuDis += "<tr>";
            psuDis += "<td class=\"product-thumbnail\">";
            psuDis += "<div class=\"pro-thumbnail-img\">";
            psuDis += "<img src=" + psu2.Product_Img + " alt=>";
            psuDis += "</div>";
            psuDis += "<div class=\"pro-thumbnail-info text-left\">";
            psuDis += "<h6 class=\"product-title-2\">";
            psuDis += "<a href=ProductPage.aspx?ID=" + psu2.Product_Id + ">" + psu2.Product_Name + "</a>";
            psuDis += "</h6>";
            psuDis += "<p>Brand: " + psu2.Product_Brand + "</p>";
            psuDis += "</div>";
            psuDis += "</td>";
            psuDis += "<td class=\"product-price\">" + psu2.Product_Price + "</td>";
            psuDis += "<td class=product-remove>";
            psuDis += "<a href=SelectItem.aspx?ID=" + psu2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            psuDis += "</td>";
            psuDis += "</tr>";

            var psu3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("PSU")
                         where b.Product_Price >= (Convert.ToDecimal(psuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential))
                         select b).FirstOrDefault();

            psuDis += "<tr>";
            psuDis += "<td class=\"product-thumbnail\">";
            psuDis += "<div class=\"pro-thumbnail-img\">";
            psuDis += "<img src=" + psu3.Product_Img + " alt=>";
            psuDis += "</div>";
            psuDis += "<div class=\"pro-thumbnail-info text-left\">";
            psuDis += "<h6 class=\"product-title-2\">";
            psuDis += "<a href=ProductPage.aspx?ID=" + psu3.Product_Id + ">" + psu3.Product_Name + "</a>";
            psuDis += "</h6>";
            psuDis += "<p>Brand: " + psu3.Product_Brand + "</p>";
            psuDis += "</div>";
            psuDis += "</td>";
            psuDis += "<td class=\"product-price\">" + psu3.Product_Price + "</td>";
            psuDis += "<td class=product-remove>";
            psuDis += "<a href=SelectItem.aspx?ID=" + psu3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            psuDis += "</td>";
            psuDis += "</tr>";


            psuDis += "</tbody>";
            psuDis += "</table>";

            psuDiv.InnerHtml = psuDis;

            string caseDis = "";

            caseDis += "<table class=text-center>";
            caseDis += "<thead>";
            caseDis += "<tr>";
            caseDis += "<th class=product-thumbnail>product</th>";
            caseDis += "<th class=product-price>price</th>";
            caseDis += "<th class=product-remove>select</th>";
            caseDis += "</tr>";
            caseDis += "</thead>";
            caseDis += "<tbody>";

            var case1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Case")
                        where b.Product_Price >= (Convert.ToDecimal(caseBud - differential)) && b.Product_Price <= (Convert.ToDecimal(caseBud - differential / 2))
                        select b).FirstOrDefault();


            caseDis += "<tr>";
            caseDis += "<td class=\"product-thumbnail\">";
            caseDis += "<div class=\"pro-thumbnail-img\">";
            caseDis += "<img src=" + case1.Product_Img + " alt=>";
            caseDis += "</div>";
            caseDis += "<div class=\"pro-thumbnail-info text-left\">";
            caseDis += "<h6 class=\"product-title-2\">";
            caseDis += "<a href=ProductPage.aspx?ID=" + case1.Product_Id + ">" + case1.Product_Name + "</a>";
            caseDis += "</h6>";
            caseDis += "<p>Brand: " + case1.Product_Brand + "</p>";
            caseDis += "</div>";
            caseDis += "</td>";
            caseDis += "<td class=\"product-price\">" + case1.Product_Price + "</td>";
            caseDis += "<td class=product-remove>";
            caseDis += "<a href=SelectItem.aspx?ID=" + case1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            caseDis += "</td>";
            caseDis += "</tr>";


            var case2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Case")
                        where b.Product_Price >= (Convert.ToDecimal(caseBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential / 2))
                        select b).FirstOrDefault();

            caseDis += "<tr>";
            caseDis += "<td class=\"product-thumbnail\">";
            caseDis += "<div class=\"pro-thumbnail-img\">";
            caseDis += "<img src=" + case2.Product_Img + " alt=>";
            caseDis += "</div>";
            caseDis += "<div class=\"pro-thumbnail-info text-left\">";
            caseDis += "<h6 class=\"product-title-2\">";
            caseDis += "<a href=ProductPage.aspx?ID=" + case2.Product_Id + ">" + case2.Product_Name + "</a>";
            caseDis += "</h6>";
            caseDis += "<p>Brand: " + case2.Product_Brand + "</p>";
            caseDis += "</div>";
            caseDis += "</td>";
            caseDis += "<td class=\"product-price\">" + case2.Product_Price + "</td>";
            caseDis += "<td class=product-remove>";
            caseDis += "<a href=SelectItem.aspx?ID=" + case2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            caseDis += "</td>";
            caseDis += "</tr>";

            var case3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Case")
                        where b.Product_Price >= (Convert.ToDecimal(caseBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential))
                        select b).FirstOrDefault();

            caseDis += "<tr>";
            caseDis += "<td class=\"product-thumbnail\">";
            caseDis += "<div class=\"pro-thumbnail-img\">";
            caseDis += "<img src=" + case3.Product_Img + " alt=>";
            caseDis += "</div>";
            caseDis += "<div class=\"pro-thumbnail-info text-left\">";
            caseDis += "<h6 class=\"product-title-2\">";
            caseDis += "<a href=ProductPage.aspx?ID=" + case3.Product_Id + ">" + case3.Product_Name + "</a>";
            caseDis += "</h6>";
            caseDis += "<p>Brand: " + case3.Product_Brand + "</p>";
            caseDis += "</div>";
            caseDis += "</td>";
            caseDis += "<td class=\"product-price\">" + case3.Product_Price + "</td>";
            caseDis += "<td class=product-remove>";
            caseDis += "<a href=SelectItem.aspx?ID=" + case3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            caseDis += "</td>";
            caseDis += "</tr>";


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
            var differential = bud * 0.05;
            
            string cpuDis = "";

            cpuDis += "<table class=text-center>";
            cpuDis += "<thead>";
            cpuDis += "<tr>";
            cpuDis += "<th class=product-thumbnail>product</th>";
            cpuDis += "<th class=product-price>price</th>";
            cpuDis += "<th class=product-remove>select</th>";
            cpuDis += "</tr>";
            cpuDis += "</thead>";
            cpuDis += "<tbody>";

            var cpu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(cpuBud - differential / 2))
                        select b).FirstOrDefault();


            cpuDis += "<tr>";
            cpuDis += "<td class=\"product-thumbnail\">";
            cpuDis += "<div class=\"pro-thumbnail-img\">";
            cpuDis += "<img src=" + cpu1.Product_Img + " alt=>";
            cpuDis += "</div>";
            cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            cpuDis += "<h6 class=\"product-title-2\">";
            cpuDis += "<a href=ProductPage.aspx?ID=" + cpu1.Product_Id + ">" + cpu1.Product_Name + "</a>";
            cpuDis += "</h6>";
            cpuDis += "<p>Brand: " + cpu1.Product_Brand + "</p>";
            cpuDis += "</div>";
            cpuDis += "</td>";
            cpuDis += "<td class=\"product-price\">" + cpu1.Product_Price + "</td>";
            cpuDis += "<td class=product-remove>";
            cpuDis += "<a href=SelectItem.aspx?ID=" + cpu1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            cpuDis += "</td>";
            cpuDis += "</tr>";


            var cpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential / 2))
                        select b).FirstOrDefault();

            cpuDis += "<tr>";
            cpuDis += "<td class=\"product-thumbnail\">";
            cpuDis += "<div class=\"pro-thumbnail-img\">";
            cpuDis += "<img src=" + cpu2.Product_Img + " alt=>";
            cpuDis += "</div>";
            cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            cpuDis += "<h6 class=\"product-title-2\">";
            cpuDis += "<a href=ProductPage.aspx?ID=" + cpu2.Product_Id + ">" + cpu2.Product_Name + "</a>";
            cpuDis += "</h6>";
            cpuDis += "<p>Brand: " + cpu2.Product_Brand + "</p>";
            cpuDis += "</div>";
            cpuDis += "</td>";
            cpuDis += "<td class=\"product-price\">" + cpu2.Product_Price + "</td>";
            cpuDis += "<td class=product-remove>";
            cpuDis += "<a href=SelectItem.aspx?ID=" + cpu2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            cpuDis += "</td>";
            cpuDis += "</tr>";

            var cpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential))
                        select b).FirstOrDefault();

            cpuDis += "<tr>";
            cpuDis += "<td class=\"product-thumbnail\">";
            cpuDis += "<div class=\"pro-thumbnail-img\">";
            cpuDis += "<img src=" + cpu3.Product_Img + " alt=>";
            cpuDis += "</div>";
            cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            cpuDis += "<h6 class=\"product-title-2\">";
            cpuDis += "<a href=ProductPage.aspx?ID=" + cpu3.Product_Id + ">" + cpu3.Product_Name + "</a>";
            cpuDis += "</h6>";
            cpuDis += "<p>Brand: " + cpu3.Product_Brand + "</p>";
            cpuDis += "</div>";
            cpuDis += "</td>";
            cpuDis += "<td class=\"product-price\">" + cpu3.Product_Price + "</td>";
            cpuDis += "<td class=product-remove>";
            cpuDis += "<a href=SelectItem.aspx?ID=" + cpu3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            cpuDis += "</td>";
            cpuDis += "</tr>";


            cpuDis += "</tbody>";
            cpuDis += "</table>";

            cpuDiv.InnerHtml = cpuDis;
            preferences.Attributes.Remove("class");
            preferences.Attributes.Add("class", "tab-pane");
            cpuBut.Attributes.Add("class", "active");
            cpu.Attributes.Remove("class");
            cpu.Attributes.Add("class", "tab-pane active");

            string moboDis = "";

            moboDis += "<table class=text-center>";
            moboDis += "<thead>";
            moboDis += "<tr>";
            moboDis += "<th class=product-thumbnail>product</th>";
            moboDis += "<th class=product-price>price</th>";
            moboDis += "<th class=product-remove>select</th>";
            moboDis += "</tr>";
            moboDis += "</thead>";
            moboDis += "<tbody>";

            var mobo1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud - differential)) && b.Product_Price <= (Convert.ToDecimal(moboBud - differential / 2))
                         select b).FirstOrDefault();


            moboDis += "<tr>";
            moboDis += "<td class=\"product-thumbnail\">";
            moboDis += "<div class=\"pro-thumbnail-img\">";
            moboDis += "<img src=" + mobo1.Product_Img + " alt=>";
            moboDis += "</div>";
            moboDis += "<div class=\"pro-thumbnail-info text-left\">";
            moboDis += "<h6 class=\"product-title-2\">";
            moboDis += "<a href=ProductPage.aspx?ID=" + mobo1.Product_Id + ">" + mobo1.Product_Name + "</a>";
            moboDis += "</h6>";
            moboDis += "<p>Brand: " + mobo1.Product_Brand + "</p>";
            moboDis += "</div>";
            moboDis += "</td>";
            moboDis += "<td class=\"product-price\">" + mobo1.Product_Price + "</td>";
            moboDis += "<td class=product-remove>";
            moboDis += "<a href=SelectItem.aspx?ID=" + mobo1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            moboDis += "</td>";
            moboDis += "</tr>";


            var mobo2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential / 2))
                         select b).FirstOrDefault();

            moboDis += "<tr>";
            moboDis += "<td class=\"product-thumbnail\">";
            moboDis += "<div class=\"pro-thumbnail-img\">";
            moboDis += "<img src=" + mobo2.Product_Img + " alt=>";
            moboDis += "</div>";
            moboDis += "<div class=\"pro-thumbnail-info text-left\">";
            moboDis += "<h6 class=\"product-title-2\">";
            moboDis += "<a href=ProductPage.aspx?ID=" + mobo2.Product_Id + ">" + mobo2.Product_Name + "</a>";
            moboDis += "</h6>";
            moboDis += "<p>Brand: " + mobo2.Product_Brand + "</p>";
            moboDis += "</div>";
            moboDis += "</td>";
            moboDis += "<td class=\"product-price\">" + mobo2.Product_Price + "</td>";
            moboDis += "<td class=product-remove>";
            moboDis += "<a href=SelectItem.aspx?ID=" + mobo2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            moboDis += "</td>";
            moboDis += "</tr>";

            var mobo3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential))
                         select b).FirstOrDefault();

            moboDis += "<tr>";
            moboDis += "<td class=\"product-thumbnail\">";
            moboDis += "<div class=\"pro-thumbnail-img\">";
            moboDis += "<img src=" + mobo3.Product_Img + " alt=>";
            moboDis += "</div>";
            moboDis += "<div class=\"pro-thumbnail-info text-left\">";
            moboDis += "<h6 class=\"product-title-2\">";
            moboDis += "<a href=ProductPage.aspx?ID=" + mobo3.Product_Id + ">" + mobo3.Product_Name + "</a>";
            moboDis += "</h6>";
            moboDis += "<p>Brand: " + mobo3.Product_Brand + "</p>";
            moboDis += "</div>";
            moboDis += "</td>";
            moboDis += "<td class=\"product-price\">" + mobo3.Product_Price + "</td>";
            moboDis += "<td class=product-remove>";
            moboDis += "<a href=SelectItem.aspx?ID=" + mobo3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            moboDis += "</td>";
            moboDis += "</tr>";


            moboDis += "</tbody>";
            moboDis += "</table>";

            moboDiv.InnerHtml = moboDis;

            string coolDis = "";

            coolDis += "<table class=text-center>";
            coolDis += "<thead>";
            coolDis += "<tr>";
            coolDis += "<th class=product-thumbnail>product</th>";
            coolDis += "<th class=product-price>price</th>";
            coolDis += "<th class=product-remove>select</th>";
            coolDis += "</tr>";
            coolDis += "</thead>";
            coolDis += "<tbody>";

            var cool1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential)) && b.Product_Price <= (Convert.ToDecimal(coolBud - differential / 2))
                         select b).FirstOrDefault();


            coolDis += "<tr>";
            coolDis += "<td class=\"product-thumbnail\">";
            coolDis += "<div class=\"pro-thumbnail-img\">";
            coolDis += "<img src=" + cool1.Product_Img + " alt=>";
            coolDis += "</div>";
            coolDis += "<div class=\"pro-thumbnail-info text-left\">";
            coolDis += "<h6 class=\"product-title-2\">";
            coolDis += "<a href=ProductPage.aspx?ID=" + cool1.Product_Id + ">" + cool1.Product_Name + "</a>";
            coolDis += "</h6>";
            coolDis += "<p>Brand: " + cool1.Product_Brand + "</p>";
            coolDis += "</div>";
            coolDis += "</td>";
            coolDis += "<td class=\"product-price\">" + cool1.Product_Price + "</td>";
            coolDis += "<td class=product-remove>";
            coolDis += "<a href=SelectItem.aspx?ID=" + cool1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            coolDis += "</td>";
            coolDis += "</tr>";


            var cool2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential / 2))
                         select b).FirstOrDefault();

            coolDis += "<tr>";
            coolDis += "<td class=\"product-thumbnail\">";
            coolDis += "<div class=\"pro-thumbnail-img\">";
            coolDis += "<img src=" + cool2.Product_Img + " alt=>";
            coolDis += "</div>";
            coolDis += "<div class=\"pro-thumbnail-info text-left\">";
            coolDis += "<h6 class=\"product-title-2\">";
            coolDis += "<a href=ProductPage.aspx?ID=" + cool2.Product_Id + ">" + cool2.Product_Name + "</a>";
            coolDis += "</h6>";
            coolDis += "<p>Brand: " + cool2.Product_Brand + "</p>";
            coolDis += "</div>";
            coolDis += "</td>";
            coolDis += "<td class=\"product-price\">" + cool2.Product_Price + "</td>";
            coolDis += "<td class=product-remove>";
            coolDis += "<a href=SelectItem.aspx?ID=" + cool2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            coolDis += "</td>";
            coolDis += "</tr>";

            var cool3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential))
                         select b).FirstOrDefault();

            coolDis += "<tr>";
            coolDis += "<td class=\"product-thumbnail\">";
            coolDis += "<div class=\"pro-thumbnail-img\">";
            coolDis += "<img src=" + cool3.Product_Img + " alt=>";
            coolDis += "</div>";
            coolDis += "<div class=\"pro-thumbnail-info text-left\">";
            coolDis += "<h6 class=\"product-title-2\">";
            coolDis += "<a href=ProductPage.aspx?ID=" + cool3.Product_Id + ">" + cool3.Product_Name + "</a>";
            coolDis += "</h6>";
            coolDis += "<p>Brand: " + cool3.Product_Brand + "</p>";
            coolDis += "</div>";
            coolDis += "</td>";
            coolDis += "<td class=\"product-price\">" + cool3.Product_Price + "</td>";
            coolDis += "<td class=product-remove>";
            coolDis += "<a href=SelectItem.aspx?ID=" + cool3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            coolDis += "</td>";
            coolDis += "</tr>";


            coolDis += "</tbody>";
            coolDis += "</table>";

            coolDiv.InnerHtml = coolDis;

            string gpuDis = "";

            gpuDis += "<table class=text-center>";
            gpuDis += "<thead>";
            gpuDis += "<tr>";
            gpuDis += "<th class=product-thumbnail>product</th>";
            gpuDis += "<th class=product-price>price</th>";
            gpuDis += "<th class=product-remove>select</th>";
            gpuDis += "</tr>";
            gpuDis += "</thead>";
            gpuDis += "<tbody>";

            var gpu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(gpuBud - differential / 2))
                        select b).FirstOrDefault();


            gpuDis += "<tr>";
            gpuDis += "<td class=\"product-thumbnail\">";
            gpuDis += "<div class=\"pro-thumbnail-img\">";
            gpuDis += "<img src=" + gpu1.Product_Img + " alt=>";
            gpuDis += "</div>";
            gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            gpuDis += "<h6 class=\"product-title-2\">";
            gpuDis += "<a href=ProductPage.aspx?ID=" + gpu1.Product_Id + ">" + gpu1.Product_Name + "</a>";
            gpuDis += "</h6>";
            gpuDis += "<p>Brand: " + gpu1.Product_Brand + "</p>";
            gpuDis += "</div>";
            gpuDis += "</td>";
            gpuDis += "<td class=\"product-price\">" + gpu1.Product_Price + "</td>";
            gpuDis += "<td class=product-remove>";
            gpuDis += "<a href=SelectItem.aspx?ID=" + gpu1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            gpuDis += "</td>";
            gpuDis += "</tr>";


            var gpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential / 2))
                        select b).FirstOrDefault();

            gpuDis += "<tr>";
            gpuDis += "<td class=\"product-thumbnail\">";
            gpuDis += "<div class=\"pro-thumbnail-img\">";
            gpuDis += "<img src=" + gpu2.Product_Img + " alt=>";
            gpuDis += "</div>";
            gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            gpuDis += "<h6 class=\"product-title-2\">";
            gpuDis += "<a href=ProductPage.aspx?ID=" + gpu2.Product_Id + ">" + gpu2.Product_Name + "</a>";
            gpuDis += "</h6>";
            gpuDis += "<p>Brand: " + gpu2.Product_Brand + "</p>";
            gpuDis += "</div>";
            gpuDis += "</td>";
            gpuDis += "<td class=\"product-price\">" + gpu2.Product_Price + "</td>";
            gpuDis += "<td class=product-remove>";
            gpuDis += "<a href=SelectItem.aspx?ID=" + gpu2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            gpuDis += "</td>";
            gpuDis += "</tr>";

            var gpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential))
                        select b).FirstOrDefault();

            gpuDis += "<tr>";
            gpuDis += "<td class=\"product-thumbnail\">";
            gpuDis += "<div class=\"pro-thumbnail-img\">";
            gpuDis += "<img src=" + gpu3.Product_Img + " alt=>";
            gpuDis += "</div>";
            gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            gpuDis += "<h6 class=\"product-title-2\">";
            gpuDis += "<a href=ProductPage.aspx?ID=" + gpu3.Product_Id + ">" + gpu3.Product_Name + "</a>";
            gpuDis += "</h6>";
            gpuDis += "<p>Brand: " + gpu3.Product_Brand + "</p>";
            gpuDis += "</div>";
            gpuDis += "</td>";
            gpuDis += "<td class=\"product-price\">" + gpu3.Product_Price + "</td>";
            gpuDis += "<td class=product-remove>";
            gpuDis += "<a href=SelectItem.aspx?ID=" + gpu3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            gpuDis += "</td>";
            gpuDis += "</tr>";


            gpuDis += "</tbody>";
            gpuDis += "</table>";

            gpuDiv.InnerHtml = gpuDis;

            string memDis = "";

            memDis += "<table class=text-center>";
            memDis += "<thead>";
            memDis += "<tr>";
            memDis += "<th class=product-thumbnail>product</th>";
            memDis += "<th class=product-price>price</th>";
            memDis += "<th class=product-remove>select</th>";
            memDis += "</tr>";
            memDis += "</thead>";
            memDis += "<tbody>";

            var mem1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential)) && b.Product_Price <= (Convert.ToDecimal(ramBud - differential / 2))
                        select b).FirstOrDefault();


            memDis += "<tr>";
            memDis += "<td class=\"product-thumbnail\">";
            memDis += "<div class=\"pro-thumbnail-img\">";
            memDis += "<img src=" + mem1.Product_Img + " alt=>";
            memDis += "</div>";
            memDis += "<div class=\"pro-thumbnail-info text-left\">";
            memDis += "<h6 class=\"product-title-2\">";
            memDis += "<a href=ProductPage.aspx?ID=" + mem1.Product_Id + ">" + mem1.Product_Name + "</a>";
            memDis += "</h6>";
            memDis += "<p>Brand: " + mem1.Product_Brand + "</p>";
            memDis += "</div>";
            memDis += "</td>";
            memDis += "<td class=\"product-price\">" + mem1.Product_Price + "</td>";
            memDis += "<td class=product-remove>";
            memDis += "<a href=SelectItem.aspx?ID=" + mem1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            memDis += "</td>";
            memDis += "</tr>";


            var mem2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential / 2))
                        select b).FirstOrDefault();

            memDis += "<tr>";
            memDis += "<td class=\"product-thumbnail\">";
            memDis += "<div class=\"pro-thumbnail-img\">";
            memDis += "<img src=" + mem2.Product_Img + " alt=>";
            memDis += "</div>";
            memDis += "<div class=\"pro-thumbnail-info text-left\">";
            memDis += "<h6 class=\"product-title-2\">";
            memDis += "<a href=ProductPage.aspx?ID=" + mem2.Product_Id + ">" + mem2.Product_Name + "</a>";
            memDis += "</h6>";
            memDis += "<p>Brand: " + mem2.Product_Brand + "</p>";
            memDis += "</div>";
            memDis += "</td>";
            memDis += "<td class=\"product-price\">" + mem2.Product_Price + "</td>";
            memDis += "<td class=product-remove>";
            memDis += "<a href=SelectItem.aspx?ID=" + mem2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            memDis += "</td>";
            memDis += "</tr>";

            var mem3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential))
                        select b).FirstOrDefault();

            memDis += "<tr>";
            memDis += "<td class=\"product-thumbnail\">";
            memDis += "<div class=\"pro-thumbnail-img\">";
            memDis += "<img src=" + mem3.Product_Img + " alt=>";
            memDis += "</div>";
            memDis += "<div class=\"pro-thumbnail-info text-left\">";
            memDis += "<h6 class=\"product-title-2\">";
            memDis += "<a href=ProductPage.aspx?ID=" + mem3.Product_Id + ">" + mem3.Product_Name + "</a>";
            memDis += "</h6>";
            memDis += "<p>Brand: " + mem3.Product_Brand + "</p>";
            memDis += "</div>";
            memDis += "</td>";
            memDis += "<td class=\"product-price\">" + mem3.Product_Price + "</td>";
            memDis += "<td class=product-remove>";
            memDis += "<a href=SelectItem.aspx?ID=" + mem3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            memDis += "</td>";
            memDis += "</tr>";


            memDis += "</tbody>";
            memDis += "</table>";

            memDiv.InnerHtml = memDis;

            string hardDis = "";

            hardDis += "<table class=text-center>";
            hardDis += "<thead>";
            hardDis += "<tr>";
            hardDis += "<th class=product-thumbnail>product</th>";
            hardDis += "<th class=product-price>price</th>";
            hardDis += "<th class=product-remove>select</th>";
            hardDis += "</tr>";
            hardDis += "</thead>";
            hardDis += "<tbody>";

            var hard1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud - differential)) && b.Product_Price <= (Convert.ToDecimal(hardBud - differential / 2))
                         select b).FirstOrDefault();


            hardDis += "<tr>";
            hardDis += "<td class=\"product-thumbnail\">";
            hardDis += "<div class=\"pro-thumbnail-img\">";
            hardDis += "<img src=" + hard1.Product_Img + " alt=>";
            hardDis += "</div>";
            hardDis += "<div class=\"pro-thumbnail-info text-left\">";
            hardDis += "<h6 class=\"product-title-2\">";
            hardDis += "<a href=ProductPage.aspx?ID=" + hard1.Product_Id + ">" + hard1.Product_Name + "</a>";
            hardDis += "</h6>";
            hardDis += "<p>Brand: " + hard1.Product_Brand + "</p>";
            hardDis += "</div>";
            hardDis += "</td>";
            hardDis += "<td class=\"product-price\">" + hard1.Product_Price + "</td>";
            hardDis += "<td class=product-remove>";
            hardDis += "<a href=SelectItem.aspx?ID=" + hard1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            hardDis += "</td>";
            hardDis += "</tr>";


            var hard2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential / 2))
                         select b).FirstOrDefault();

            hardDis += "<tr>";
            hardDis += "<td class=\"product-thumbnail\">";
            hardDis += "<div class=\"pro-thumbnail-img\">";
            hardDis += "<img src=" + hard2.Product_Img + " alt=>";
            hardDis += "</div>";
            hardDis += "<div class=\"pro-thumbnail-info text-left\">";
            hardDis += "<h6 class=\"product-title-2\">";
            hardDis += "<a href=ProductPage.aspx?ID=" + hard2.Product_Id + ">" + hard2.Product_Name + "</a>";
            hardDis += "</h6>";
            hardDis += "<p>Brand: " + hard2.Product_Brand + "</p>";
            hardDis += "</div>";
            hardDis += "</td>";
            hardDis += "<td class=\"product-price\">" + hard2.Product_Price + "</td>";
            hardDis += "<td class=product-remove>";
            hardDis += "<a href=SelectItem.aspx?ID=" + hard2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            hardDis += "</td>";
            hardDis += "</tr>";

            var hard3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential))
                         select b).FirstOrDefault();

            hardDis += "<tr>";
            hardDis += "<td class=\"product-thumbnail\">";
            hardDis += "<div class=\"pro-thumbnail-img\">";
            hardDis += "<img src=" + hard3.Product_Img + " alt=>";
            hardDis += "</div>";
            hardDis += "<div class=\"pro-thumbnail-info text-left\">";
            hardDis += "<h6 class=\"product-title-2\">";
            hardDis += "<a href=ProductPage.aspx?ID=" + hard3.Product_Id + ">" + hard3.Product_Name + "</a>";
            hardDis += "</h6>";
            hardDis += "<p>Brand: " + hard3.Product_Brand + "</p>";
            hardDis += "</div>";
            hardDis += "</td>";
            hardDis += "<td class=\"product-price\">" + hard3.Product_Price + "</td>";
            hardDis += "<td class=product-remove>";
            hardDis += "<a href=SelectItem.aspx?ID=" + hard3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            hardDis += "</td>";
            hardDis += "</tr>";


            hardDis += "</tbody>";
            hardDis += "</table>";

            hardDiv.InnerHtml = hardDis;

            string psuDis = "";

            psuDis += "<table class=text-center>";
            psuDis += "<thead>";
            psuDis += "<tr>";
            psuDis += "<th class=product-thumbnail>product</th>";
            psuDis += "<th class=product-price>price</th>";
            psuDis += "<th class=product-remove>select</th>";
            psuDis += "</tr>";
            psuDis += "</thead>";
            psuDis += "<tbody>";

            var psu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(psuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(psuBud - differential / 2))
                        select b).FirstOrDefault();


            psuDis += "<tr>";
            psuDis += "<td class=\"product-thumbnail\">";
            psuDis += "<div class=\"pro-thumbnail-img\">";
            psuDis += "<img src=" + psu1.Product_Img + " alt=>";
            psuDis += "</div>";
            psuDis += "<div class=\"pro-thumbnail-info text-left\">";
            psuDis += "<h6 class=\"product-title-2\">";
            psuDis += "<a href=ProductPage.aspx?ID=" + psu1.Product_Id + ">" + psu1.Product_Name + "</a>";
            psuDis += "</h6>";
            psuDis += "<p>Brand: " + psu1.Product_Brand + "</p>";
            psuDis += "</div>";
            psuDis += "</td>";
            psuDis += "<td class=\"product-price\">" + psu1.Product_Price + "</td>";
            psuDis += "<td class=product-remove>";
            psuDis += "<a href=SelectItem.aspx?ID=" + psu1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            psuDis += "</td>";
            psuDis += "</tr>";


            var psu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(psuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential / 2))
                        select b).FirstOrDefault();

            psuDis += "<tr>";
            psuDis += "<td class=\"product-thumbnail\">";
            psuDis += "<div class=\"pro-thumbnail-img\">";
            psuDis += "<img src=" + psu2.Product_Img + " alt=>";
            psuDis += "</div>";
            psuDis += "<div class=\"pro-thumbnail-info text-left\">";
            psuDis += "<h6 class=\"product-title-2\">";
            psuDis += "<a href=ProductPage.aspx?ID=" + psu2.Product_Id + ">" + psu2.Product_Name + "</a>";
            psuDis += "</h6>";
            psuDis += "<p>Brand: " + psu2.Product_Brand + "</p>";
            psuDis += "</div>";
            psuDis += "</td>";
            psuDis += "<td class=\"product-price\">" + psu2.Product_Price + "</td>";
            psuDis += "<td class=product-remove>";
            psuDis += "<a href=SelectItem.aspx?ID=" + psu2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            psuDis += "</td>";
            psuDis += "</tr>";

            var psu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(psuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential))
                        select b).FirstOrDefault();

            psuDis += "<tr>";
            psuDis += "<td class=\"product-thumbnail\">";
            psuDis += "<div class=\"pro-thumbnail-img\">";
            psuDis += "<img src=" + psu3.Product_Img + " alt=>";
            psuDis += "</div>";
            psuDis += "<div class=\"pro-thumbnail-info text-left\">";
            psuDis += "<h6 class=\"product-title-2\">";
            psuDis += "<a href=ProductPage.aspx?ID=" + psu3.Product_Id + ">" + psu3.Product_Name + "</a>";
            psuDis += "</h6>";
            psuDis += "<p>Brand: " + psu3.Product_Brand + "</p>";
            psuDis += "</div>";
            psuDis += "</td>";
            psuDis += "<td class=\"product-price\">" + psu3.Product_Price + "</td>";
            psuDis += "<td class=product-remove>";
            psuDis += "<a href=SelectItem.aspx?ID=" + psu3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            psuDis += "</td>";
            psuDis += "</tr>";


            psuDis += "</tbody>";
            psuDis += "</table>";

            psuDiv.InnerHtml = psuDis;

            string caseDis = "";

            caseDis += "<table class=text-center>";
            caseDis += "<thead>";
            caseDis += "<tr>";
            caseDis += "<th class=product-thumbnail>product</th>";
            caseDis += "<th class=product-price>price</th>";
            caseDis += "<th class=product-remove>select</th>";
            caseDis += "</tr>";
            caseDis += "</thead>";
            caseDis += "<tbody>";

            var case1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud - differential)) && b.Product_Price <= (Convert.ToDecimal(caseBud - differential / 2))
                         select b).FirstOrDefault();


            caseDis += "<tr>";
            caseDis += "<td class=\"product-thumbnail\">";
            caseDis += "<div class=\"pro-thumbnail-img\">";
            caseDis += "<img src=" + case1.Product_Img + " alt=>";
            caseDis += "</div>";
            caseDis += "<div class=\"pro-thumbnail-info text-left\">";
            caseDis += "<h6 class=\"product-title-2\">";
            caseDis += "<a href=ProductPage.aspx?ID=" + case1.Product_Id + ">" + case1.Product_Name + "</a>";
            caseDis += "</h6>";
            caseDis += "<p>Brand: " + case1.Product_Brand + "</p>";
            caseDis += "</div>";
            caseDis += "</td>";
            caseDis += "<td class=\"product-price\">" + case1.Product_Price + "</td>";
            caseDis += "<td class=product-remove>";
            caseDis += "<a href=SelectItem.aspx?ID=" + case1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            caseDis += "</td>";
            caseDis += "</tr>";


            var case2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential / 2))
                         select b).FirstOrDefault();

            caseDis += "<tr>";
            caseDis += "<td class=\"product-thumbnail\">";
            caseDis += "<div class=\"pro-thumbnail-img\">";
            caseDis += "<img src=" + case2.Product_Img + " alt=>";
            caseDis += "</div>";
            caseDis += "<div class=\"pro-thumbnail-info text-left\">";
            caseDis += "<h6 class=\"product-title-2\">";
            caseDis += "<a href=ProductPage.aspx?ID=" + case2.Product_Id + ">" + case2.Product_Name + "</a>";
            caseDis += "</h6>";
            caseDis += "<p>Brand: " + case2.Product_Brand + "</p>";
            caseDis += "</div>";
            caseDis += "</td>";
            caseDis += "<td class=\"product-price\">" + case2.Product_Price + "</td>";
            caseDis += "<td class=product-remove>";
            caseDis += "<a href=SelectItem.aspx?ID=" + case2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            caseDis += "</td>";
            caseDis += "</tr>";

            var case3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential))
                         select b).FirstOrDefault();

            caseDis += "<tr>";
            caseDis += "<td class=\"product-thumbnail\">";
            caseDis += "<div class=\"pro-thumbnail-img\">";
            caseDis += "<img src=" + case3.Product_Img + " alt=>";
            caseDis += "</div>";
            caseDis += "<div class=\"pro-thumbnail-info text-left\">";
            caseDis += "<h6 class=\"product-title-2\">";
            caseDis += "<a href=ProductPage.aspx?ID=" + case3.Product_Id + ">" + case3.Product_Name + "</a>";
            caseDis += "</h6>";
            caseDis += "<p>Brand: " + case3.Product_Brand + "</p>";
            caseDis += "</div>";
            caseDis += "</td>";
            caseDis += "<td class=\"product-price\">" + case3.Product_Price + "</td>";
            caseDis += "<td class=product-remove>";
            caseDis += "<a href=SelectItem.aspx?ID=" + case3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            caseDis += "</td>";
            caseDis += "</tr>";


            caseDis += "</tbody>";
            caseDis += "</table>";

            caseDiv.InnerHtml = caseDis;
        }

        protected void general_Click(object sender, EventArgs e)
        {
            cpuPer = 0.25;
            gpuPer = 0.25;
            chosen = true;
            string cpuDis = "";

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
            var differential = bud * 0.05;

            cpuDis += "<table class=text-center>";
            cpuDis += "<thead>";
            cpuDis += "<tr>";
            cpuDis += "<th class=product-thumbnail>product</th>";
            cpuDis += "<th class=product-price>price</th>";
            cpuDis += "<th class=product-remove>select</th>";
            cpuDis += "</tr>";
            cpuDis += "</thead>";
            cpuDis += "<tbody>";

            var cpu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(cpuBud - differential / 2))
                        select b).FirstOrDefault();


            cpuDis += "<tr>";
            cpuDis += "<td class=\"product-thumbnail\">";
            cpuDis += "<div class=\"pro-thumbnail-img\">";
            cpuDis += "<img src=" + cpu1.Product_Img + " alt=>";
            cpuDis += "</div>";
            cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            cpuDis += "<h6 class=\"product-title-2\">";
            cpuDis += "<a href=ProductPage.aspx?ID=" + cpu1.Product_Id + ">" + cpu1.Product_Name + "</a>";
            cpuDis += "</h6>";
            cpuDis += "<p>Brand: " + cpu1.Product_Brand + "</p>";
            cpuDis += "</div>";
            cpuDis += "</td>";
            cpuDis += "<td class=\"product-price\">" + cpu1.Product_Price + "</td>";
            cpuDis += "<td class=product-remove>";
            cpuDis += "<a href=SelectItem.aspx?ID=" + cpu1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            cpuDis += "</td>";
            cpuDis += "</tr>";


            var cpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential / 2))
                        select b).FirstOrDefault();

            cpuDis += "<tr>";
            cpuDis += "<td class=\"product-thumbnail\">";
            cpuDis += "<div class=\"pro-thumbnail-img\">";
            cpuDis += "<img src=" + cpu2.Product_Img + " alt=>";
            cpuDis += "</div>";
            cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            cpuDis += "<h6 class=\"product-title-2\">";
            cpuDis += "<a href=ProductPage.aspx?ID=" + cpu2.Product_Id + ">" + cpu2.Product_Name + "</a>";
            cpuDis += "</h6>";
            cpuDis += "<p>Brand: " + cpu2.Product_Brand + "</p>";
            cpuDis += "</div>";
            cpuDis += "</td>";
            cpuDis += "<td class=\"product-price\">" + cpu2.Product_Price + "</td>";
            cpuDis += "<td class=product-remove>";
            cpuDis += "<a href=SelectItem.aspx?ID=" + cpu2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            cpuDis += "</td>";
            cpuDis += "</tr>";

            var cpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential))
                        select b).FirstOrDefault();

            cpuDis += "<tr>";
            cpuDis += "<td class=\"product-thumbnail\">";
            cpuDis += "<div class=\"pro-thumbnail-img\">";
            cpuDis += "<img src=" + cpu3.Product_Img + " alt=>";
            cpuDis += "</div>";
            cpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            cpuDis += "<h6 class=\"product-title-2\">";
            cpuDis += "<a href=ProductPage.aspx?ID=" + cpu3.Product_Id + ">" + cpu3.Product_Name + "</a>";
            cpuDis += "</h6>";
            cpuDis += "<p>Brand: " + cpu3.Product_Brand + "</p>";
            cpuDis += "</div>";
            cpuDis += "</td>";
            cpuDis += "<td class=\"product-price\">" + cpu3.Product_Price + "</td>";
            cpuDis += "<td class=product-remove>";
            cpuDis += "<a href=SelectItem.aspx?ID=" + cpu3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            cpuDis += "</td>";
            cpuDis += "</tr>";


            cpuDis += "</tbody>";
            cpuDis += "</table>";

            cpuDiv.InnerHtml = cpuDis;
            preferences.Attributes.Remove("class");
            preferences.Attributes.Add("class", "tab-pane");
            cpuBut.Attributes.Add("class", "active");
            cpu.Attributes.Remove("class");
            cpu.Attributes.Add("class", "tab-pane active");

            string moboDis = "";

            moboDis += "<table class=text-center>";
            moboDis += "<thead>";
            moboDis += "<tr>";
            moboDis += "<th class=product-thumbnail>product</th>";
            moboDis += "<th class=product-price>price</th>";
            moboDis += "<th class=product-remove>select</th>";
            moboDis += "</tr>";
            moboDis += "</thead>";
            moboDis += "<tbody>";

            var mobo1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud - differential)) && b.Product_Price <= (Convert.ToDecimal(moboBud - differential / 2))
                         select b).FirstOrDefault();


            moboDis += "<tr>";
            moboDis += "<td class=\"product-thumbnail\">";
            moboDis += "<div class=\"pro-thumbnail-img\">";
            moboDis += "<img src=" + mobo1.Product_Img + " alt=>";
            moboDis += "</div>";
            moboDis += "<div class=\"pro-thumbnail-info text-left\">";
            moboDis += "<h6 class=\"product-title-2\">";
            moboDis += "<a href=ProductPage.aspx?ID=" + mobo1.Product_Id + ">" + mobo1.Product_Name + "</a>";
            moboDis += "</h6>";
            moboDis += "<p>Brand: " + mobo1.Product_Brand + "</p>";
            moboDis += "</div>";
            moboDis += "</td>";
            moboDis += "<td class=\"product-price\">" + mobo1.Product_Price + "</td>";
            moboDis += "<td class=product-remove>";
            moboDis += "<a href=SelectItem.aspx?ID=" + mobo1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            moboDis += "</td>";
            moboDis += "</tr>";


            var mobo2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential / 2))
                         select b).FirstOrDefault();

            moboDis += "<tr>";
            moboDis += "<td class=\"product-thumbnail\">";
            moboDis += "<div class=\"pro-thumbnail-img\">";
            moboDis += "<img src=" + mobo2.Product_Img + " alt=>";
            moboDis += "</div>";
            moboDis += "<div class=\"pro-thumbnail-info text-left\">";
            moboDis += "<h6 class=\"product-title-2\">";
            moboDis += "<a href=ProductPage.aspx?ID=" + mobo2.Product_Id + ">" + mobo2.Product_Name + "</a>";
            moboDis += "</h6>";
            moboDis += "<p>Brand: " + mobo2.Product_Brand + "</p>";
            moboDis += "</div>";
            moboDis += "</td>";
            moboDis += "<td class=\"product-price\">" + mobo2.Product_Price + "</td>";
            moboDis += "<td class=product-remove>";
            moboDis += "<a href=SelectItem.aspx?ID=" + mobo2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            moboDis += "</td>";
            moboDis += "</tr>";

            var mobo3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Motherboard")
                         where b.Product_Price >= (Convert.ToDecimal(moboBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential))
                         select b).FirstOrDefault();

            moboDis += "<tr>";
            moboDis += "<td class=\"product-thumbnail\">";
            moboDis += "<div class=\"pro-thumbnail-img\">";
            moboDis += "<img src=" + mobo3.Product_Img + " alt=>";
            moboDis += "</div>";
            moboDis += "<div class=\"pro-thumbnail-info text-left\">";
            moboDis += "<h6 class=\"product-title-2\">";
            moboDis += "<a href=ProductPage.aspx?ID=" + mobo3.Product_Id + ">" + mobo3.Product_Name + "</a>";
            moboDis += "</h6>";
            moboDis += "<p>Brand: " + mobo3.Product_Brand + "</p>";
            moboDis += "</div>";
            moboDis += "</td>";
            moboDis += "<td class=\"product-price\">" + mobo3.Product_Price + "</td>";
            moboDis += "<td class=product-remove>";
            moboDis += "<a href=SelectItem.aspx?ID=" + mobo3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            moboDis += "</td>";
            moboDis += "</tr>";


            moboDis += "</tbody>";
            moboDis += "</table>";

            moboDiv.InnerHtml = moboDis;

            string coolDis = "";

            coolDis += "<table class=text-center>";
            coolDis += "<thead>";
            coolDis += "<tr>";
            coolDis += "<th class=product-thumbnail>product</th>";
            coolDis += "<th class=product-price>price</th>";
            coolDis += "<th class=product-remove>select</th>";
            coolDis += "</tr>";
            coolDis += "</thead>";
            coolDis += "<tbody>";

            var cool1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential)) && b.Product_Price <= (Convert.ToDecimal(coolBud - differential / 2))
                         select b).FirstOrDefault();


            coolDis += "<tr>";
            coolDis += "<td class=\"product-thumbnail\">";
            coolDis += "<div class=\"pro-thumbnail-img\">";
            coolDis += "<img src=" + cool1.Product_Img + " alt=>";
            coolDis += "</div>";
            coolDis += "<div class=\"pro-thumbnail-info text-left\">";
            coolDis += "<h6 class=\"product-title-2\">";
            coolDis += "<a href=ProductPage.aspx?ID=" + cool1.Product_Id + ">" + cool1.Product_Name + "</a>";
            coolDis += "</h6>";
            coolDis += "<p>Brand: " + cool1.Product_Brand + "</p>";
            coolDis += "</div>";
            coolDis += "</td>";
            coolDis += "<td class=\"product-price\">" + cool1.Product_Price + "</td>";
            coolDis += "<td class=product-remove>";
            coolDis += "<a href=SelectItem.aspx?ID=" + cool1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            coolDis += "</td>";
            coolDis += "</tr>";


            var cool2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential / 2))
                         select b).FirstOrDefault();

            coolDis += "<tr>";
            coolDis += "<td class=\"product-thumbnail\">";
            coolDis += "<div class=\"pro-thumbnail-img\">";
            coolDis += "<img src=" + cool2.Product_Img + " alt=>";
            coolDis += "</div>";
            coolDis += "<div class=\"pro-thumbnail-info text-left\">";
            coolDis += "<h6 class=\"product-title-2\">";
            coolDis += "<a href=ProductPage.aspx?ID=" + cool2.Product_Id + ">" + cool2.Product_Name + "</a>";
            coolDis += "</h6>";
            coolDis += "<p>Brand: " + cool2.Product_Brand + "</p>";
            coolDis += "</div>";
            coolDis += "</td>";
            coolDis += "<td class=\"product-price\">" + cool2.Product_Price + "</td>";
            coolDis += "<td class=product-remove>";
            coolDis += "<a href=SelectItem.aspx?ID=" + cool2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            coolDis += "</td>";
            coolDis += "</tr>";

            var cool3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential))
                         select b).FirstOrDefault();

            coolDis += "<tr>";
            coolDis += "<td class=\"product-thumbnail\">";
            coolDis += "<div class=\"pro-thumbnail-img\">";
            coolDis += "<img src=" + cool3.Product_Img + " alt=>";
            coolDis += "</div>";
            coolDis += "<div class=\"pro-thumbnail-info text-left\">";
            coolDis += "<h6 class=\"product-title-2\">";
            coolDis += "<a href=ProductPage.aspx?ID=" + cool3.Product_Id + ">" + cool3.Product_Name + "</a>";
            coolDis += "</h6>";
            coolDis += "<p>Brand: " + cool3.Product_Brand + "</p>";
            coolDis += "</div>";
            coolDis += "</td>";
            coolDis += "<td class=\"product-price\">" + cool3.Product_Price + "</td>";
            coolDis += "<td class=product-remove>";
            coolDis += "<a href=SelectItem.aspx?ID=" + cool3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            coolDis += "</td>";
            coolDis += "</tr>";


            coolDis += "</tbody>";
            coolDis += "</table>";

            coolDiv.InnerHtml = coolDis;

            string gpuDis = "";

            gpuDis += "<table class=text-center>";
            gpuDis += "<thead>";
            gpuDis += "<tr>";
            gpuDis += "<th class=product-thumbnail>product</th>";
            gpuDis += "<th class=product-price>price</th>";
            gpuDis += "<th class=product-remove>select</th>";
            gpuDis += "</tr>";
            gpuDis += "</thead>";
            gpuDis += "<tbody>";

            var gpu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(gpuBud - differential / 2))
                        select b).FirstOrDefault();


            gpuDis += "<tr>";
            gpuDis += "<td class=\"product-thumbnail\">";
            gpuDis += "<div class=\"pro-thumbnail-img\">";
            gpuDis += "<img src=" + gpu1.Product_Img + " alt=>";
            gpuDis += "</div>";
            gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            gpuDis += "<h6 class=\"product-title-2\">";
            gpuDis += "<a href=ProductPage.aspx?ID=" + gpu1.Product_Id + ">" + gpu1.Product_Name + "</a>";
            gpuDis += "</h6>";
            gpuDis += "<p>Brand: " + gpu1.Product_Brand + "</p>";
            gpuDis += "</div>";
            gpuDis += "</td>";
            gpuDis += "<td class=\"product-price\">" + gpu1.Product_Price + "</td>";
            gpuDis += "<td class=product-remove>";
            gpuDis += "<a href=SelectItem.aspx?ID=" + gpu1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            gpuDis += "</td>";
            gpuDis += "</tr>";


            var gpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential / 2))
                        select b).FirstOrDefault();

            gpuDis += "<tr>";
            gpuDis += "<td class=\"product-thumbnail\">";
            gpuDis += "<div class=\"pro-thumbnail-img\">";
            gpuDis += "<img src=" + gpu2.Product_Img + " alt=>";
            gpuDis += "</div>";
            gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            gpuDis += "<h6 class=\"product-title-2\">";
            gpuDis += "<a href=ProductPage.aspx?ID=" + gpu2.Product_Id + ">" + gpu2.Product_Name + "</a>";
            gpuDis += "</h6>";
            gpuDis += "<p>Brand: " + gpu2.Product_Brand + "</p>";
            gpuDis += "</div>";
            gpuDis += "</td>";
            gpuDis += "<td class=\"product-price\">" + gpu2.Product_Price + "</td>";
            gpuDis += "<td class=product-remove>";
            gpuDis += "<a href=SelectItem.aspx?ID=" + gpu2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            gpuDis += "</td>";
            gpuDis += "</tr>";

            var gpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("GPU")
                        where b.Product_Price >= (Convert.ToDecimal(gpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential))
                        select b).FirstOrDefault();

            gpuDis += "<tr>";
            gpuDis += "<td class=\"product-thumbnail\">";
            gpuDis += "<div class=\"pro-thumbnail-img\">";
            gpuDis += "<img src=" + gpu3.Product_Img + " alt=>";
            gpuDis += "</div>";
            gpuDis += "<div class=\"pro-thumbnail-info text-left\">";
            gpuDis += "<h6 class=\"product-title-2\">";
            gpuDis += "<a href=ProductPage.aspx?ID=" + gpu3.Product_Id + ">" + gpu3.Product_Name + "</a>";
            gpuDis += "</h6>";
            gpuDis += "<p>Brand: " + gpu3.Product_Brand + "</p>";
            gpuDis += "</div>";
            gpuDis += "</td>";
            gpuDis += "<td class=\"product-price\">" + gpu3.Product_Price + "</td>";
            gpuDis += "<td class=product-remove>";
            gpuDis += "<a href=SelectItem.aspx?ID=" + gpu3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            gpuDis += "</td>";
            gpuDis += "</tr>";


            gpuDis += "</tbody>";
            gpuDis += "</table>";

            gpuDiv.InnerHtml = gpuDis;

            string memDis = "";

            memDis += "<table class=text-center>";
            memDis += "<thead>";
            memDis += "<tr>";
            memDis += "<th class=product-thumbnail>product</th>";
            memDis += "<th class=product-price>price</th>";
            memDis += "<th class=product-remove>select</th>";
            memDis += "</tr>";
            memDis += "</thead>";
            memDis += "<tbody>";

            var mem1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential)) && b.Product_Price <= (Convert.ToDecimal(ramBud - differential / 2))
                        select b).FirstOrDefault();


            memDis += "<tr>";
            memDis += "<td class=\"product-thumbnail\">";
            memDis += "<div class=\"pro-thumbnail-img\">";
            memDis += "<img src=" + mem1.Product_Img + " alt=>";
            memDis += "</div>";
            memDis += "<div class=\"pro-thumbnail-info text-left\">";
            memDis += "<h6 class=\"product-title-2\">";
            memDis += "<a href=ProductPage.aspx?ID=" + mem1.Product_Id + ">" + mem1.Product_Name + "</a>";
            memDis += "</h6>";
            memDis += "<p>Brand: " + mem1.Product_Brand + "</p>";
            memDis += "</div>";
            memDis += "</td>";
            memDis += "<td class=\"product-price\">" + mem1.Product_Price + "</td>";
            memDis += "<td class=product-remove>";
            memDis += "<a href=SelectItem.aspx?ID=" + mem1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            memDis += "</td>";
            memDis += "</tr>";


            var mem2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential / 2))
                        select b).FirstOrDefault();

            memDis += "<tr>";
            memDis += "<td class=\"product-thumbnail\">";
            memDis += "<div class=\"pro-thumbnail-img\">";
            memDis += "<img src=" + mem2.Product_Img + " alt=>";
            memDis += "</div>";
            memDis += "<div class=\"pro-thumbnail-info text-left\">";
            memDis += "<h6 class=\"product-title-2\">";
            memDis += "<a href=ProductPage.aspx?ID=" + mem2.Product_Id + ">" + mem2.Product_Name + "</a>";
            memDis += "</h6>";
            memDis += "<p>Brand: " + mem2.Product_Brand + "</p>";
            memDis += "</div>";
            memDis += "</td>";
            memDis += "<td class=\"product-price\">" + mem2.Product_Price + "</td>";
            memDis += "<td class=product-remove>";
            memDis += "<a href=SelectItem.aspx?ID=" + mem2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            memDis += "</td>";
            memDis += "</tr>";

            var mem3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential))
                        select b).FirstOrDefault();

            memDis += "<tr>";
            memDis += "<td class=\"product-thumbnail\">";
            memDis += "<div class=\"pro-thumbnail-img\">";
            memDis += "<img src=" + mem3.Product_Img + " alt=>";
            memDis += "</div>";
            memDis += "<div class=\"pro-thumbnail-info text-left\">";
            memDis += "<h6 class=\"product-title-2\">";
            memDis += "<a href=ProductPage.aspx?ID=" + mem3.Product_Id + ">" + mem3.Product_Name + "</a>";
            memDis += "</h6>";
            memDis += "<p>Brand: " + mem3.Product_Brand + "</p>";
            memDis += "</div>";
            memDis += "</td>";
            memDis += "<td class=\"product-price\">" + mem3.Product_Price + "</td>";
            memDis += "<td class=product-remove>";
            memDis += "<a href=SelectItem.aspx?ID=" + mem3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            memDis += "</td>";
            memDis += "</tr>";


            memDis += "</tbody>";
            memDis += "</table>";

            memDiv.InnerHtml = memDis;

            string hardDis = "";

            hardDis += "<table class=text-center>";
            hardDis += "<thead>";
            hardDis += "<tr>";
            hardDis += "<th class=product-thumbnail>product</th>";
            hardDis += "<th class=product-price>price</th>";
            hardDis += "<th class=product-remove>select</th>";
            hardDis += "</tr>";
            hardDis += "</thead>";
            hardDis += "<tbody>";

            var hard1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud - differential)) && b.Product_Price <= (Convert.ToDecimal(hardBud - differential / 2))
                         select b).FirstOrDefault();


            hardDis += "<tr>";
            hardDis += "<td class=\"product-thumbnail\">";
            hardDis += "<div class=\"pro-thumbnail-img\">";
            hardDis += "<img src=" + hard1.Product_Img + " alt=>";
            hardDis += "</div>";
            hardDis += "<div class=\"pro-thumbnail-info text-left\">";
            hardDis += "<h6 class=\"product-title-2\">";
            hardDis += "<a href=ProductPage.aspx?ID=" + hard1.Product_Id + ">" + hard1.Product_Name + "</a>";
            hardDis += "</h6>";
            hardDis += "<p>Brand: " + hard1.Product_Brand + "</p>";
            hardDis += "</div>";
            hardDis += "</td>";
            hardDis += "<td class=\"product-price\">" + hard1.Product_Price + "</td>";
            hardDis += "<td class=product-remove>";
            hardDis += "<a href=SelectItem.aspx?ID=" + hard1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            hardDis += "</td>";
            hardDis += "</tr>";


            var hard2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential / 2))
                         select b).FirstOrDefault();

            hardDis += "<tr>";
            hardDis += "<td class=\"product-thumbnail\">";
            hardDis += "<div class=\"pro-thumbnail-img\">";
            hardDis += "<img src=" + hard2.Product_Img + " alt=>";
            hardDis += "</div>";
            hardDis += "<div class=\"pro-thumbnail-info text-left\">";
            hardDis += "<h6 class=\"product-title-2\">";
            hardDis += "<a href=ProductPage.aspx?ID=" + hard2.Product_Id + ">" + hard2.Product_Name + "</a>";
            hardDis += "</h6>";
            hardDis += "<p>Brand: " + hard2.Product_Brand + "</p>";
            hardDis += "</div>";
            hardDis += "</td>";
            hardDis += "<td class=\"product-price\">" + hard2.Product_Price + "</td>";
            hardDis += "<td class=product-remove>";
            hardDis += "<a href=SelectItem.aspx?ID=" + hard2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            hardDis += "</td>";
            hardDis += "</tr>";

            var hard3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Hard Drive")
                         where b.Product_Price >= (Convert.ToDecimal(hardBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential))
                         select b).FirstOrDefault();

            hardDis += "<tr>";
            hardDis += "<td class=\"product-thumbnail\">";
            hardDis += "<div class=\"pro-thumbnail-img\">";
            hardDis += "<img src=" + hard3.Product_Img + " alt=>";
            hardDis += "</div>";
            hardDis += "<div class=\"pro-thumbnail-info text-left\">";
            hardDis += "<h6 class=\"product-title-2\">";
            hardDis += "<a href=ProductPage.aspx?ID=" + hard3.Product_Id + ">" + hard3.Product_Name + "</a>";
            hardDis += "</h6>";
            hardDis += "<p>Brand: " + hard3.Product_Brand + "</p>";
            hardDis += "</div>";
            hardDis += "</td>";
            hardDis += "<td class=\"product-price\">" + hard3.Product_Price + "</td>";
            hardDis += "<td class=product-remove>";
            hardDis += "<a href=SelectItem.aspx?ID=" + hard3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            hardDis += "</td>";
            hardDis += "</tr>";


            hardDis += "</tbody>";
            hardDis += "</table>";

            hardDiv.InnerHtml = hardDis;

            string psuDis = "";

            psuDis += "<table class=text-center>";
            psuDis += "<thead>";
            psuDis += "<tr>";
            psuDis += "<th class=product-thumbnail>product</th>";
            psuDis += "<th class=product-price>price</th>";
            psuDis += "<th class=product-remove>select</th>";
            psuDis += "</tr>";
            psuDis += "</thead>";
            psuDis += "<tbody>";

            var psu1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(psuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(psuBud - differential / 2))
                        select b).FirstOrDefault();


            psuDis += "<tr>";
            psuDis += "<td class=\"product-thumbnail\">";
            psuDis += "<div class=\"pro-thumbnail-img\">";
            psuDis += "<img src=" + psu1.Product_Img + " alt=>";
            psuDis += "</div>";
            psuDis += "<div class=\"pro-thumbnail-info text-left\">";
            psuDis += "<h6 class=\"product-title-2\">";
            psuDis += "<a href=ProductPage.aspx?ID=" + psu1.Product_Id + ">" + psu1.Product_Name + "</a>";
            psuDis += "</h6>";
            psuDis += "<p>Brand: " + psu1.Product_Brand + "</p>";
            psuDis += "</div>";
            psuDis += "</td>";
            psuDis += "<td class=\"product-price\">" + psu1.Product_Price + "</td>";
            psuDis += "<td class=product-remove>";
            psuDis += "<a href=SelectItem.aspx?ID=" + psu1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            psuDis += "</td>";
            psuDis += "</tr>";


            var psu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(psuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential / 2))
                        select b).FirstOrDefault();

            psuDis += "<tr>";
            psuDis += "<td class=\"product-thumbnail\">";
            psuDis += "<div class=\"pro-thumbnail-img\">";
            psuDis += "<img src=" + psu2.Product_Img + " alt=>";
            psuDis += "</div>";
            psuDis += "<div class=\"pro-thumbnail-info text-left\">";
            psuDis += "<h6 class=\"product-title-2\">";
            psuDis += "<a href=ProductPage.aspx?ID=" + psu2.Product_Id + ">" + psu2.Product_Name + "</a>";
            psuDis += "</h6>";
            psuDis += "<p>Brand: " + psu2.Product_Brand + "</p>";
            psuDis += "</div>";
            psuDis += "</td>";
            psuDis += "<td class=\"product-price\">" + psu2.Product_Price + "</td>";
            psuDis += "<td class=product-remove>";
            psuDis += "<a href=SelectItem.aspx?ID=" + psu2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            psuDis += "</td>";
            psuDis += "</tr>";

            var psu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("PSU")
                        where b.Product_Price >= (Convert.ToDecimal(psuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential))
                        select b).FirstOrDefault();

            psuDis += "<tr>";
            psuDis += "<td class=\"product-thumbnail\">";
            psuDis += "<div class=\"pro-thumbnail-img\">";
            psuDis += "<img src=" + psu3.Product_Img + " alt=>";
            psuDis += "</div>";
            psuDis += "<div class=\"pro-thumbnail-info text-left\">";
            psuDis += "<h6 class=\"product-title-2\">";
            psuDis += "<a href=ProductPage.aspx?ID=" + psu3.Product_Id + ">" + psu3.Product_Name + "</a>";
            psuDis += "</h6>";
            psuDis += "<p>Brand: " + psu3.Product_Brand + "</p>";
            psuDis += "</div>";
            psuDis += "</td>";
            psuDis += "<td class=\"product-price\">" + psu3.Product_Price + "</td>";
            psuDis += "<td class=product-remove>";
            psuDis += "<a href=SelectItem.aspx?ID=" + psu3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            psuDis += "</td>";
            psuDis += "</tr>";


            psuDis += "</tbody>";
            psuDis += "</table>";

            psuDiv.InnerHtml = psuDis;

            string caseDis = "";

            caseDis += "<table class=text-center>";
            caseDis += "<thead>";
            caseDis += "<tr>";
            caseDis += "<th class=product-thumbnail>product</th>";
            caseDis += "<th class=product-price>price</th>";
            caseDis += "<th class=product-remove>select</th>";
            caseDis += "</tr>";
            caseDis += "</thead>";
            caseDis += "<tbody>";

            var case1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud - differential)) && b.Product_Price <= (Convert.ToDecimal(caseBud - differential / 2))
                         select b).FirstOrDefault();


            caseDis += "<tr>";
            caseDis += "<td class=\"product-thumbnail\">";
            caseDis += "<div class=\"pro-thumbnail-img\">";
            caseDis += "<img src=" + case1.Product_Img + " alt=>";
            caseDis += "</div>";
            caseDis += "<div class=\"pro-thumbnail-info text-left\">";
            caseDis += "<h6 class=\"product-title-2\">";
            caseDis += "<a href=ProductPage.aspx?ID=" + case1.Product_Id + ">" + case1.Product_Name + "</a>";
            caseDis += "</h6>";
            caseDis += "<p>Brand: " + case1.Product_Brand + "</p>";
            caseDis += "</div>";
            caseDis += "</td>";
            caseDis += "<td class=\"product-price\">" + case1.Product_Price + "</td>";
            caseDis += "<td class=product-remove>";
            caseDis += "<a href=SelectItem.aspx?ID=" + case1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            caseDis += "</td>";
            caseDis += "</tr>";


            var case2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential / 2))
                         select b).FirstOrDefault();

            caseDis += "<tr>";
            caseDis += "<td class=\"product-thumbnail\">";
            caseDis += "<div class=\"pro-thumbnail-img\">";
            caseDis += "<img src=" + case2.Product_Img + " alt=>";
            caseDis += "</div>";
            caseDis += "<div class=\"pro-thumbnail-info text-left\">";
            caseDis += "<h6 class=\"product-title-2\">";
            caseDis += "<a href=ProductPage.aspx?ID=" + case2.Product_Id + ">" + case2.Product_Name + "</a>";
            caseDis += "</h6>";
            caseDis += "<p>Brand: " + case2.Product_Brand + "</p>";
            caseDis += "</div>";
            caseDis += "</td>";
            caseDis += "<td class=\"product-price\">" + case2.Product_Price + "</td>";
            caseDis += "<td class=product-remove>";
            caseDis += "<a href=SelectItem.aspx?ID=" + case2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            caseDis += "</td>";
            caseDis += "</tr>";

            var case3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Case")
                         where b.Product_Price >= (Convert.ToDecimal(caseBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential))
                         select b).FirstOrDefault();

            caseDis += "<tr>";
            caseDis += "<td class=\"product-thumbnail\">";
            caseDis += "<div class=\"pro-thumbnail-img\">";
            caseDis += "<img src=" + case3.Product_Img + " alt=>";
            caseDis += "</div>";
            caseDis += "<div class=\"pro-thumbnail-info text-left\">";
            caseDis += "<h6 class=\"product-title-2\">";
            caseDis += "<a href=ProductPage.aspx?ID=" + case3.Product_Id + ">" + case3.Product_Name + "</a>";
            caseDis += "</h6>";
            caseDis += "<p>Brand: " + case3.Product_Brand + "</p>";
            caseDis += "</div>";
            caseDis += "</td>";
            caseDis += "<td class=\"product-price\">" + case3.Product_Price + "</td>";
            caseDis += "<td class=product-remove>";
            caseDis += "<a href=SelectItem.aspx?ID=" + case3.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
            caseDis += "</td>";
            caseDis += "</tr>";


            caseDis += "</tbody>";
            caseDis += "</table>";

            caseDiv.InnerHtml = caseDis;
        }
    }
}
