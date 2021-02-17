using System;

namespace Library.ViewModels
{
    public class BorrowedBookVm
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReturnBy { get; set; }

        public BorrowedBookVm(string Title, string Author, DateTime returnBy)
        {
            this.Title = Title;
            this.Author = Author;
            this.ReturnBy = returnBy;
        }
    }
}
