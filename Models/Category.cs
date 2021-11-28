using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mihaila_Alexandra_Laborator8.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
