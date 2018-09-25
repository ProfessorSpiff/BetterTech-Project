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
                        Response.Redirect("index.aspx");
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

        protected void regBtn_Click(object sender, EventArgs e)
        {
            var db = new DataLinqDataContext();

            dynamic users = from a in db.Users
                            select a;

            var user = username.Value;
            var password1 = Secrecy.Secrecy.HashPassword(pass1.Value);
            var password2 = Secrecy.Secrecy.HashPassword(pass2.Value);

            bool isReg = false;
            foreach(User u in users){
                if(u.Username == user)
                {
                    alertReg.InnerHtml = "<strong>Oh snap!</strong> Username already exists.";
                    isReg = true;
                    if(u.Email == email.Value)
                    {
                        alertReg.InnerHtml = "<strong>Oh snap!</strong> Email already exists.";
                        isReg = true;
                    }
                }
            }
            if(password1 != password2)
            {
                alertReg.InnerHtml = "<strong>Oh snap!</strong> Passwords do not match";
            }
            if(isReg == false)
            {
                User regUser = new User
                {
                    Username = user,
                    Password = password1,
                    UserType = "User",
                    FirstName = firstname.Value,
                    Surname = lastname.Value,
                    Email = email.Value,
                    AddressLine1 = add1.Value,
                    AddressLine2 = add2.Value,
                    ZipCode = zip.Value
                };
                db.Users.InsertOnSubmit(regUser);
                try
                {
                    db.SubmitChanges();
                    Session["AuthLevel"] = "User";
                    Session["Username"] = user;
                    Response.Redirect("index.aspx");
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                }
            }
        }
    }
}