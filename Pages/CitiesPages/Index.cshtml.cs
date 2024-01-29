using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab4.Data;
using Lab4.Models;

namespace Lab4.Pages_CitiesPages
{
    public class IndexModel : PageModel
    {
        private readonly Lab4.Data.ApplicationDbContext _context;

        public IndexModel(Lab4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<City> City { get;set; } = default!;

        public async Task OnGetAsync()
        {
            City = await _context.Cities
                .Include(c => c.Province).ToListAsync();
        }
    }
}
