using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace EnvioEmails.Clases
{
     public static class EmailManager           //internal
    {
        public static SmtpClient CreateSmtpClient()
        {
            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];
            string host = ConfigurationManager.AppSettings["host"];
            int port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);

            SmtpClient smtpClient= new SmtpClient();   ///Opcion abreviada--> SmtpClient smtpClient= new();

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(username, password);        // Aqui confihuramos id y password
            smtpClient.Host = host;
            smtpClient.Port = port;

            return smtpClient;
        }

        // Creamos el objeto que nos enviara el msg
        public static MailMessage CreateMailMessage(string from, string to, string subjet, string body, bool isHTML = false)
        {
            var mailMessage = new MailMessage(from, to, subjet, body);

            mailMessage.IsBodyHtml = isHTML;
            return mailMessage;
        }

        //Método para enviar el email
        public static void SendEmail(MailMessage mailMessage)
        {
            try         //Ctrl por si el email falla
            {
                using (var smtpClient = CreateSmtpClient())     //Con esto se "disposeará" el objeto
                {
                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Ocurrio un error : {ex}");
                Console.ReadKey();
            }
            finally
            {
                mailMessage.Dispose();      // Gestionamos el dispose del email
            }
            
        }
    }
}
