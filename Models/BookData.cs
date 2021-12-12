using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mihaila_Alexandra_Laborator8.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
