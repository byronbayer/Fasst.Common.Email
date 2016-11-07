using System.Net.Mail;
using Fasst.Common.Email.Service.Domain;
using Fasst.Common.Email.Service.Interfaces;
using SendGrid;

namespace Fasst.Common.Email.Service.SendGrid
{
    public class EmailDeliveryModeTransport : IEmailDeliveryMode
    {
        private readonly ITransport _transport;

        public EmailDeliveryModeTransport(ITransport transport)
        {
            _transport = transport;
        }

        public void Send(EmailSettings emailSettings)
        {
            ISendGrid mail = new SendGridMessage();
            mail.From = new MailAddress(emailSettings.FromAddress, emailSettings.FromName);
            mail.AddTo(emailSettings.EmailAddresses);
            mail.Subject = emailSettings.Subject;
            mail.Html = emailSettings.Body;
            var deliverAsync = _transport.DeliverAsync(mail);
        }
    }
}