using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication6.Data;
using WebApplication6.Models;

namespace WebApplication6.Pages.Clienti
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication6.Data.WebApplication6Context _context;

        public CreateModel(WebApplication6.Data.WebApplication6Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            {
                ViewData["CarID"] = new SelectList(_context.Set<Autovehicul>(), "ID", "MarcaAutovehicul");
                return Page();
            }
        }
        [BindProperty]
        public Client Client { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
