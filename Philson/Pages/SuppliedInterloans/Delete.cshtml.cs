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
    public class DeleteModel : PageModel
    {
        private readonly Philson.Models.PhilsonContext _context;

        public DeleteModel(Philson.Models.PhilsonContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SuppliedInterloan = await _context.SuppliedInterloan.FindAsync(id);

            if (SuppliedInterloan != null)
            {
                _context.SuppliedInterloan.Remove(SuppliedInterloan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
