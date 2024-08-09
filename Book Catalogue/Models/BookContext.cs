using Microsoft.EntityFrameworkCore;

namespace Book_Catalogue.Models
{
    public class BookContext(DbContextOptions<BookContext> options) : DbContext(options)
    {
        public DbSet<Books> Books { get; set; }
    }
}
