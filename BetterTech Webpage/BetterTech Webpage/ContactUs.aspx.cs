using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetterTech_Webpage
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitMessage_Click(object sender, EventArgs e)
        {
             string email = txtEmail.Value.Trim();
             string name = txtName.Value.Trim();
             string subject = txtSubject.Value.Trim();
             string password = txtPassword.Value.Trim();
             string message = txtMessage.Value.Trim();

            if ((email.Equals("")) || (name.Equals("")) || (subject.Equals("")) || (password.Equals("")) || (message.Equals("")))
            {
                missingField.Visible = true;
            }
            else
            {
                if(missingField.Visible) missingField.Visible = false;

                string to = "betterbettertech@gmail.com"; //To address    
                string from = email; //From address    
                MailMessage mailMessage = new MailMessage(from, to);

                mailMessage.Subject = subject;
                mailMessage.Body = message;
                mailMessage.BodyEncoding = Encoding.UTF8;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential(email, password);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(mailMessage);
                }

                catch (Exception ex)
                {
                    missingField.InnerText = "This email address is not valid";
                    missingField.Visible = true;

                }

                messageSent.Visible = true;
            }
        }
    }
}