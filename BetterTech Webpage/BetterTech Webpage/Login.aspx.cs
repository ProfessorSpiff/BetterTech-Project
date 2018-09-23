using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Secrecy;

namespace BetterTech_Webpage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();
            dynamic userL = from u in db.Users
                            select u;
            string display = "";
            foreach (User x in userL)
            {
                if (x.Email == loginEmail.Value)
                {
                    if (x.Password == Secrecy.Secrecy.HashPassword(loginPassword.Value))
                    {
                        Session["Username"] = x.Username;
                        Session["AuthLevel"] = x.UserType;
                        Response.Redirect("index.html");
                    }
                    else
                    {
                        error.Visible = true;
                        display = "<strong>Oh snap!</strong> Username or password was incorrect.";
                        error.InnerHtml = display;
                    }
                }
                else
                {
                    error.Visible = true;
                    display = "<strong>Oh snap!</strong> Username or password was incorrect.";
                    error.InnerHtml = display;
                }
            }
        }
    }
}