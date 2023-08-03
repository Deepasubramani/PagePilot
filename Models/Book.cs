using System.ComponentModel.DataAnnotations;

namespace PagePilot.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }
    }
}
