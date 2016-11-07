using System.Collections.Generic;
using Fasst.Common.Email.Service.DataContracts;
using Fasst.Common.Email.Service.Domain;
using NUnit.Framework;

namespace Fasst.Common.Email.Service.Tests.Integration
{
    [TestFixture]
    public class Sending_Email
    {
        [Test]
        [TestCase("SendGrid", "Sent with SendGrid using Framework", "Sent with SendGrid using Framework")]
        [TestCase("SMTP", "Sent with SendGrid using SMTP", "Sent with SendGrid using SMTP")]
        public void Using_SendGrid(string emailServiceType, string body, string subject)
        {
            IEmailService emailService = new EmailService(EmailDeliveryFactory.GetEmailDeliveryMode(emailServiceType));
            var emailSettings = new EmailSettings
            {
                Body = body,
                EmailAddresses = new List<string>
                {
                    "byronbayer@hotmail.com"
                },
                FromAddress = "logging@byronbayer.com",
                FromName = "Byronbayer Support",
                Subject = subject
            };
            emailService.EmailUsers(emailSettings);
        }
    }
}