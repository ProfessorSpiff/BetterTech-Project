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

            foreach (User u in regUsers)
            {
                if(u.DateRegistered == DateTime.Now)
                {
                    day1++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-1))
                {
                    day2++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-2))
                {
                    day3++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-3))
                {
                    day4++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-4))
                {
                    day5++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-5))
                {
                    day6++;
                }
                if (u.DateRegistered == DateTime.Now.AddDays(-6))
                {
                    day7++;
                }
            }
            
        }
    }
}