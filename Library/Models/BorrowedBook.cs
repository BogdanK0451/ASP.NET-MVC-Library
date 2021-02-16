using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class BorrowedBook
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int CustomerID { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }
        public DateTime Taken { get; set; }
        public DateTime ReturnBy { get; set; }
    }
}
