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
    public class EditModel : PageModel
    {
        private readonly WebApplication6.Data.WebApplication6Context _context;

        public EditModel(WebApplication6.Data.WebApplication6Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Operatiune Operatiune { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Operatiune == null)
            {
                return NotFound();
            }

            var operatiune =  await _context.Operatiune.FirstOrDefaultAsync(m => m.ID == id);
            if (operatiune == null)
            {
                return NotFound();
            }
            Operatiune = operatiune;
           ViewData["AngajatID"] = new SelectList(_context.Angajat, "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Operatiune).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperatiuneExists(Operatiune.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OperatiuneExists(int id)
        {
          return _context.Operatiune.Any(e => e.ID == id);
        }
    }
}
