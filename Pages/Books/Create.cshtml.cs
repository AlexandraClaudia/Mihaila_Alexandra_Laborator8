using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mihaila_Alexandra_Laborator8.Data;
using Mihaila_Alexandra_Laborator8.Models;

namespace Mihaila_Alexandra_Laborator8.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Mihaila_Alexandra_Laborator8.Data.Mihaila_Alexandra_Laborator8Context _context;

        public CreateModel(Mihaila_Alexandra_Laborator8.Data.Mihaila_Alexandra_Laborator8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
