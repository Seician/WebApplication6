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
    public class IndexModel : PageModel
    {
        private readonly WebApplication6.Data.WebApplication6Context _context;

        public IndexModel(WebApplication6.Data.WebApplication6Context context)
        {
            _context = context;
        }

        public IList<Operatiune> Operatiune { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Operatiune != null)
            {
                Operatiune = await _context.Operatiune
                .Include(o => o.Angajat)
                .ThenInclude(b=>b.Operatiuni)
                .ToListAsync();
            }
        }
    }
}
