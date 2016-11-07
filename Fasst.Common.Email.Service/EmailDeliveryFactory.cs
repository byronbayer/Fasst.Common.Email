using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using Fasst.Common.Email.Service.Interfaces;
using Fasst.Common.Email.Service.SendGrid;
using Fasst.Common.Email.Service.SMTP;
using SendGrid;

namespace Fasst.Common.Email.Service
{
    public static class EmailDeliveryFactory
    {
        public static IEmailDeliveryMode GetEmailDeliveryMode(string emailService)
        {
            var userName = ConfigurationManager.AppSettings["UserName"];
            var password = ConfigurationManager.AppSettings["Password"];

            EmailEnums emailServiceEnum;
            if (!Enum.TryParse(emailService, true, out emailServiceEnum))
            {
                throw new Exception("Email Service Not Found");
            }


            switch (emailServiceEnum)
            {
                case EmailEnums.SendGrid:
                {
                    var credentials = new NetworkCredential(userName, password);
                    var web = new Web(credentials);
                    return new EmailDeliveryModeTransport(web);
                }
                case EmailEnums.SMTP:
                {
                    var smtpClient = new SmtpClientWrapper(new SmtpClient());
                    return new EmailDeliveryModeSmtp(smtpClient);
                }
                default:
                    throw new Exception("Email service not implemented");
            }
        }
    }
}