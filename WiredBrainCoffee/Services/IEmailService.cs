using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public interface IEmailService
    {
        void SendEmailWithContact(Contact contact);
        void SendEmail(string address);
    }
}