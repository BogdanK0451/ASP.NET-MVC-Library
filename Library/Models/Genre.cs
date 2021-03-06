﻿using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        [StringLength(30,MinimumLength=3)]
        public string GenreName { get; set; }
    }
}
