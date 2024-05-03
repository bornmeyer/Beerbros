using Microsoft.EntityFrameworkCore;

namespace Beerbros.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        {
            
        }
    }
}
