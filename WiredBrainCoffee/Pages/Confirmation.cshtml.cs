using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WiredBrainCoffee.Pages
{
    public class ConfirmationModel : PageModel
    {
        [BindProperty] public string Message { get; set; }
        public void OnGetContact()
        {
            Message = "Your email was sent to our team.";
        }
        public void OnGetSubscribe()
        {
            Message = "You have been added to our mailing list.";
        }
    }
}