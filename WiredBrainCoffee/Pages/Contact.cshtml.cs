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
        public static IEmailService EmailService { get; set; }
        [BindProperty] public Contact Contact { get; set; }
        [BindProperty] public string Message { get; set; }

        public void OnGet()
        {
            EmailService = new EMailService();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                EmailService.SendEmailWithContact(Contact);
                return new RedirectToPageResult("Confirmation", "Contact");
            }
            return Page();
        }
        public IActionResult OnPostSubscribe(string address)
        {
            EmailService.SendEmail(address);
            return new RedirectToPageResult("Confirmation", "Subscribe");
        }
    }
}
