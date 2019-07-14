using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Philson.Models;

namespace Philson.Pages.ReceivedInterloans
{
    public class DeleteModel : PageModel
    {
        private readonly Philson.Models.PhilsonContext _context;

        public DeleteModel(Philson.Models.PhilsonContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReceivedInterloan = await _context.ReceivedInterloan.FindAsync(id);

            if (ReceivedInterloan != null)
            {
                _context.ReceivedInterloan.Remove(ReceivedInterloan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
