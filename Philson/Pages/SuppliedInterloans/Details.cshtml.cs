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
    public class DetailsModel : PageModel
    {
        private readonly Philson.Models.PhilsonContext _context;

        public DetailsModel(Philson.Models.PhilsonContext context)
        {
            _context = context;
        }

        public SuppliedInterloan SuppliedInterloan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SuppliedInterloan = await _context.SuppliedInterloan.FirstOrDefaultAsync(m => m.ID == id);

            if (SuppliedInterloan == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
