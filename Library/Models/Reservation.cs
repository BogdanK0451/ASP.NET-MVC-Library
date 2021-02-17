using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Reservation
    {   [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}
