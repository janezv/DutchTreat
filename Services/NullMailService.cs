using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Services
{
    public class NullMailService : IMailService
    {

        public ILogger<NullMailService> _Logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _Logger = logger;
        }


        public void SendMessage(string to, string subject, string body)
        {
            _Logger.LogInformation($"To:{to}  Subject:{subject}  Body:{body}");
        }
    }
}
