//https://www.entityframeworktutorial.net/code-first/simple-code-first-example.aspx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//used to attach metadata to class fields, which are used by the DBMS to create the database?
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(13,MinimumLength =13)]
        public string Isbn { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        [Required]
        public string Genre { get; set; }
        public DateTime? YearWritten { get; set; }
        [Required]
        public int Pages { get; set; }
        public string Summary { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name ="Cover")]
        public string ImageUrl { get; set; }
        //does required imply that the field is required during Form filling or inside the database or both?
        public bool Taken { get; set; } = false;

    }
}
