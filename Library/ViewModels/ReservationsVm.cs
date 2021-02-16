using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;

namespace Library.ViewModels
{
    public class ReservationsVm
    {
        public int ID;
        public int BookID;
        public string BookISBN;
        public string BookName;
        public string BookAuthor;
        public DateTime RequestedAt;
        public int UserID;
        public string FullName;

        public ReservationsVm(int ID, int BookID, string BookISBN, string BookName,string BookAuthor,
            DateTime RequestedAt,int UserID,string FullName)
        {
           this.ID = ID;
           this.BookID = BookID;
           this.BookISBN = BookISBN;
           this.BookName=BookName;
           this.BookAuthor=BookAuthor;
           this.RequestedAt=RequestedAt;
           this.UserID=UserID;
           this.FullName=FullName;

        }
    }
}
