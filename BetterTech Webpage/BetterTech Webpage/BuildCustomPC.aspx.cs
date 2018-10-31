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
        public static double cpuPer{ get; set; }
        public static double gpuPer { get; set; }
        public static double moboPer { get; set; }
        public static double ramPer { get; set; }
        public static double hardPer { get; set; }
        public static double psuPer { get; set; }
        public static double accPer { get; set; }
        public static double casePer { get; set; }
        public static double coolPer { get; set; }
        public static Product cpu1 { get; set; }
        public static Product cpu2 { get; set; }
        public static Product cpu3 { get; set; }
        public static Product mobo1 { get; set; }
        public static Product mobo2 { get; set; }
        public static Product mobo3 { get; set; }
        public static Product cool1 { get; set; }
        public static Product cool2 { get; set; }
        public static Product cool3 { get; set; }
        public static Product mem1 { get; set; }
        public static Product mem2 { get; set; }
        public static Product mem3 { get; set; }
        public static Product hard1 { get; set; }
        public static Product hard2 { get; set; }
        public static Product hard3 { get; set; }
        public static Product psu1 { get; set; }
        public static Product psu2 { get; set; }
        public static Product psu3 { get; set; }
        public static Product case1 { get; set; }
        public static Product case2 { get; set; }
        public static Product case3 { get; set; }
        public static Product gpu1 { get; set; }
        public static Product gpu2 { get; set; }
        public static Product gpu3 { get; set; }
        public static bool chosen { get; set; }
        public static int cpuId { get; set; }
        public static int coolId { get; set; }
        public static int moboId { get; set; }
        public static int gpuId { get; set; }
        public static int memId { get; set; }
        public static int hardId { get; set; }
        public static int psuId { get; set; }
        public static int caseId { get; set; }
        public static int bud { get; set; }
        public static int budA { get; set; }
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

            bud = int.Parse(budget.Value);
            budA = int.Parse(budget.Value);
            budgetCpu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
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
            
            cpu1 = (from Product b in db.Products
                   where b.Product_IsActive.Equals(true)
                   where b.Product_Type.Equals("CPU")
                   where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(cpuBud - differential / 2))
                   select b).FirstOrDefault();
            
            string cpuDis = "";
            if (cpu1 != null)
            {
                cpu1img.InnerHtml = "<img src=" + cpu1.Product_Img + " alt=>";

                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu1.Product_Id + ">Below Budget: " + cpu1.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpu1name.InnerHtml = cpuDis;

                cpu1brand.InnerHtml = "<p>Brand: " + cpu1.Product_Brand + "</p>";

                cpu1price.InnerHtml = Convert.ToString(cpu1.Product_Price);
            }
            else
            {
                cpuDis = "";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</h6>";
                cpu1name.InnerHtml = cpuDis;
            }


            cpu2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential/2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential/2))
                        select b).FirstOrDefault();
            cpuDis = "";
            if (cpu2 != null)
            {
                cpu2img.InnerHtml = "<img src=" + cpu2.Product_Img + " alt=>";

                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu2.Product_Id + ">Below Budget: " + cpu2.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpu2name.InnerHtml = cpuDis;

                cpu2brand.InnerHtml = "<p>Brand: " + cpu2.Product_Brand + "</p>";

                cpu2price.InnerHtml = Convert.ToString(cpu2.Product_Price);
            }
            else
            {
                cpuDis = "";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</h6>";
                cpu2name.InnerHtml = cpuDis;
            }

            cpu3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("CPU")
                        where b.Product_Price >= (Convert.ToDecimal(cpuBud + differential/2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential))
                        select b).FirstOrDefault();

            cpuDis = "";
            if (cpu3 != null)
            {
                cpu3img.InnerHtml = "<img src=" + cpu3.Product_Img + " alt=>";

                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu3.Product_Id + ">Below Budget: " + cpu3.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpu3name.InnerHtml = cpuDis;

                cpu3brand.InnerHtml = "<p>Brand: " + cpu3.Product_Brand + "</p>";

                cpu3price.InnerHtml = Convert.ToString(cpu3.Product_Price);
            }
            else
            {
                cpuDis = "";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</h6>";
                cpu3name.InnerHtml = cpuDis;
            }

            preferences.Attributes.Remove("class");
            preferences.Attributes.Add("class","tab-pane");
            cpuBut.Attributes.Add("class", "active");
            cpu.Attributes.Remove("class");
            cpu.Attributes.Add("class", "tab-pane active");

            mobo1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Motherboard")
                        where b.Product_Price >= (Convert.ToDecimal(moboBud - differential)) && b.Product_Price <= (Convert.ToDecimal(moboBud - differential / 2))
                        select b).FirstOrDefault();

            string moboDis = "";
            if (mobo1 != null)
            {
                mobo1img.InnerHtml = "<img src=" + mobo1.Product_Img + " alt=>";

                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo1.Product_Id + ">Below Budget: " + mobo1.Product_Name + "</a>";
                moboDis += "</h6>";
                mobo1name.InnerHtml = moboDis;

                mobo1brand.InnerHtml = "<p>Brand: " + mobo1.Product_Brand + "</p>";

                mobo1price.InnerHtml = Convert.ToString(mobo1.Product_Price);
            }
            else
            {
                moboDis = "";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</h6>";
                mobo1name.InnerHtml = moboDis;
            }


            mobo2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Motherboard")
                        where b.Product_Price >= (Convert.ToDecimal(moboBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential / 2))
                        select b).FirstOrDefault();

            moboDis = "";
            if (mobo2 != null)
            {
                mobo2img.InnerHtml = "<img src=" + mobo2.Product_Img + " alt=>";

                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo2.Product_Id + ">Below Budget: " + mobo2.Product_Name + "</a>";
                moboDis += "</h6>";
                mobo2name.InnerHtml = moboDis;

                mobo2brand.InnerHtml = "<p>Brand: " + mobo2.Product_Brand + "</p>";

                mobo2price.InnerHtml = Convert.ToString(mobo2.Product_Price);
            }
            else
            {
                moboDis = "";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</h6>";
                mobo2name.InnerHtml = moboDis;
            }

            mobo3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Motherboard")
                        where b.Product_Price >= (Convert.ToDecimal(moboBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential))
                        select b).FirstOrDefault();

            moboDis = "";
            if (mobo3 != null)
            {
                mobo3img.InnerHtml = "<img src=" + mobo3.Product_Img + " alt=>";

                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo3.Product_Id + ">Below Budget: " + mobo3.Product_Name + "</a>";
                moboDis += "</h6>";
                mobo3name.InnerHtml = moboDis;

                mobo3brand.InnerHtml = "<p>Brand: " + mobo3.Product_Brand + "</p>";

                mobo3price.InnerHtml = Convert.ToString(mobo3.Product_Price);
            }
            else
            {
                moboDis = "";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</h6>";
                mobo3name.InnerHtml = moboDis;
            }

            cool1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(coolBud - differential / 4))
                         select b).FirstOrDefault();

            string coolDis = "";
            if (cool1 != null)
            {
                cool1img.InnerHtml = "<img src=" + cool1.Product_Img + " alt=>";

                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool1.Product_Id + ">Below Budget: " + cool1.Product_Name + "</a>";
                coolDis += "</h6>";
                cool1name.InnerHtml = coolDis;

                cool1brand.InnerHtml = "<p>Brand: " + cool1.Product_Brand + "</p>";

                cool1price.InnerHtml = Convert.ToString(cool1.Product_Price);
            }
            else
            {
                coolDis = "";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</h6>";
                cool1name.InnerHtml = coolDis;
            }


            cool2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential / 4))
                         select b).FirstOrDefault();

            coolDis = "";
            if (cool2 != null)
            {
                cool2img.InnerHtml = "<img src=" + cool2.Product_Img + " alt=>";

                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool2.Product_Id + ">Below Budget: " + cool2.Product_Name + "</a>";
                coolDis += "</h6>";
                cool2name.InnerHtml = coolDis;

                cool2brand.InnerHtml = "<p>Brand: " + cool2.Product_Brand + "</p>";

                cool2price.InnerHtml = Convert.ToString(cool2.Product_Price);
            }
            else
            {
                coolDis = "";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</h6>";
                cool2name.InnerHtml = coolDis;
            }

            cool3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("Cooling")
                         where b.Product_Price >= (Convert.ToDecimal(coolBud + differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential))
                         select b).FirstOrDefault();

            coolDis = "";
            if (cool3 != null)
            {
                cool3img.InnerHtml = "<img src=" + cool3.Product_Img + " alt=>";

                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool3.Product_Id + ">Below Budget: " + cool3.Product_Name + "</a>";
                coolDis += "</h6>";
                cool3name.InnerHtml = coolDis;

                cool3brand.InnerHtml = "<p>Brand: " + cool3.Product_Brand + "</p>";

                cool3price.InnerHtml = Convert.ToString(cool3.Product_Price);
            }
            else
            {
                coolDis = "";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</h6>";
                cool3name.InnerHtml = coolDis;
            }

            gpu1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("GPU")
                         where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(gpuBud - differential / 2))
                         select b).FirstOrDefault();

            string gpuDis = "";
            if (gpu1 != null)
            {
                gpu1img.InnerHtml = "<img src=" + gpu1.Product_Img + " alt=>";

                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu1.Product_Id + ">Below Budget: " + gpu1.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpu1name.InnerHtml = gpuDis;

                gpu1brand.InnerHtml = "<p>Brand: " + gpu1.Product_Brand + "</p>";

                gpu1price.InnerHtml = Convert.ToString(gpu1.Product_Price);
            }
            else
            {
                gpuDis = "";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</h6>";
                gpu1name.InnerHtml = gpuDis;
            }


            gpu2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("GPU")
                         where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential / 2))
                         select b).FirstOrDefault();

            gpuDis = "";
            if (gpu2 != null)
            {
                gpu2img.InnerHtml = "<img src=" + gpu2.Product_Img + " alt=>";

                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu2.Product_Id + ">Below Budget: " + gpu2.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpu2name.InnerHtml = gpuDis;

                gpu2brand.InnerHtml = "<p>Brand: " + gpu2.Product_Brand + "</p>";

                gpu2price.InnerHtml = Convert.ToString(gpu2.Product_Price);
            }
            else
            {
                gpuDis = "";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</h6>";
                gpu2name.InnerHtml = gpuDis;
            }

            gpu3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("GPU")
                         where b.Product_Price >= (Convert.ToDecimal(gpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential))
                         select b).FirstOrDefault();

            gpuDis = "";
            if (gpu3 != null)
            {
                gpu3img.InnerHtml = "<img src=" + gpu3.Product_Img + " alt=>";

                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu3.Product_Id + ">Below Budget: " + gpu3.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpu3name.InnerHtml = gpuDis;

                gpu3brand.InnerHtml = "<p>Brand: " + gpu3.Product_Brand + "</p>";

                gpu3price.InnerHtml = Convert.ToString(gpu3.Product_Price);
            }
            else
            {
                gpuDis = "";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</h6>";
                gpu1name.InnerHtml = gpuDis;
            }

            mem1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential)) && b.Product_Price <= (Convert.ToDecimal(ramBud - differential / 2))
                        select b).FirstOrDefault();

            string memDis = "";
            if (mem1 != null)
            {
                mem1img.InnerHtml = "<img src=" + mem1.Product_Img + " alt=>";

                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem1.Product_Id + ">Below Budget: " + mem1.Product_Name + "</a>";
                memDis += "</h6>";
                mem1name.InnerHtml = memDis;

                mem1brand.InnerHtml = "<p>Brand: " + mem1.Product_Brand + "</p>";

                mem1price.InnerHtml = Convert.ToString(mem1.Product_Price);
            }
            else
            {
                memDis = "";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</h6>";
                mem1name.InnerHtml = memDis;
            }


            mem2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential / 2))
                        select b).FirstOrDefault();

            memDis = "";
            if (mem2 != null)
            {
                mem2img.InnerHtml = "<img src=" + mem2.Product_Img + " alt=>";

                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem2.Product_Id + ">Below Budget: " + mem2.Product_Name + "</a>";
                memDis += "</h6>";
                mem2name.InnerHtml = memDis;

                mem2brand.InnerHtml = "<p>Brand: " + mem2.Product_Brand + "</p>";

                mem2price.InnerHtml = Convert.ToString(mem2.Product_Price);
            }
            else
            {
                memDis = "";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</h6>";
                mem2name.InnerHtml = memDis;
            }

            mem3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Memory")
                        where b.Product_Price >= (Convert.ToDecimal(ramBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential*2))
                        select b).FirstOrDefault();

            memDis = "";
            if (mem3 != null)
            {
                mem3img.InnerHtml = "<img src=" + mem3.Product_Img + " alt=>";

                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem3.Product_Id + ">Below Budget: " + mem3.Product_Name + "</a>";
                memDis += "</h6>";
                mem3name.InnerHtml = memDis;

                mem3brand.InnerHtml = "<p>Brand: " + mem3.Product_Brand + "</p>";

                mem3price.InnerHtml = Convert.ToString(mem3.Product_Price);
            }
            else
            {
                memDis = "";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</h6>";
                mem3name.InnerHtml = memDis;
            }

            hard1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Hard Drive")
                        where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(hardBud - differential / 4))
                        select b).FirstOrDefault();

            string hardDis = "";
            if (hard1 != null)
            {
                hard1img.InnerHtml = "<img src=" + hard1.Product_Img + " alt=>";

                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard1.Product_Id + ">Below Budget: " + hard1.Product_Name + "</a>";
                hardDis += "</h6>";
                hard1name.InnerHtml = hardDis;

                hard1brand.InnerHtml = "<p>Brand: " + hard1.Product_Brand + "</p>";

                hard1price.InnerHtml = Convert.ToString(hard1.Product_Price);
            }
            else
            {
                hardDis = "";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</h6>";
                hard1name.InnerHtml = hardDis;
            }


            hard2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Hard Drive")
                        where b.Product_Price >= (Convert.ToDecimal(hardBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential / 2))
                        select b).FirstOrDefault();

            hardDis = "";
            if (hard2 != null)
            {
                hard2img.InnerHtml = "<img src=" + hard2.Product_Img + " alt=>";

                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard2.Product_Id + ">Below Budget: " + hard2.Product_Name + "</a>";
                hardDis += "</h6>";
                hard2name.InnerHtml = hardDis;

                hard2brand.InnerHtml = "<p>Brand: " + hard2.Product_Brand + "</p>";

                hard2price.InnerHtml = Convert.ToString(hard2.Product_Price);
            }
            else
            {
                hardDis = "";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</h6>";
                hard2name.InnerHtml = hardDis;
            }

            hard3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Hard Drive")
                        where b.Product_Price >= (Convert.ToDecimal(hardBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential))
                        select b).FirstOrDefault();

            hardDis = "";
            if (hard3 != null)
            {
                hard3img.InnerHtml = "<img src=" + hard3.Product_Img + " alt=>";

                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard3.Product_Id + ">Below Budget: " + hard3.Product_Name + "</a>";
                hardDis += "</h6>";
                hard3name.InnerHtml = hardDis;

                hard3brand.InnerHtml = "<p>Brand: " + hard3.Product_Brand + "</p>";

                hard3price.InnerHtml = Convert.ToString(hard3.Product_Price);
            }
            else
            {
                hardDis = "";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</h6>";
                hard3name.InnerHtml = hardDis;
            }

            psu1 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("PSU")
                         where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(1800))
                         select b).FirstOrDefault();

            string psuDis = "";
            if (psu1 != null)
            {
                psu1img.InnerHtml = "<img src=" + psu1.Product_Img + " alt=>";

                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu1.Product_Id + ">Below Budget: " + psu1.Product_Name + "</a>";
                psuDis += "</h6>";
                psu1name.InnerHtml = psuDis;

                psu1brand.InnerHtml = "<p>Brand: " + psu1.Product_Brand + "</p>";

                psu1price.InnerHtml = Convert.ToString(psu1.Product_Price);
            }
            else
            {
                psuDis = "";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</h6>";
                psu1name.InnerHtml = psuDis;
            }


            psu2 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("PSU")
                         where b.Product_Price >= (Convert.ToDecimal(1800)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential / 2))
                         select b).FirstOrDefault();

            psuDis = "";
            if (psu2 != null)
            {
                psu2img.InnerHtml = "<img src=" + psu2.Product_Img + " alt=>";

                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu2.Product_Id + ">Below Budget: " + psu2.Product_Name + "</a>";
                psuDis += "</h6>";
                psu2name.InnerHtml = psuDis;

                psu2brand.InnerHtml = "<p>Brand: " + psu2.Product_Brand + "</p>";

                psu2price.InnerHtml = Convert.ToString(psu2.Product_Price);
            }
            else
            {
                psuDis = "";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</h6>";
                psu2name.InnerHtml = psuDis;
            }

            psu3 = (from Product b in db.Products
                         where b.Product_IsActive.Equals(true)
                         where b.Product_Type.Equals("PSU")
                         where b.Product_Price >= (Convert.ToDecimal(psuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential))
                         select b).FirstOrDefault();

            psuDis = "";
            if (psu3 != null)
            {
                psu3img.InnerHtml = "<img src=" + psu3.Product_Img + " alt=>";

                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu3.Product_Id + ">Below Budget: " + psu3.Product_Name + "</a>";
                psuDis += "</h6>";
                psu3name.InnerHtml = psuDis;

                psu3brand.InnerHtml = "<p>Brand: " + psu3.Product_Brand + "</p>";

                psu3price.InnerHtml = Convert.ToString(psu3.Product_Price);
            }
            else
            {
                psuDis = "";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</h6>";
                psu3name.InnerHtml = psuDis;
            }

            case1 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Gaming Case")
                        where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(caseBud - differential / 4))
                        select b).FirstOrDefault();

            string caseDis = "";
            if (case1 != null)
            {
                case1img.InnerHtml = "<img src=" + case1.Product_Img + " alt=>";

                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case1.Product_Id + ">Below Budget: " + case1.Product_Name + "</a>";
                caseDis += "</h6>";
                case1name.InnerHtml = caseDis;

                case1brand.InnerHtml = "<p>Brand: " + case1.Product_Brand + "</p>";

                case1price.InnerHtml = Convert.ToString(case1.Product_Price);
            }
            else
            {
                caseDis = "";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</h6>";
                case1name.InnerHtml = caseDis;
            }


            case2 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Gaming Case")
                        where b.Product_Price >= (Convert.ToDecimal(caseBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential / 2))
                        select b).FirstOrDefault();

            caseDis = "";
            if (case2 != null)
            {
                case2img.InnerHtml = "<img src=" + case2.Product_Img + " alt=>";

                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case2.Product_Id + ">Below Budget: " + case2.Product_Name + "</a>";
                caseDis += "</h6>";
                case2name.InnerHtml = caseDis;

                case2brand.InnerHtml = "<p>Brand: " + case2.Product_Brand + "</p>";

                case2price.InnerHtml = Convert.ToString(case2.Product_Price);
            }
            else
            {
                caseDis = "";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</h6>";
                case2name.InnerHtml = caseDis;
            }

            case3 = (from Product b in db.Products
                        where b.Product_IsActive.Equals(true)
                        where b.Product_Type.Equals("Gaming Case")
                        where b.Product_Price >= (Convert.ToDecimal(caseBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential))
                        select b).FirstOrDefault();

            caseDis = "";
            if (case3 != null)
            {
                case3img.InnerHtml = "<img src=" + case3.Product_Img + " alt=>";

                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case3.Product_Id + ">Below Budget: " + case3.Product_Name + "</a>";
                caseDis += "</h6>";
                case3name.InnerHtml = caseDis;

                case3brand.InnerHtml = "<p>Brand: " + case3.Product_Brand + "</p>";

                case3price.InnerHtml = Convert.ToString(case3.Product_Price);
            }
            else
            {
                caseDis = "";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</h6>";
                case3name.InnerHtml = caseDis;
            }
        }

        protected void gaming1_Click(object sender, EventArgs e)
        {
            cpuPer = 0.2;
            gpuPer = 0.3;
            chosen = true;
            var db = new DataLinqDataContext();

            bud = int.Parse(budget.Value);
            budA = int.Parse(budget.Value);
            budgetCpu.InnerHtml = "<h6 class=\"product-title-2\">" + budA + "</h6>";
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

            cpu1 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("CPU")
                    where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(cpuBud - differential / 2))
                    select b).FirstOrDefault();

            string cpuDis = "";
            if (cpu1 != null)
            {
                cpu1img.InnerHtml = "<img src=" + cpu1.Product_Img + " alt=>";

                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu1.Product_Id + ">Below Budget: " + cpu1.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpu1name.InnerHtml = cpuDis;

                cpu1brand.InnerHtml = "<p>Brand: " + cpu1.Product_Brand + "</p>";

                cpu1price.InnerHtml = Convert.ToString(cpu1.Product_Price);
            }
            else
            {
                cpuDis = "";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</h6>";
                cpu1name.InnerHtml = cpuDis;
            }


            cpu2 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("CPU")
                    where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential / 2))
                    select b).FirstOrDefault();
            cpuDis = "";
            if (cpu2 != null)
            {
                cpu2img.InnerHtml = "<img src=" + cpu2.Product_Img + " alt=>";

                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu2.Product_Id + ">Below Budget: " + cpu2.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpu2name.InnerHtml = cpuDis;

                cpu2brand.InnerHtml = "<p>Brand: " + cpu2.Product_Brand + "</p>";

                cpu2price.InnerHtml = Convert.ToString(cpu2.Product_Price);
            }
            else
            {
                cpuDis = "";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</h6>";
                cpu2name.InnerHtml = cpuDis;
            }

            cpu3 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("CPU")
                    where b.Product_Price >= (Convert.ToDecimal(cpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential))
                    select b).FirstOrDefault();

            cpuDis = "";
            if (cpu3 != null)
            {
                cpu3img.InnerHtml = "<img src=" + cpu3.Product_Img + " alt=>";

                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu3.Product_Id + ">Below Budget: " + cpu3.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpu3name.InnerHtml = cpuDis;

                cpu3brand.InnerHtml = "<p>Brand: " + cpu3.Product_Brand + "</p>";

                cpu3price.InnerHtml = Convert.ToString(cpu3.Product_Price);
            }
            else
            {
                cpuDis = "";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</h6>";
                cpu3name.InnerHtml = cpuDis;
            }

            preferences.Attributes.Remove("class");
            preferences.Attributes.Add("class", "tab-pane");
            cpuBut.Attributes.Add("class", "active");
            cpu.Attributes.Remove("class");
            cpu.Attributes.Add("class", "tab-pane active");

            mobo1 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Motherboard")
                     where b.Product_Price >= (Convert.ToDecimal(moboBud - differential)) && b.Product_Price <= (Convert.ToDecimal(moboBud - differential / 2))
                     select b).FirstOrDefault();

            string moboDis = "";
            if (mobo1 != null)
            {
                mobo1img.InnerHtml = "<img src=" + mobo1.Product_Img + " alt=>";

                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo1.Product_Id + ">Below Budget: " + mobo1.Product_Name + "</a>";
                moboDis += "</h6>";
                mobo1name.InnerHtml = moboDis;

                mobo1brand.InnerHtml = "<p>Brand: " + mobo1.Product_Brand + "</p>";

                mobo1price.InnerHtml = Convert.ToString(mobo1.Product_Price);
            }
            else
            {
                moboDis = "";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</h6>";
                mobo1name.InnerHtml = moboDis;
            }


            mobo2 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Motherboard")
                     where b.Product_Price >= (Convert.ToDecimal(moboBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential / 2))
                     select b).FirstOrDefault();

            moboDis = "";
            if (mobo2 != null)
            {
                mobo2img.InnerHtml = "<img src=" + mobo2.Product_Img + " alt=>";

                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo2.Product_Id + ">Below Budget: " + mobo2.Product_Name + "</a>";
                moboDis += "</h6>";
                mobo2name.InnerHtml = moboDis;

                mobo2brand.InnerHtml = "<p>Brand: " + mobo2.Product_Brand + "</p>";

                mobo2price.InnerHtml = Convert.ToString(mobo2.Product_Price);
            }
            else
            {
                moboDis = "";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</h6>";
                mobo2name.InnerHtml = moboDis;
            }

            mobo3 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Motherboard")
                     where b.Product_Price >= (Convert.ToDecimal(moboBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential))
                     select b).FirstOrDefault();

            moboDis = "";
            if (mobo3 != null)
            {
                mobo3img.InnerHtml = "<img src=" + mobo3.Product_Img + " alt=>";

                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo3.Product_Id + ">Below Budget: " + mobo3.Product_Name + "</a>";
                moboDis += "</h6>";
                mobo3name.InnerHtml = moboDis;

                mobo3brand.InnerHtml = "<p>Brand: " + mobo3.Product_Brand + "</p>";

                mobo3price.InnerHtml = Convert.ToString(mobo3.Product_Price);
            }
            else
            {
                moboDis = "";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</h6>";
                mobo3name.InnerHtml = moboDis;
            }

            cool1 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Cooling")
                     where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(coolBud - differential / 4))
                     select b).FirstOrDefault();

            string coolDis = "";
            if (cool1 != null)
            {
                cool1img.InnerHtml = "<img src=" + cool1.Product_Img + " alt=>";

                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool1.Product_Id + ">Below Budget: " + cool1.Product_Name + "</a>";
                coolDis += "</h6>";
                cool1name.InnerHtml = coolDis;

                cool1brand.InnerHtml = "<p>Brand: " + cool1.Product_Brand + "</p>";

                cool1price.InnerHtml = Convert.ToString(cool1.Product_Price);
            }
            else
            {
                coolDis = "";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</h6>";
                cool1name.InnerHtml = coolDis;
            }


            cool2 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Cooling")
                     where b.Product_Price >= (Convert.ToDecimal(coolBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential / 4))
                     select b).FirstOrDefault();

            coolDis = "";
            if (cool2 != null)
            {
                cool2img.InnerHtml = "<img src=" + cool2.Product_Img + " alt=>";

                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool2.Product_Id + ">Below Budget: " + cool2.Product_Name + "</a>";
                coolDis += "</h6>";
                cool2name.InnerHtml = coolDis;

                cool2brand.InnerHtml = "<p>Brand: " + cool2.Product_Brand + "</p>";

                cool2price.InnerHtml = Convert.ToString(cool2.Product_Price);
            }
            else
            {
                coolDis = "";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</h6>";
                cool2name.InnerHtml = coolDis;
            }

            cool3 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Cooling")
                     where b.Product_Price >= (Convert.ToDecimal(coolBud + differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential))
                     select b).FirstOrDefault();

            coolDis = "";
            if (cool3 != null)
            {
                cool3img.InnerHtml = "<img src=" + cool3.Product_Img + " alt=>";

                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool3.Product_Id + ">Below Budget: " + cool3.Product_Name + "</a>";
                coolDis += "</h6>";
                cool3name.InnerHtml = coolDis;

                cool3brand.InnerHtml = "<p>Brand: " + cool3.Product_Brand + "</p>";

                cool3price.InnerHtml = Convert.ToString(cool3.Product_Price);
            }
            else
            {
                coolDis = "";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</h6>";
                cool3name.InnerHtml = coolDis;
            }

            gpu1 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("GPU")
                    where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(gpuBud - differential / 2))
                    select b).FirstOrDefault();

            string gpuDis = "";
            if (gpu1 != null)
            {
                gpu1img.InnerHtml = "<img src=" + gpu1.Product_Img + " alt=>";

                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu1.Product_Id + ">Below Budget: " + gpu1.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpu1name.InnerHtml = gpuDis;

                gpu1brand.InnerHtml = "<p>Brand: " + gpu1.Product_Brand + "</p>";

                gpu1price.InnerHtml = Convert.ToString(gpu1.Product_Price);
            }
            else
            {
                gpuDis = "";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</h6>";
                gpu1name.InnerHtml = gpuDis;
            }


            gpu2 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("GPU")
                    where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential / 2))
                    select b).FirstOrDefault();

            gpuDis = "";
            if (gpu2 != null)
            {
                gpu2img.InnerHtml = "<img src=" + gpu2.Product_Img + " alt=>";

                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu2.Product_Id + ">Below Budget: " + gpu2.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpu2name.InnerHtml = gpuDis;

                gpu2brand.InnerHtml = "<p>Brand: " + gpu2.Product_Brand + "</p>";

                gpu2price.InnerHtml = Convert.ToString(gpu2.Product_Price);
            }
            else
            {
                gpuDis = "";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</h6>";
                gpu2name.InnerHtml = gpuDis;
            }

            gpu3 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("GPU")
                    where b.Product_Price >= (Convert.ToDecimal(gpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential))
                    select b).FirstOrDefault();

            gpuDis = "";
            if (gpu3 != null)
            {
                gpu3img.InnerHtml = "<img src=" + gpu3.Product_Img + " alt=>";

                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu3.Product_Id + ">Below Budget: " + gpu3.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpu3name.InnerHtml = gpuDis;

                gpu3brand.InnerHtml = "<p>Brand: " + gpu3.Product_Brand + "</p>";

                gpu3price.InnerHtml = Convert.ToString(gpu3.Product_Price);
            }
            else
            {
                gpuDis = "";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</h6>";
                gpu1name.InnerHtml = gpuDis;
            }

            mem1 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("Memory")
                    where b.Product_Price >= (Convert.ToDecimal(ramBud - differential)) && b.Product_Price <= (Convert.ToDecimal(ramBud - differential / 2))
                    select b).FirstOrDefault();

            string memDis = "";
            if (mem1 != null)
            {
                mem1img.InnerHtml = "<img src=" + mem1.Product_Img + " alt=>";

                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem1.Product_Id + ">Below Budget: " + mem1.Product_Name + "</a>";
                memDis += "</h6>";
                mem1name.InnerHtml = memDis;

                mem1brand.InnerHtml = "<p>Brand: " + mem1.Product_Brand + "</p>";

                mem1price.InnerHtml = Convert.ToString(mem1.Product_Price);
            }
            else
            {
                memDis = "";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</h6>";
                mem1name.InnerHtml = memDis;
            }


            mem2 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("Memory")
                    where b.Product_Price >= (Convert.ToDecimal(ramBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential / 2))
                    select b).FirstOrDefault();

            memDis = "";
            if (mem2 != null)
            {
                mem2img.InnerHtml = "<img src=" + mem2.Product_Img + " alt=>";

                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem2.Product_Id + ">Below Budget: " + mem2.Product_Name + "</a>";
                memDis += "</h6>";
                mem2name.InnerHtml = memDis;

                mem2brand.InnerHtml = "<p>Brand: " + mem2.Product_Brand + "</p>";

                mem2price.InnerHtml = Convert.ToString(mem2.Product_Price);
            }
            else
            {
                memDis = "";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</h6>";
                mem2name.InnerHtml = memDis;
            }

            mem3 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("Memory")
                    where b.Product_Price >= (Convert.ToDecimal(ramBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential * 2))
                    select b).FirstOrDefault();

            memDis = "";
            if (mem3 != null)
            {
                mem3img.InnerHtml = "<img src=" + mem3.Product_Img + " alt=>";

                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem3.Product_Id + ">Below Budget: " + mem3.Product_Name + "</a>";
                memDis += "</h6>";
                mem3name.InnerHtml = memDis;

                mem3brand.InnerHtml = "<p>Brand: " + mem3.Product_Brand + "</p>";

                mem3price.InnerHtml = Convert.ToString(mem3.Product_Price);
            }
            else
            {
                memDis = "";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</h6>";
                mem3name.InnerHtml = memDis;
            }

            hard1 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Hard Drive")
                     where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(hardBud - differential / 4))
                     select b).FirstOrDefault();

            string hardDis = "";
            if (hard1 != null)
            {
                hard1img.InnerHtml = "<img src=" + hard1.Product_Img + " alt=>";

                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard1.Product_Id + ">Below Budget: " + hard1.Product_Name + "</a>";
                hardDis += "</h6>";
                hard1name.InnerHtml = hardDis;

                hard1brand.InnerHtml = "<p>Brand: " + hard1.Product_Brand + "</p>";

                hard1price.InnerHtml = Convert.ToString(hard1.Product_Price);
            }
            else
            {
                hardDis = "";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</h6>";
                hard1name.InnerHtml = hardDis;
            }


            hard2 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Hard Drive")
                     where b.Product_Price >= (Convert.ToDecimal(hardBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential / 2))
                     select b).FirstOrDefault();

            hardDis = "";
            if (hard2 != null)
            {
                hard2img.InnerHtml = "<img src=" + hard2.Product_Img + " alt=>";

                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard2.Product_Id + ">Below Budget: " + hard2.Product_Name + "</a>";
                hardDis += "</h6>";
                hard2name.InnerHtml = hardDis;

                hard2brand.InnerHtml = "<p>Brand: " + hard2.Product_Brand + "</p>";

                hard2price.InnerHtml = Convert.ToString(hard2.Product_Price);
            }
            else
            {
                hardDis = "";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</h6>";
                hard2name.InnerHtml = hardDis;
            }

            hard3 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Hard Drive")
                     where b.Product_Price >= (Convert.ToDecimal(hardBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential))
                     select b).FirstOrDefault();

            hardDis = "";
            if (hard3 != null)
            {
                hard3img.InnerHtml = "<img src=" + hard3.Product_Img + " alt=>";

                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard3.Product_Id + ">Below Budget: " + hard3.Product_Name + "</a>";
                hardDis += "</h6>";
                hard3name.InnerHtml = hardDis;

                hard3brand.InnerHtml = "<p>Brand: " + hard3.Product_Brand + "</p>";

                hard3price.InnerHtml = Convert.ToString(hard3.Product_Price);
            }
            else
            {
                hardDis = "";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</h6>";
                hard3name.InnerHtml = hardDis;
            }

            psu1 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("PSU")
                    where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(1800))
                    select b).FirstOrDefault();

            string psuDis = "";
            if (psu1 != null)
            {
                psu1img.InnerHtml = "<img src=" + psu1.Product_Img + " alt=>";

                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu1.Product_Id + ">Below Budget: " + psu1.Product_Name + "</a>";
                psuDis += "</h6>";
                psu1name.InnerHtml = psuDis;

                psu1brand.InnerHtml = "<p>Brand: " + psu1.Product_Brand + "</p>";

                psu1price.InnerHtml = Convert.ToString(psu1.Product_Price);
            }
            else
            {
                psuDis = "";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</h6>";
                psu1name.InnerHtml = psuDis;
            }


            psu2 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("PSU")
                    where b.Product_Price >= (Convert.ToDecimal(1800)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential / 2))
                    select b).FirstOrDefault();

            psuDis = "";
            if (psu2 != null)
            {
                psu2img.InnerHtml = "<img src=" + psu2.Product_Img + " alt=>";

                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu2.Product_Id + ">Below Budget: " + psu2.Product_Name + "</a>";
                psuDis += "</h6>";
                psu2name.InnerHtml = psuDis;

                psu2brand.InnerHtml = "<p>Brand: " + psu2.Product_Brand + "</p>";

                psu2price.InnerHtml = Convert.ToString(psu2.Product_Price);
            }
            else
            {
                psuDis = "";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</h6>";
                psu2name.InnerHtml = psuDis;
            }

            psu3 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("PSU")
                    where b.Product_Price >= (Convert.ToDecimal(psuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential))
                    select b).FirstOrDefault();

            psuDis = "";
            if (psu3 != null)
            {
                psu3img.InnerHtml = "<img src=" + psu3.Product_Img + " alt=>";

                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu3.Product_Id + ">Below Budget: " + psu3.Product_Name + "</a>";
                psuDis += "</h6>";
                psu3name.InnerHtml = psuDis;

                psu3brand.InnerHtml = "<p>Brand: " + psu3.Product_Brand + "</p>";

                psu3price.InnerHtml = Convert.ToString(psu3.Product_Price);
            }
            else
            {
                psuDis = "";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</h6>";
                psu3name.InnerHtml = psuDis;
            }

            case1 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Gaming Case")
                     where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(caseBud - differential / 4))
                     select b).FirstOrDefault();

            string caseDis = "";
            if (case1 != null)
            {
                case1img.InnerHtml = "<img src=" + case1.Product_Img + " alt=>";

                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case1.Product_Id + ">Below Budget: " + case1.Product_Name + "</a>";
                caseDis += "</h6>";
                case1name.InnerHtml = caseDis;

                case1brand.InnerHtml = "<p>Brand: " + case1.Product_Brand + "</p>";

                case1price.InnerHtml = Convert.ToString(case1.Product_Price);
            }
            else
            {
                caseDis = "";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</h6>";
                case1name.InnerHtml = caseDis;
            }


            case2 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Gaming Case")
                     where b.Product_Price >= (Convert.ToDecimal(caseBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential / 2))
                     select b).FirstOrDefault();

            caseDis = "";
            if (case2 != null)
            {
                case2img.InnerHtml = "<img src=" + case2.Product_Img + " alt=>";

                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case2.Product_Id + ">Below Budget: " + case2.Product_Name + "</a>";
                caseDis += "</h6>";
                case2name.InnerHtml = caseDis;

                case2brand.InnerHtml = "<p>Brand: " + case2.Product_Brand + "</p>";

                case2price.InnerHtml = Convert.ToString(case2.Product_Price);
            }
            else
            {
                caseDis = "";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</h6>";
                case2name.InnerHtml = caseDis;
            }

            case3 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Gaming Case")
                     where b.Product_Price >= (Convert.ToDecimal(caseBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential))
                     select b).FirstOrDefault();

            caseDis = "";
            if (case3 != null)
            {
                case3img.InnerHtml = "<img src=" + case3.Product_Img + " alt=>";

                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case3.Product_Id + ">Below Budget: " + case3.Product_Name + "</a>";
                caseDis += "</h6>";
                case3name.InnerHtml = caseDis;

                case3brand.InnerHtml = "<p>Brand: " + case3.Product_Brand + "</p>";

                case3price.InnerHtml = Convert.ToString(case3.Product_Price);
            }
            else
            {
                caseDis = "";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</h6>";
                case3name.InnerHtml = caseDis;
            }
        }
    

        protected void general_Click(object sender, EventArgs e)
        {
            cpuPer = 0.25;
            gpuPer = 0.25;
            chosen = true;

            var db = new DataLinqDataContext();

            bud = int.Parse(budget.Value);
            budA = int.Parse(budget.Value);
            budgetCpu.InnerHtml = "<h6 class=\"product-title-2\">" + budA + "</h6>";
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

            cpu1 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("CPU")
                    where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(cpuBud - differential / 2))
                    select b).FirstOrDefault();

            string cpuDis = "";
            if (cpu1 != null)
            {
                cpu1img.InnerHtml = "<img src=" + cpu1.Product_Img + " alt=>";

                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu1.Product_Id + ">Below Budget: " + cpu1.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpu1name.InnerHtml = cpuDis;

                cpu1brand.InnerHtml = "<p>Brand: " + cpu1.Product_Brand + "</p>";

                cpu1price.InnerHtml = Convert.ToString(cpu1.Product_Price);
            }
            else
            {
                cpuDis = "";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</h6>";
                cpu1name.InnerHtml = cpuDis;
            }


            cpu2 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("CPU")
                    where b.Product_Price >= (Convert.ToDecimal(cpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential / 2))
                    select b).FirstOrDefault();
            cpuDis = "";
            if (cpu2 != null)
            {
                cpu2img.InnerHtml = "<img src=" + cpu2.Product_Img + " alt=>";

                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu2.Product_Id + ">Below Budget: " + cpu2.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpu2name.InnerHtml = cpuDis;

                cpu2brand.InnerHtml = "<p>Brand: " + cpu2.Product_Brand + "</p>";

                cpu2price.InnerHtml = Convert.ToString(cpu2.Product_Price);
            }
            else
            {
                cpuDis = "";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</h6>";
                cpu2name.InnerHtml = cpuDis;
            }

            cpu3 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("CPU")
                    where b.Product_Price >= (Convert.ToDecimal(cpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(cpuBud + differential))
                    select b).FirstOrDefault();

            cpuDis = "";
            if (cpu3 != null)
            {
                cpu3img.InnerHtml = "<img src=" + cpu3.Product_Img + " alt=>";

                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cpu3.Product_Id + ">Below Budget: " + cpu3.Product_Name + "</a>";
                cpuDis += "</h6>";
                cpu3name.InnerHtml = cpuDis;

                cpu3brand.InnerHtml = "<p>Brand: " + cpu3.Product_Brand + "</p>";

                cpu3price.InnerHtml = Convert.ToString(cpu3.Product_Price);
            }
            else
            {
                cpuDis = "";
                cpuDis += "<h6 class=\"product-title-2\">";
                cpuDis += "No Product Found for this Price Range";
                cpuDis += "</h6>";
                cpu3name.InnerHtml = cpuDis;
            }

            preferences.Attributes.Remove("class");
            preferences.Attributes.Add("class", "tab-pane");
            cpuBut.Attributes.Add("class", "active");
            cpu.Attributes.Remove("class");
            cpu.Attributes.Add("class", "tab-pane active");

            mobo1 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Motherboard")
                     where b.Product_Price >= (Convert.ToDecimal(moboBud - differential)) && b.Product_Price <= (Convert.ToDecimal(moboBud - differential / 2))
                     select b).FirstOrDefault();

            string moboDis = "";
            if (mobo1 != null)
            {
                mobo1img.InnerHtml = "<img src=" + mobo1.Product_Img + " alt=>";

                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo1.Product_Id + ">Below Budget: " + mobo1.Product_Name + "</a>";
                moboDis += "</h6>";
                mobo1name.InnerHtml = moboDis;

                mobo1brand.InnerHtml = "<p>Brand: " + mobo1.Product_Brand + "</p>";

                mobo1price.InnerHtml = Convert.ToString(mobo1.Product_Price);
            }
            else
            {
                moboDis = "";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</h6>";
                mobo1name.InnerHtml = moboDis;
            }


            mobo2 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Motherboard")
                     where b.Product_Price >= (Convert.ToDecimal(moboBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential / 2))
                     select b).FirstOrDefault();

            moboDis = "";
            if (mobo2 != null)
            {
                mobo2img.InnerHtml = "<img src=" + mobo2.Product_Img + " alt=>";

                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo2.Product_Id + ">Below Budget: " + mobo2.Product_Name + "</a>";
                moboDis += "</h6>";
                mobo2name.InnerHtml = moboDis;

                mobo2brand.InnerHtml = "<p>Brand: " + mobo2.Product_Brand + "</p>";

                mobo2price.InnerHtml = Convert.ToString(mobo2.Product_Price);
            }
            else
            {
                moboDis = "";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</h6>";
                mobo2name.InnerHtml = moboDis;
            }

            mobo3 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Motherboard")
                     where b.Product_Price >= (Convert.ToDecimal(moboBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(moboBud + differential))
                     select b).FirstOrDefault();

            moboDis = "";
            if (mobo3 != null)
            {
                mobo3img.InnerHtml = "<img src=" + mobo3.Product_Img + " alt=>";

                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mobo3.Product_Id + ">Below Budget: " + mobo3.Product_Name + "</a>";
                moboDis += "</h6>";
                mobo3name.InnerHtml = moboDis;

                mobo3brand.InnerHtml = "<p>Brand: " + mobo3.Product_Brand + "</p>";

                mobo3price.InnerHtml = Convert.ToString(mobo3.Product_Price);
            }
            else
            {
                moboDis = "";
                moboDis += "<h6 class=\"product-title-2\">";
                moboDis += "No Product Found for this Price Range";
                moboDis += "</h6>";
                mobo3name.InnerHtml = moboDis;
            }

            cool1 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Cooling")
                     where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(coolBud - differential / 4))
                     select b).FirstOrDefault();

            string coolDis = "";
            if (cool1 != null)
            {
                cool1img.InnerHtml = "<img src=" + cool1.Product_Img + " alt=>";

                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool1.Product_Id + ">Below Budget: " + cool1.Product_Name + "</a>";
                coolDis += "</h6>";
                cool1name.InnerHtml = coolDis;

                cool1brand.InnerHtml = "<p>Brand: " + cool1.Product_Brand + "</p>";

                cool1price.InnerHtml = Convert.ToString(cool1.Product_Price);
            }
            else
            {
                coolDis = "";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</h6>";
                cool1name.InnerHtml = coolDis;
            }


            cool2 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Cooling")
                     where b.Product_Price >= (Convert.ToDecimal(coolBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential / 4))
                     select b).FirstOrDefault();

            coolDis = "";
            if (cool2 != null)
            {
                cool2img.InnerHtml = "<img src=" + cool2.Product_Img + " alt=>";

                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool2.Product_Id + ">Below Budget: " + cool2.Product_Name + "</a>";
                coolDis += "</h6>";
                cool2name.InnerHtml = coolDis;

                cool2brand.InnerHtml = "<p>Brand: " + cool2.Product_Brand + "</p>";

                cool2price.InnerHtml = Convert.ToString(cool2.Product_Price);
            }
            else
            {
                coolDis = "";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</h6>";
                cool2name.InnerHtml = coolDis;
            }

            cool3 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Cooling")
                     where b.Product_Price >= (Convert.ToDecimal(coolBud + differential / 4)) && b.Product_Price <= (Convert.ToDecimal(coolBud + differential))
                     select b).FirstOrDefault();

            coolDis = "";
            if (cool3 != null)
            {
                cool3img.InnerHtml = "<img src=" + cool3.Product_Img + " alt=>";

                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + cool3.Product_Id + ">Below Budget: " + cool3.Product_Name + "</a>";
                coolDis += "</h6>";
                cool3name.InnerHtml = coolDis;

                cool3brand.InnerHtml = "<p>Brand: " + cool3.Product_Brand + "</p>";

                cool3price.InnerHtml = Convert.ToString(cool3.Product_Price);
            }
            else
            {
                coolDis = "";
                coolDis += "<h6 class=\"product-title-2\">";
                coolDis += "No Product Found for this Price Range";
                coolDis += "</h6>";
                cool3name.InnerHtml = coolDis;
            }

            gpu1 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("GPU")
                    where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential)) && b.Product_Price <= (Convert.ToDecimal(gpuBud - differential / 2))
                    select b).FirstOrDefault();

            string gpuDis = "";
            if (gpu1 != null)
            {
                gpu1img.InnerHtml = "<img src=" + gpu1.Product_Img + " alt=>";

                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu1.Product_Id + ">Below Budget: " + gpu1.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpu1name.InnerHtml = gpuDis;

                gpu1brand.InnerHtml = "<p>Brand: " + gpu1.Product_Brand + "</p>";

                gpu1price.InnerHtml = Convert.ToString(gpu1.Product_Price);
            }
            else
            {
                gpuDis = "";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</h6>";
                gpu1name.InnerHtml = gpuDis;
            }


            gpu2 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("GPU")
                    where b.Product_Price >= (Convert.ToDecimal(gpuBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential / 2))
                    select b).FirstOrDefault();

            gpuDis = "";
            if (gpu2 != null)
            {
                gpu2img.InnerHtml = "<img src=" + gpu2.Product_Img + " alt=>";

                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu2.Product_Id + ">Below Budget: " + gpu2.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpu2name.InnerHtml = gpuDis;

                gpu2brand.InnerHtml = "<p>Brand: " + gpu2.Product_Brand + "</p>";

                gpu2price.InnerHtml = Convert.ToString(gpu2.Product_Price);
            }
            else
            {
                gpuDis = "";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</h6>";
                gpu2name.InnerHtml = gpuDis;
            }

            gpu3 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("GPU")
                    where b.Product_Price >= (Convert.ToDecimal(gpuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(gpuBud + differential))
                    select b).FirstOrDefault();

            gpuDis = "";
            if (gpu3 != null)
            {
                gpu3img.InnerHtml = "<img src=" + gpu3.Product_Img + " alt=>";

                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + gpu3.Product_Id + ">Below Budget: " + gpu3.Product_Name + "</a>";
                gpuDis += "</h6>";
                gpu3name.InnerHtml = gpuDis;

                gpu3brand.InnerHtml = "<p>Brand: " + gpu3.Product_Brand + "</p>";

                gpu3price.InnerHtml = Convert.ToString(gpu3.Product_Price);
            }
            else
            {
                gpuDis = "";
                gpuDis += "<h6 class=\"product-title-2\">";
                gpuDis += "No Product Found for this Price Range";
                gpuDis += "</h6>";
                gpu1name.InnerHtml = gpuDis;
            }

            mem1 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("Memory")
                    where b.Product_Price >= (Convert.ToDecimal(ramBud - differential)) && b.Product_Price <= (Convert.ToDecimal(ramBud - differential / 2))
                    select b).FirstOrDefault();

            string memDis = "";
            if (mem1 != null)
            {
                mem1img.InnerHtml = "<img src=" + mem1.Product_Img + " alt=>";

                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem1.Product_Id + ">Below Budget: " + mem1.Product_Name + "</a>";
                memDis += "</h6>";
                mem1name.InnerHtml = memDis;

                mem1brand.InnerHtml = "<p>Brand: " + mem1.Product_Brand + "</p>";

                mem1price.InnerHtml = Convert.ToString(mem1.Product_Price);
            }
            else
            {
                memDis = "";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</h6>";
                mem1name.InnerHtml = memDis;
            }


            mem2 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("Memory")
                    where b.Product_Price >= (Convert.ToDecimal(ramBud - differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential / 2))
                    select b).FirstOrDefault();

            memDis = "";
            if (mem2 != null)
            {
                mem2img.InnerHtml = "<img src=" + mem2.Product_Img + " alt=>";

                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem2.Product_Id + ">Below Budget: " + mem2.Product_Name + "</a>";
                memDis += "</h6>";
                mem2name.InnerHtml = memDis;

                mem2brand.InnerHtml = "<p>Brand: " + mem2.Product_Brand + "</p>";

                mem2price.InnerHtml = Convert.ToString(mem2.Product_Price);
            }
            else
            {
                memDis = "";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</h6>";
                mem2name.InnerHtml = memDis;
            }

            mem3 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("Memory")
                    where b.Product_Price >= (Convert.ToDecimal(ramBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(ramBud + differential * 2))
                    select b).FirstOrDefault();

            memDis = "";
            if (mem3 != null)
            {
                mem3img.InnerHtml = "<img src=" + mem3.Product_Img + " alt=>";

                memDis += "<h6 class=\"product-title-2\">";
                memDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + mem3.Product_Id + ">Below Budget: " + mem3.Product_Name + "</a>";
                memDis += "</h6>";
                mem3name.InnerHtml = memDis;

                mem3brand.InnerHtml = "<p>Brand: " + mem3.Product_Brand + "</p>";

                mem3price.InnerHtml = Convert.ToString(mem3.Product_Price);
            }
            else
            {
                memDis = "";
                memDis += "<h6 class=\"product-title-2\">";
                memDis += "No Product Found for this Price Range";
                memDis += "</h6>";
                mem3name.InnerHtml = memDis;
            }

            hard1 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Hard Drive")
                     where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(hardBud - differential / 4))
                     select b).FirstOrDefault();

            string hardDis = "";
            if (hard1 != null)
            {
                hard1img.InnerHtml = "<img src=" + hard1.Product_Img + " alt=>";

                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard1.Product_Id + ">Below Budget: " + hard1.Product_Name + "</a>";
                hardDis += "</h6>";
                hard1name.InnerHtml = hardDis;

                hard1brand.InnerHtml = "<p>Brand: " + hard1.Product_Brand + "</p>";

                hard1price.InnerHtml = Convert.ToString(hard1.Product_Price);
            }
            else
            {
                hardDis = "";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</h6>";
                hard1name.InnerHtml = hardDis;
            }


            hard2 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Hard Drive")
                     where b.Product_Price >= (Convert.ToDecimal(hardBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential / 2))
                     select b).FirstOrDefault();

            hardDis = "";
            if (hard2 != null)
            {
                hard2img.InnerHtml = "<img src=" + hard2.Product_Img + " alt=>";

                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard2.Product_Id + ">Below Budget: " + hard2.Product_Name + "</a>";
                hardDis += "</h6>";
                hard2name.InnerHtml = hardDis;

                hard2brand.InnerHtml = "<p>Brand: " + hard2.Product_Brand + "</p>";

                hard2price.InnerHtml = Convert.ToString(hard2.Product_Price);
            }
            else
            {
                hardDis = "";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</h6>";
                hard2name.InnerHtml = hardDis;
            }

            hard3 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Hard Drive")
                     where b.Product_Price >= (Convert.ToDecimal(hardBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(hardBud + differential))
                     select b).FirstOrDefault();

            hardDis = "";
            if (hard3 != null)
            {
                hard3img.InnerHtml = "<img src=" + hard3.Product_Img + " alt=>";

                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + hard3.Product_Id + ">Below Budget: " + hard3.Product_Name + "</a>";
                hardDis += "</h6>";
                hard3name.InnerHtml = hardDis;

                hard3brand.InnerHtml = "<p>Brand: " + hard3.Product_Brand + "</p>";

                hard3price.InnerHtml = Convert.ToString(hard3.Product_Price);
            }
            else
            {
                hardDis = "";
                hardDis += "<h6 class=\"product-title-2\">";
                hardDis += "No Product Found for this Price Range";
                hardDis += "</h6>";
                hard3name.InnerHtml = hardDis;
            }

            psu1 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("PSU")
                    where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(1800))
                    select b).FirstOrDefault();

            string psuDis = "";
            if (psu1 != null)
            {
                psu1img.InnerHtml = "<img src=" + psu1.Product_Img + " alt=>";

                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu1.Product_Id + ">Below Budget: " + psu1.Product_Name + "</a>";
                psuDis += "</h6>";
                psu1name.InnerHtml = psuDis;

                psu1brand.InnerHtml = "<p>Brand: " + psu1.Product_Brand + "</p>";

                psu1price.InnerHtml = Convert.ToString(psu1.Product_Price);
            }
            else
            {
                psuDis = "";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</h6>";
                psu1name.InnerHtml = psuDis;
            }


            psu2 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("PSU")
                    where b.Product_Price >= (Convert.ToDecimal(1800)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential / 2))
                    select b).FirstOrDefault();

            psuDis = "";
            if (psu2 != null)
            {
                psu2img.InnerHtml = "<img src=" + psu2.Product_Img + " alt=>";

                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu2.Product_Id + ">Below Budget: " + psu2.Product_Name + "</a>";
                psuDis += "</h6>";
                psu2name.InnerHtml = psuDis;

                psu2brand.InnerHtml = "<p>Brand: " + psu2.Product_Brand + "</p>";

                psu2price.InnerHtml = Convert.ToString(psu2.Product_Price);
            }
            else
            {
                psuDis = "";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</h6>";
                psu2name.InnerHtml = psuDis;
            }

            psu3 = (from Product b in db.Products
                    where b.Product_IsActive.Equals(true)
                    where b.Product_Type.Equals("PSU")
                    where b.Product_Price >= (Convert.ToDecimal(psuBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(psuBud + differential))
                    select b).FirstOrDefault();

            psuDis = "";
            if (psu3 != null)
            {
                psu3img.InnerHtml = "<img src=" + psu3.Product_Img + " alt=>";

                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + psu3.Product_Id + ">Below Budget: " + psu3.Product_Name + "</a>";
                psuDis += "</h6>";
                psu3name.InnerHtml = psuDis;

                psu3brand.InnerHtml = "<p>Brand: " + psu3.Product_Brand + "</p>";

                psu3price.InnerHtml = Convert.ToString(psu3.Product_Price);
            }
            else
            {
                psuDis = "";
                psuDis += "<h6 class=\"product-title-2\">";
                psuDis += "No Product Found for this Price Range";
                psuDis += "</h6>";
                psu3name.InnerHtml = psuDis;
            }

            case1 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Gaming Case")
                     where b.Product_Price >= (Convert.ToDecimal(0)) && b.Product_Price <= (Convert.ToDecimal(caseBud - differential / 4))
                     select b).FirstOrDefault();

            string caseDis = "";
            if (case1 != null)
            {
                case1img.InnerHtml = "<img src=" + case1.Product_Img + " alt=>";

                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case1.Product_Id + ">Below Budget: " + case1.Product_Name + "</a>";
                caseDis += "</h6>";
                case1name.InnerHtml = caseDis;

                case1brand.InnerHtml = "<p>Brand: " + case1.Product_Brand + "</p>";

                case1price.InnerHtml = Convert.ToString(case1.Product_Price);
            }
            else
            {
                caseDis = "";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</h6>";
                case1name.InnerHtml = caseDis;
            }


            case2 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Gaming Case")
                     where b.Product_Price >= (Convert.ToDecimal(caseBud - differential / 4)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential / 2))
                     select b).FirstOrDefault();

            caseDis = "";
            if (case2 != null)
            {
                case2img.InnerHtml = "<img src=" + case2.Product_Img + " alt=>";

                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case2.Product_Id + ">Below Budget: " + case2.Product_Name + "</a>";
                caseDis += "</h6>";
                case2name.InnerHtml = caseDis;

                case2brand.InnerHtml = "<p>Brand: " + case2.Product_Brand + "</p>";

                case2price.InnerHtml = Convert.ToString(case2.Product_Price);
            }
            else
            {
                caseDis = "";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</h6>";
                case2name.InnerHtml = caseDis;
            }

            case3 = (from Product b in db.Products
                     where b.Product_IsActive.Equals(true)
                     where b.Product_Type.Equals("Gaming Case")
                     where b.Product_Price >= (Convert.ToDecimal(caseBud + differential / 2)) && b.Product_Price <= (Convert.ToDecimal(caseBud + differential))
                     select b).FirstOrDefault();

            caseDis = "";
            if (case3 != null)
            {
                case3img.InnerHtml = "<img src=" + case3.Product_Img + " alt=>";

                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "<a target=\"_blank\" rel=\"noopener noreferrer\" href=ProductPage.aspx?ProductId=" + case3.Product_Id + ">Below Budget: " + case3.Product_Name + "</a>";
                caseDis += "</h6>";
                case3name.InnerHtml = caseDis;

                case3brand.InnerHtml = "<p>Brand: " + case3.Product_Brand + "</p>";

                case3price.InnerHtml = Convert.ToString(case3.Product_Price);
            }
            else
            {
                caseDis = "";
                caseDis += "<h6 class=\"product-title-2\">";
                caseDis += "No Product Found for this Price Range";
                caseDis += "</h6>";
                case3name.InnerHtml = caseDis;
            }
        }

        protected void finalise_Click(object sender, EventArgs e)
        {
            Response.Redirect("Finalise.aspx?cpu=" + cpuId + "&mobo=" + moboId + "&cool=" + coolId + "&gpu=" + gpuId + "&psu=" + cpuId + "&mem=" + memId + "&case=" + caseId + "&hard=" + hardId);
        }

        protected void backCpu_Click(object sender, EventArgs e)
        {
            preferences.Attributes.Remove("class");
            preferences.Attributes.Add("class", "tab-pane active");
            cpuBut.Attributes.Remove("class");
            cpu.Attributes.Remove("class");
            cpu.Attributes.Add("class", "tab-pane");
        }

        protected void nextCpu_Click(object sender, EventArgs e)
        {
            cpu.Attributes.Remove("class");
            cpu.Attributes.Add("class", "tab-pane");
            moboBut.Attributes.Add("class", "active");
            motherboard.Attributes.Remove("class");
            motherboard.Attributes.Add("class", "tab-pane active");
            budgetMobo.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void backMobo_Click1(object sender, EventArgs e)
        {
            motherboard.Attributes.Remove("class");
            motherboard.Attributes.Add("class", "tab-pane");
            moboBut.Attributes.Remove("class");
            cpu.Attributes.Remove("class");
            cpu.Attributes.Add("class", "tab-pane active");
        }

        protected void nextMobo_Click1(object sender, EventArgs e)
        {
            motherboard.Attributes.Remove("class");
            motherboard.Attributes.Add("class", "tab-pane");
            coolBut.Attributes.Add("class", "active");
            cooling.Attributes.Remove("class");
            cooling.Attributes.Add("class", "tab-pane active");
            budgetCool.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void coolBack_Click(object sender, EventArgs e)
        {
            cooling.Attributes.Remove("class");
            cooling.Attributes.Add("class", "tab-pane");
            coolBut.Attributes.Remove("class");
            motherboard.Attributes.Remove("class");
            motherboard.Attributes.Add("class", "tab-pane active");
        }

        protected void coolNext_Click(object sender, EventArgs e)
        {
            cooling.Attributes.Remove("class");
            cooling.Attributes.Add("class", "tab-pane");
            gpuBut.Attributes.Add("class", "active");
            graphics.Attributes.Remove("class");
            graphics.Attributes.Add("class", "tab-pane active");
            budgetGpu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void gpuBack_Click(object sender, EventArgs e)
        {
            graphics.Attributes.Remove("class");
            graphics.Attributes.Add("class", "tab-pane");
            gpuBut.Attributes.Remove("class");
            cooling.Attributes.Remove("class");
            cooling.Attributes.Add("class", "tab-pane active");
        }

        protected void gpuNext_Click(object sender, EventArgs e)
        {
            graphics.Attributes.Remove("class");
            graphics.Attributes.Add("class", "tab-pane");
            memBut.Attributes.Add("class", "active");
            memory.Attributes.Remove("class");
            memory.Attributes.Add("class", "tab-pane active");
            budgetMem.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void memBack_Click(object sender, EventArgs e)
        {
            memory.Attributes.Remove("class");
            memory.Attributes.Add("class", "tab-pane");
            memBut.Attributes.Remove("class");
            graphics.Attributes.Remove("class");
            graphics.Attributes.Add("class", "tab-pane active");
        }

        protected void memNext_Click(object sender, EventArgs e)
        {
            memory.Attributes.Remove("class");
            memory.Attributes.Add("class", "tab-pane");
            hardBut.Attributes.Add("class", "active");
            harddrives.Attributes.Remove("class");
            harddrives.Attributes.Add("class", "tab-pane active");
            budgetHard.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void hardBack_Click(object sender, EventArgs e)
        {
            harddrives.Attributes.Remove("class");
            harddrives.Attributes.Add("class", "tab-pane");
            hardBut.Attributes.Remove("class");
            memory.Attributes.Remove("class");
            memory.Attributes.Add("class", "tab-pane active");
        }

        protected void hardNext_Click(object sender, EventArgs e)
        {
            harddrives.Attributes.Remove("class");
            harddrives.Attributes.Add("class", "tab-pane");
            psuBut.Attributes.Add("class", "active");
            PSU.Attributes.Remove("class");
            PSU.Attributes.Add("class", "tab-pane active");
            budgetPsu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void psuBack_Click(object sender, EventArgs e)
        {
            PSU.Attributes.Remove("class");
            PSU.Attributes.Add("class", "tab-pane");
            psuBut.Attributes.Remove("class");
            harddrives.Attributes.Remove("class");
            harddrives.Attributes.Add("class", "tab-pane active");
        }

        protected void psuNext_Click(object sender, EventArgs e)
        {
            PSU.Attributes.Remove("class");
            PSU.Attributes.Add("class", "tab-pane");
            caseBut.Attributes.Add("class", "active");
            cases.Attributes.Remove("class");
            cases.Attributes.Add("class", "tab-pane active");
            budgetCase.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void caseBack_Click(object sender, EventArgs e)
        {
            cases.Attributes.Remove("class");
            cases.Attributes.Add("class", "tab-pane");
            caseBut.Attributes.Remove("class");
            PSU.Attributes.Remove("class");
            PSU.Attributes.Add("class", "tab-pane active");
        }

        protected void caseNext_Click(object sender, EventArgs e)
        {
            cases.Attributes.Remove("class");
            cases.Attributes.Add("class", "tab-pane");
            finBut.Attributes.Add("class", "active");
            final.Attributes.Remove("class");
            final.Attributes.Add("class", "tab-pane active");
        }

        protected void finBack_Click(object sender, EventArgs e)
        {
            final.Attributes.Remove("class");
            final.Attributes.Add("class", "tab-pane");
            finBut.Attributes.Remove("class");
            cases.Attributes.Remove("class");
            cases.Attributes.Add("class", "tab-pane active");
        }

        protected void cpu1r_CheckedChanged(object sender, EventArgs e)
        {
            int cpuId1 = cpu1.Product_Id;
            budA = budA - Convert.ToInt32(cpu1.Product_Price);
            budgetCpu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
            
        }

        protected void cpu2r_CheckedChanged(object sender, EventArgs e)
        {
            cpuId = cpu2.Product_Id;
            budA = budA - Convert.ToInt32(cpu2.Product_Price);
            budgetCpu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void cpu3r_CheckedChanged(object sender, EventArgs e)
        {
            cpuId = cpu3.Product_Id;
            budA = budA - Convert.ToInt32(cpu3.Product_Price);
            budgetCpu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void mobo1r_CheckedChanged(object sender, EventArgs e)
        {
            moboId = mobo1.Product_Id;
            budA = budA - Convert.ToInt32(mobo1.Product_Price);
            budgetMobo.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void mobo2r_CheckedChanged(object sender, EventArgs e)
        {
            moboId = mobo2.Product_Id;
            budA = budA - Convert.ToInt32(mobo2.Product_Price);
            budgetMobo.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void mobo3r_CheckedChanged(object sender, EventArgs e)
        {
            moboId = mobo3.Product_Id;
            budA = budA - Convert.ToInt32(mobo3.Product_Price);
            budgetMobo.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void cool1r_CheckedChanged(object sender, EventArgs e)
        {
            coolId = cool1.Product_Id;
            budA = budA - Convert.ToInt32(cool1.Product_Price);
            budgetCool.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void cool2r_CheckedChanged(object sender, EventArgs e)
        {
            coolId = cool2.Product_Id;
            budA = budA - Convert.ToInt32(cool2.Product_Price);
            budgetCool.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void cool3r_CheckedChanged(object sender, EventArgs e)
        {
            coolId = cool3.Product_Id;
            budA = budA - Convert.ToInt32(cool3.Product_Price);
            budgetCool.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void gpu1r_CheckedChanged(object sender, EventArgs e)
        {
            gpuId = gpu1.Product_Id;
            budA = budA - Convert.ToInt32(gpu1.Product_Price);
            budgetGpu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void gpu2r_CheckedChanged(object sender, EventArgs e)
        {
            gpuId = gpu2.Product_Id;
            budA = budA - Convert.ToInt32(gpu2.Product_Price);
            budgetGpu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void gpu3r_CheckedChanged(object sender, EventArgs e)
        {
            gpuId = gpu3.Product_Id;
            budA = budA - Convert.ToInt32(gpu3.Product_Price);
            budgetGpu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void mem1r_CheckedChanged(object sender, EventArgs e)
        {
            memId = mem1.Product_Id;
            budA = budA - Convert.ToInt32(mem1.Product_Price);
            budgetMem.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void mem2r_CheckedChanged(object sender, EventArgs e)
        {
            memId = mem2.Product_Id;
            budA = budA - Convert.ToInt32(mem2.Product_Price);
            budgetMem.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void mem3r_CheckedChanged(object sender, EventArgs e)
        {
            memId = mem3.Product_Id;
            budA = budA - Convert.ToInt32(mem3.Product_Price);
            budgetMem.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void hard1r_CheckedChanged(object sender, EventArgs e)
        {
            hardId = hard1.Product_Id;
            budA = budA - Convert.ToInt32(hard1.Product_Price);
            budgetHard.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void hard2r_CheckedChanged(object sender, EventArgs e)
        {
            hardId = hard2.Product_Id;
            budA = budA - Convert.ToInt32(hard2.Product_Price);
            budgetHard.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void hard3r_CheckedChanged(object sender, EventArgs e)
        {
            hardId = hard3.Product_Id;
            budA = budA - Convert.ToInt32(hard3.Product_Price);
            budgetHard.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void psu1r_CheckedChanged(object sender, EventArgs e)
        {
            psuId = psu1.Product_Id;
            budA = budA - Convert.ToInt32(psu1.Product_Price);
            budgetPsu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void psu2r_CheckedChanged(object sender, EventArgs e)
        {
            psuId = psu2.Product_Id;
            budA = budA - Convert.ToInt32(psu2.Product_Price);
            budgetPsu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void psu3r_CheckedChanged(object sender, EventArgs e)
        {
            psuId = psu3.Product_Id;
            budA = budA - Convert.ToInt32(psu3.Product_Price);
            budgetPsu.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void case1r_CheckedChanged(object sender, EventArgs e)
        {
            caseId = case1.Product_Id;
            budA = budA - Convert.ToInt32(case1.Product_Price);
            budgetCase.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void case2r_CheckedChanged(object sender, EventArgs e)
        {
            caseId = case2.Product_Id;
            budA = budA - Convert.ToInt32(case2.Product_Price);
            budgetCase.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }

        protected void case3r_CheckedChanged(object sender, EventArgs e)
        {
            caseId = case3.Product_Id;
            budA = budA - Convert.ToInt32(case3.Product_Price);
            budgetCase.InnerHtml = "<h6 class=\"product-title-2\">Budget: " + budA + "</h6>";
        }
    }
}
