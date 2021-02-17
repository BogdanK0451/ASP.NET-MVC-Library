using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class BorrowedBook
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }

        public BorrowedBook(int UserID,int BookID,int OrderID)
        {
            this.UserID = UserID;
            this.BookID = BookID;
            this.OrderID = OrderID;
        }
    }
}
