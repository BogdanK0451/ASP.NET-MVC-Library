using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;

namespace Library.ViewModels
{
    public class BooksAndReservations
    {
        public IEnumerable<Book> Books { get; set; }
        public Reservation Reservation { get; set; }
        
        
        public BooksAndReservations(IEnumerable<Book> Books)
        {
            this.Books = Books;
        }
    }

}
