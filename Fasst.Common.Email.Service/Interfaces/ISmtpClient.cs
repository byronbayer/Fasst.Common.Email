using System.Net.Mail;

namespace Fasst.Common.Email.Service.Interfaces
{
    public interface ISmtpClient
    {
        void Send(MailMessage mailMsg);
    }
}