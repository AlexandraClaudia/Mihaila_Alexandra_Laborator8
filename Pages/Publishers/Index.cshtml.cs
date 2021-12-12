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
    public class IndexModel : PageModel
    {
        private readonly Mihaila_Alexandra_Laborator8.Data.Mihaila_Alexandra_Laborator8Context _context;

        public IndexModel(Mihaila_Alexandra_Laborator8.Data.Mihaila_Alexandra_Laborator8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }
        public BookData BookD { get; set; }
        public int BookID { get; set; }
        public int CategoryID { get; set; }
        public async Task OnGetAsync(int? id, int? categoryID)
        {
            BookD = new BookData();

            BookD.Books = await _context.Book.Include(b => b.Publisher).Include(b => b.BookCategories).ThenInclude(b => b.Category).AsNoTracking().OrderBy(b => b.Title) .ToListAsync();
            if (id != null)
            {
                BookID = id.Value;
                Book book = BookD.Books
                .Where(i => i.ID == id.Value).Single();
                BookD.Categories = book.BookCategories.Select(s => s.Category);
            }
        }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
