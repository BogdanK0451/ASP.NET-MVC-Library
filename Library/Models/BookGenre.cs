using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{

    public class BookGenre
    {
        //supposed to be storing every genre per book     
        [ForeignKey("Book")]
        public int BookID { get; set; }
        [ForeignKey("Genre")]
        public int GenreID { get; set; }
    }
}
