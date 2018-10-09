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
            cpuDis += "<a href=SelectItem.aspx?ID=" + cpu1.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";     
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
            cpuDis += "<a href=SelectItem.aspx?ID=" + cpu2.Product_Id + "><i class=\"zmdi zmdi-close\"></i></a>";
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
        }

        protected void gaming1_Click(object sender, EventArgs e)
        {
            cpuPer = 0.2;
            gpuPer = 0.3;
            chosen = true;

        }

        protected void general_Click(object sender, EventArgs e)
        {
            cpuPer = 0.25;
            gpuPer = 0.25;
            chosen = true;
        }
    }
}
