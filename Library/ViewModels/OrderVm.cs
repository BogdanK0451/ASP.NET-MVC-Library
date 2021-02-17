using System;
using Library.Models;

namespace Library.ViewModels
{
    public class OrderVm
    {
        public Order Order;
        public string FullName;
        public string BookISBN;
        public string BookName;
        public string BookAuthor;
        public DateTime RequestedOn;
        
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
