using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace MachineTest.Models
{
    public class SendEmail
    {
        public void SendEmailMethod(string mailto)
        {
            try
            {
                MailMessage mail = new MailMessage();

                SmtpClient smtp = new SmtpClient();

                mail.From = new MailAddress("senders mail address");
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = "welcome to machine test";
                mail.Body = "congrats !!";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";

                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("senders mail address", "password");

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(mail);
            }
            catch(Exception)
            {

            }
        
        }

    }
}