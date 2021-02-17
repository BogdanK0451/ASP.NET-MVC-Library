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

        public BorrowedBook(int UserID,int BookID)
        {
            this.UserID = UserID;
            this.BookID = BookID;
        }
    }
}
