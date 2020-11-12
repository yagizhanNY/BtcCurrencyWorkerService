using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Mail.Library
{
    public class MailManager
    {
        public void SendMail(double currentValue, List<string> mailToList, string username, string password)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                mailMessage.From = new MailAddress("ynybtcservice@yny.com");

                foreach (var mail in mailToList)
                {
                    mailMessage.To.Add(mail);
                }
                
                mailMessage.Subject = "BTC Currency Change Alert!";
                mailMessage.Body = $"BTC/TRY currency is changed! Current currency is: {currentValue}";

                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(username, password);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);
            }
            catch
            {
                throw new ArgumentException("Mail Error");
            }
            
        }
    }
}
