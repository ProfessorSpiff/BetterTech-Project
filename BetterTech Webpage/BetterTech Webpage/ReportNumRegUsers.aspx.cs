using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class ReportNumRegUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            var regUsers = from a in db.Users
                           select a;
            int day1 = 0;
            int day2 = 0;
            int day3 = 0;
            int day4 = 0;
            int day5 = 0;
            int day6 = 0;
            int day7 = 0;

            int numRegs = (from User b in db.Users
                          select b).Count();
            numReg.InnerHtml = "<h2>" + numRegs + "</h2>";
            foreach (User u in regUsers)
            {
                if(u.DateRegistered == DateTime.Now.Date)
                {
                    day1++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-1).Date)
                {
                    day2++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-2).Date)
                {
                    day3++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-3).Date)
                {
                    day4++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-4).Date)
                {
                    day5++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-5).Date)
                {
                    day6++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-6).Date)
                {
                    day7++;
                }
            }
            string display = "";
            display += "<h3>" + DateTime.Now.Date + "</h3><br>";
            display += "<h4>" + day1 + "</h4><br><hr>";
            display += "<h3>" + DateTime.Now.AddDays(-1).Date + "</h3><br>";
            display += "<h4>" + day2 + "</h4><br><hr>";
            display += "<h3>" + DateTime.Now.AddDays(-2).Date + "</h3><br>";
            display += "<h4>" + day3 + "</h4><br><hr>";
            display += "<h3>" + DateTime.Now.AddDays(-3).Date + "</h3><br>";
            display += "<h4>" + day4 + "</h4><br><hr>";
            display += "<h3>" + DateTime.Now.AddDays(-4).Date + "</h3><br>";
            display += "<h4>" + day5 + "</h4><br><hr>";
            display += "<h3>" + DateTime.Now.AddDays(-5).Date + "</h3><br>";
            display += "<h4>" + day6 + "</h4><br><hr>";
            display += "<h3>" + DateTime.Now.AddDays(-6).Date + "</h3><br>";
            display += "<h4>" + day7 + "</h4>";
            numRegGraph.InnerHtml = display;
        }
    }
}