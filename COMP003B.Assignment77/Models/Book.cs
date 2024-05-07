using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment77.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string BookName { get; set; }

        [Required]
        public string BookDescription { get; set; }

        // Collection navigation property
        public virtual ICollection<BookAuthor>? BookAuthors { get; set; }
    }
}