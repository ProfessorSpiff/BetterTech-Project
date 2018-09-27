using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class ReportGross : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            Decimal grossRevenue = 0;
            dynamic items = from c in db.Items
                            select c;
            foreach (Item d in items)
            {
                grossRevenue += d.Item_Qty * d.Item_SellingPrice;
            }
             grossRev.InnerHtml = "<h2 class=uppercase mb-30>Gross Revenue: " + grossRevenue + "</h2>";
            Decimal recentRevenue = 0;
            dynamic invoices = from v in db.Invoices
                            select v;
            foreach (Invoice inv in invoices)
            {
                if (inv.Invoice_Date > DateTime.Now.AddMonths(-3))
                {
                    recentRevenue += inv.Invoice_Total;
                }
            }
            recentRev.InnerHtml = "<h2 class=uppercase mb-30>Revenue from past 3 months: " + recentRevenue + "</h2>";
        }
    }
}