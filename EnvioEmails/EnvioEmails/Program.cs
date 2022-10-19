using EnvioEmails.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        // var smptClient = EmailManager.CreateSmtpClient();
        var mailMessage = EmailManager.CreateMailMessage(
            "mail@rplweb.com", 
            "admon@rplweb.com", 
            "Test C#", 
            "Si lees esto es que funciona");

        EmailManager.SendEmail(mailMessage);

    }
}