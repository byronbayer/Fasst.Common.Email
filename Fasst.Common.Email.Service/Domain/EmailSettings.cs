using System.Collections.Generic;

namespace Fasst.Common.Email.Service.Domain
{
    public class EmailSettings
    {
        public List<string> EmailAddresses { get; set; }

        public string FromName { get; set; }

        public string FromAddress { get; set; }

        public string Subject { get; set; }
        
        public string Body { get; set; }
    }
}