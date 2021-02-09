using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext (DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        public DbSet<Library.Models.Book> Book { get; set; }
    }
}
