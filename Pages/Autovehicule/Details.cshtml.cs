using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Data;
using WebApplication6.Models;

namespace WebApplication6.Pages.Autovehicule
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication6.Data.WebApplication6Context _context;

        public DetailsModel(WebApplication6.Data.WebApplication6Context context)
        {
            _context = context;
        }

      public Autovehicul Autovehicul { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Autovehicul == null)
            {
                return NotFound();
            }

            var autovehicul = await _context.Autovehicul.FirstOrDefaultAsync(m => m.Id == id);
            if (autovehicul == null)
            {
                return NotFound();
            }
            else 
            {
                Autovehicul = autovehicul;
            }
            return Page();
        }
    }
}
