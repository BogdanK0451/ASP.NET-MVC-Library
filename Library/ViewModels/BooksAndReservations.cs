using System.Collections.Generic;
using Library.Models;

namespace Library.ViewModels
{
    public class BooksAndReservations
    {
        public BooksAndReservations(IEnumerable<Book> Books, int reservedBooksByUser)
        {
            this.Books = Books;
            this.ReservedBooksByUser = reservedBooksByUser;
        }
        public IEnumerable<Book> Books { get; set; }
        public Reservation Reservation { get; set; }
        public int ReservedBooksByUser { get; set; }
    }

}
