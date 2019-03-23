using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public class EMailService : IEmailService
    {
        public void SendEmailWithContact(Contact contact)
        {
            SendEmail(contact.Email);
        }
        public void SendEmail(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                Complain(address);
            }
        }

        private void Complain(string address)
        {
            var message = $"The email address {address} is not valid";
        }
    }
}
