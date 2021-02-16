using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;


//haven't used yet, needs to be implemented
namespace Library.ViewModels
{
    public class BooksAndGenres
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
