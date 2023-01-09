using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Data;
using WebApplication6.Models;

namespace WebApplication6.Pages.Operatiuni
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

            var carList = _context.Client
                .Include(b => b.Autovehicul)
                .Select(x => new
 {
     x.ID,
     CarFullName = x.CarID + " - " + x.Autovehicul.Marca + " " +
x.Autovehicul.An
 });
            ViewData["CarID"] = new SelectList(carList, "ID",
"CarFullName");
            ViewData["AngajatID"] = new SelectList(_context.Angajat, "ID", "FullName");
            return Page();
        }

        [BindProperty]
        public Operatiune Operatiune { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Operatiune.Add(Operatiune);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
