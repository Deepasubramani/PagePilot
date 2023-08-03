using System.ComponentModel.DataAnnotations;

namespace PagePilot.Models
{
    public class UserFavorite
    {
        [Key]
        public int BookId { get; set; }
        [Key]
        public string UserId { get; set; }
        public bool IsFavorite { get; set; }

        public int Rating { get; set; }

        public virtual Book Book { get; set; }
    }
}
