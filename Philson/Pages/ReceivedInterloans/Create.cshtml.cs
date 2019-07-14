using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Philson.Models;

namespace Philson.Pages.ReceivedInterloans
{
    public class CreateModel : PageModel
    {
        private readonly Philson.Models.PhilsonContext _context;

        public CreateModel(Philson.Models.PhilsonContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ReceivedInterloan ReceivedInterloan { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ReceivedInterloan.Add(ReceivedInterloan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}