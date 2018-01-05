using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Common
{
    public static class Mail
    {

        public static string SendMail(string host, int port, string userName, string password, string fromAddress, string toAddress, string subject, string message)
        {
            string errorMessage = "";

            try
            {
                MailMessage mail = new MailMessage();

                SmtpClient smtpServer = new SmtpClient(host);
                smtpServer.UseDefaultCredentials = false;
                smtpServer.Credentials = new System.Net.NetworkCredential(userName, password);
                smtpServer.EnableSsl = true;
                smtpServer.Port = port; 

                mail.From = new MailAddress(fromAddress);
                mail.To.Add(toAddress);
                mail.Subject = subject;
                mail.Body = message;

                smtpServer.Send(mail);
            }
            catch (WebException webError)
            {
                errorMessage = webError.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            return errorMessage;
        }

    }

}
