using System.Collections.Generic;
using Library.Models;

namespace Library.ViewModels
{
    public class BooksAndReservations
    {
        public BooksAndReservations(IEnumerable<Book> Books)
        {
            this.Books = Books;
        }
        public IEnumerable<Book> Books { get; set; }
        public Reservation Reservation { get; set; }
    }

}
