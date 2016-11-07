using System.Net.Mail;
using Fasst.Common.Email.Service.Interfaces;

namespace Fasst.Common.Email.Service.SMTP
{
    public class SmtpClientWrapper : ISmtpClient
    {
        private readonly SmtpClient _smtpClient;

        public SmtpClientWrapper(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public void Send(MailMessage mailMsg)
        {
            _smtpClient.Send(mailMsg);
        }
    }
}