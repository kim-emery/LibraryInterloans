using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Philson.Models;

namespace Philson.Pages.ReceivedInterloans
{
    public class EditModel : PageModel
    {
        private readonly Philson.Models.PhilsonContext _context;

        public EditModel(Philson.Models.PhilsonContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ReceivedInterloan ReceivedInterloan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReceivedInterloan = await _context.ReceivedInterloan.FirstOrDefaultAsync(m => m.ID == id);

            if (ReceivedInterloan == null)
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

            _context.Attach(ReceivedInterloan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReceivedInterloanExists(ReceivedInterloan.ID))
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

        private bool ReceivedInterloanExists(int id)
        {
            return _context.ReceivedInterloan.Any(e => e.ID == id);
        }
    }
}
