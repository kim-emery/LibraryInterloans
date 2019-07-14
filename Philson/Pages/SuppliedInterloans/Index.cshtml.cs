using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Philson.Models;

namespace Philson.Pages.SuppliedInterloans
{
    public class IndexModel : PageModel
    {
        private readonly Philson.Models.PhilsonContext _context;

        public IndexModel(Philson.Models.PhilsonContext context)
        {
            _context = context;
        }

        public IList<SuppliedInterloan> SuppliedInterloan { get;set; }

        public async Task OnGetAsync()
        {
            SuppliedInterloan = await _context.SuppliedInterloan.ToListAsync();
        }
    }
}
