using Beerbros.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Beerbros.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Beer> Beers { get; set; }

        public DbSet<Brewery> Breweries { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Style> Styles { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
    }
}
