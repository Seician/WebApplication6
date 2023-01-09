using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Data;
using WebApplication6.Models;

namespace WebApplication6.Pages.Operatiuni
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication6.Data.WebApplication6Context _context;

        public DetailsModel(WebApplication6.Data.WebApplication6Context context)
        {
            _context = context;
        }

      public Operatiune Operatiune { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Operatiune == null)
            {
                return NotFound();
            }

            var operatiune = await _context.Operatiune.FirstOrDefaultAsync(m => m.ID == id);
            if (operatiune == null)
            {
                return NotFound();
            }
            else 
            {
                Operatiune = operatiune;
            }
            return Page();
        }
    }
}
