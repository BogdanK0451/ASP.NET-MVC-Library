namespace Library.ViewModels
{
    using Library.Models;
    using System.Collections.Generic;

    public class PopularVm
    {
        IEnumerable<Book> PopularBooks { get; set; }

        public PopularVm(IEnumerable<Book> popularBooks)
        {
            PopularBooks = popularBooks;
        }
    }
}
