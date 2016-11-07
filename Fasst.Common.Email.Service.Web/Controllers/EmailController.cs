using System.Configuration;
using System.Web.Http;
using Fasst.Common.Email.Service.DataContracts;
using Fasst.Common.Email.Service.Domain;

namespace Fasst.Common.Email.Service.Web.Controllers
{
    [Authorize]
    public class EmailController : ApiController
    {
        // GET api/values
        public void SendEmail(EmailSettings emailSettings)
        {
            var emailDeliveryMode = EmailDeliveryFactory.GetEmailDeliveryMode(ConfigurationManager.AppSettings["EmailDeliveryMode"]);
            IEmailService emailService = new EmailService(emailDeliveryMode);
            emailService.EmailUsers(emailSettings);
        }
    }
}