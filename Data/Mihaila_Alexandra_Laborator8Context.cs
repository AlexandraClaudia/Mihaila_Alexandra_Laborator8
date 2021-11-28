using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mihaila_Alexandra_Laborator8.Models;

namespace Mihaila_Alexandra_Laborator8.Data
{
    public class Mihaila_Alexandra_Laborator8Context : DbContext
    {
        public Mihaila_Alexandra_Laborator8Context (DbContextOptions<Mihaila_Alexandra_Laborator8Context> options)
            : base(options)
        {
        }

        public DbSet<Mihaila_Alexandra_Laborator8.Models.Book> Book { get; set; }

        public DbSet<Mihaila_Alexandra_Laborator8.Models.Publisher> Publisher { get; set; }
    }
}
