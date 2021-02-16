using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{

    public class BookGenre
    {
        [ForeignKey("Book")]
        public int BookID { get; set; }
        [ForeignKey("Genre")]
        public int GenreID { get; set; }
    }
}
