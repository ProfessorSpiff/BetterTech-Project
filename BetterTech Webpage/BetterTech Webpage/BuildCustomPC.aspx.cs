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
            cpuPer = 0.3;
            gpuPer = 0.2;
            chosen = true;
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
