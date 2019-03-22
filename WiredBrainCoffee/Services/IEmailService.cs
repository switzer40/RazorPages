using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public interface IEmailService
    {
        void SendEmail(Contact contact);
    }
}