using Fasst.Common.Email.Service.Domain;

namespace Fasst.Common.Email.Service.Interfaces
{
    public interface IEmailDeliveryMode
    {
        void Send(EmailSettings emailSettings);
    }
}