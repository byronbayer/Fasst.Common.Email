using System.Net.Mail;
using Fasst.Common.Email.Service.Domain;
using Fasst.Common.Email.Service.Interfaces;

namespace Fasst.Common.Email.Service.SMTP
{
    public class EmailDeliveryModeSmtp : IEmailDeliveryMode
    {
        private readonly ISmtpClient _smtpClient;


        public EmailDeliveryModeSmtp(ISmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public void Send(EmailSettings emailSettings)
        {
            var mail = new MailMessage
            {
                Subject = emailSettings.Subject,
                Body = emailSettings.Body,
                From = new MailAddress(emailSettings.FromAddress, emailSettings.FromName)
            };
            mail.To.Add(string.Join(",", emailSettings.EmailAddresses));
            _smtpClient.Send(mail);
        }
    }
}