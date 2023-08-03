using System.ComponentModel.DataAnnotations;

namespace PagePilot.Models
{
    public class BookmarkView
    {
        [Key]
        public int BookId { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public bool IsFavorite { get; set; }

        public int Rating { get; set; }
    }
}
