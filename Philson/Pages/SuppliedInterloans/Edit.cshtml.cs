using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Philson.Models;

namespace Philson.Pages.SuppliedInterloans
{
    public class EditModel : PageModel
    {
        private readonly Philson.Models.PhilsonContext _context;

        public EditModel(Philson.Models.PhilsonContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SuppliedInterloan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuppliedInterloanExists(SuppliedInterloan.ID))
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

        private bool SuppliedInterloanExists(int id)
        {
            return _context.SuppliedInterloan.Any(e => e.ID == id);
        }
    }
}
