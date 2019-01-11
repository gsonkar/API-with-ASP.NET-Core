using System.Diagnostics;

namespace CityInfo.API.ResourceManipulation.Services
{
    public class LocalMailService :IMailService
    {
        private string _mailTo = Startup.Configuration["mailSettings:mailToAddress"];
        private string _mailFrom = Startup.Configuration["mailSettings:mailFromAddress"];

        public void Send(string subject, string message)
        {
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo},with Local MailServices");
            Debug.WriteLine($"Subject : {subject}");
            Debug.WriteLine($"Message : {message}");
        }

    }
}
