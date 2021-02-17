using System;
using Library.Models;

namespace Library.ViewModels
{
    public class ReservationsVm
    {
        public ReservationsVm(int ID, int BookID, string BookISBN, string BookName, string BookAuthor,
            DateTime RequestedAt, int UserID, string FullName)
        {
            this.ID = ID;
            this.BookID = BookID;
            this.BookISBN = BookISBN;
            this.BookName = BookName;
            this.BookAuthor = BookAuthor;
            this.RequestedAt = RequestedAt;
            this.UserID = UserID;
            this.FullName = FullName;
        }

        public int ID { get; set; }
        public int BookID { get; set; }
        public string BookISBN { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public DateTime RequestedAt { get; set; }
        public int UserID { get; set; }
        public string FullName { get; set; }
        public BorrowedBook BorrowedBook { get; set; }

    }
}
