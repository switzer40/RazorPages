using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ContactModel : PageModel
    {
        public IEmailService EmailService { get; set; }
        [BindProperty] public Contact Contact { get; set; }
        [BindProperty] public string Message { get; set; }

        public void OnGet()
        {
            EmailService = new EMailService();
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                //EmailService.SendEmail(Contact);
                Message = "Your email has been sent.";
            }            
        }
        public void OnPostSubscribe(string address)
        {
            Message = "You have been added to the mailing list.";
        }
    }
}
