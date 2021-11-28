using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihaila_Alexandra_Laborator8.Data;
using Mihaila_Alexandra_Laborator8.Models;

namespace Mihaila_Alexandra_Laborator8.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Mihaila_Alexandra_Laborator8.Data.Mihaila_Alexandra_Laborator8Context _context;

        public DetailsModel(Mihaila_Alexandra_Laborator8.Data.Mihaila_Alexandra_Laborator8Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
