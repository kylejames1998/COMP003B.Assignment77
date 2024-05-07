using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment77.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string AuthorName { get; set; }

        // Collection navigation property
        public virtual ICollection<BookAuthor>? BookAuthors { get; set; }

        public int BookCount { get; set; } // new property
    }
}