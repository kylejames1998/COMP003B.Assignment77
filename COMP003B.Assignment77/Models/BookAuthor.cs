using COMP003B.Assignment77.Models;
using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment77.Models
{
    public class BookAuthor
    {
        public int BookAuthorId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int AuthorId { get; set; }

        // collection navigation property
        public virtual Book? Book { get; set; }
        public virtual Author? Author { get; set; }
    }
}
