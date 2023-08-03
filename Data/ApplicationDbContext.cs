using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PagePilot.Models;

namespace PagePilot.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserFavorite>()
            .HasKey(t => new { t.UserId, t.BookId });
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<UserFavorite> UserFavorites { get; set; }
        public DbSet<PagePilot.Models.BookmarkView> BookmarkView { get; set; } = default!;
    }
}