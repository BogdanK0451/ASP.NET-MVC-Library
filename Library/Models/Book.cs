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
        public string Isbn { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        [Required]
        public string Genre { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Summary { get; set; }

    }
}
