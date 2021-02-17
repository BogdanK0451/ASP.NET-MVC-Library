using System;
using Library.Models;

namespace Library.ViewModels
{
    public class OrderVm
    {
        public Order Order { get; set; }
        public string FullName { get; set; }
        public string BookISBN { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public DateTime RequestedOn { get; set; }
        
        public OrderVm(Order Order,string FullName, string BookISBN,string BookName,string BookAuthor)
        {
            this.Order = Order;
            this.FullName = FullName;
            this.BookISBN = BookISBN;
            this.BookName = BookName;
            this.BookAuthor = BookAuthor;
            RequestedOn = Order.ReturnBy - new TimeSpan(14, 0, 0, 0);
        }
    }
}
