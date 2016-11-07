using Fasst.Common.Email.Service.Domain;

namespace Fasst.Common.Email.Service.DataContracts
{
    
    public interface IEmailService
    {
                void EmailUsers(EmailSettings emailSettings);
    }
}