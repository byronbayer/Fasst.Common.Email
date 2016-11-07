using Fasst.Common.Email.Service.DataContracts;
using Fasst.Common.Email.Service.Domain;
using Fasst.Common.Email.Service.Interfaces;

namespace Fasst.Common.Email.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SendGridEmailService" in both code and config file together.
    public class EmailService : IEmailService
    {
        private readonly IEmailDeliveryMode _emailDeliveryMode;

        public EmailService()
        {
            
        }

        public EmailService(IEmailDeliveryMode emailDeliveryMode)
        {
            _emailDeliveryMode = emailDeliveryMode;
        }

        public void EmailUsers(EmailSettings emailSettings)
        {
            _emailDeliveryMode.Send(emailSettings);
        }
    }
}