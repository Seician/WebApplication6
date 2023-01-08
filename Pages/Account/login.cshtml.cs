using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Net;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace WebApplication6.Pages.Account
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }

    public class Credential
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
