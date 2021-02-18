using System.Collections.Generic;
using Library.Models;

namespace Library.ViewModels
{
    public class BooksAndReservations
    {
        public IEnumerable<Book> Books { get; set; }
        //the field below is pointless but it is used for supplementing "asp-for" attribute in submit form inputs
        //used because of lack of knowledge of what asp-for attribute does, same mistake hasn't been made in more recent forms
        public Reservation Reservation { get; set; }
        public int ReservedBooksByUser { get; set; }

        public BooksAndReservations(IEnumerable<Book> Books, int reservedBooksByUser)
        {
            this.Books = Books;
            this.ReservedBooksByUser = reservedBooksByUser;
        }
    }

}
