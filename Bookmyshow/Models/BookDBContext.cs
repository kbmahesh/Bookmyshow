using Microsoft.EntityFrameworkCore;

namespace Bookmyshow.Models
{
    public class BookDBContext:DbContext
    {
        public BookDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieGenre> Genres { get; set; }
    }
}
