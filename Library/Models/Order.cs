using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Reservation")]
        public int ReservationID { get; set; }
        [ForeignKey("User")]
        public int CustomerID { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }
        public DateTime ReturnBy { get; set; }
        public DateTime? ReturnedOn { get; set; } = null;
        public string Status { get; set; } = "active";
        
        public Order(int ReservationID, int CustomerID, int BookID)
        {
            this.ReservationID = ReservationID;
            this.CustomerID = CustomerID;
            this.BookID = BookID;
            this.ReturnBy = DateTime.Now + new TimeSpan(14, 0, 0, 0);
            
        }
        public Order(Order Order)
        {
            this.ReservationID = Order.ReservationID;
            this.CustomerID = Order.CustomerID;
            this.BookID = Order.BookID;
            this.ReturnBy = Order.ReturnBy;
        }

    }
}
