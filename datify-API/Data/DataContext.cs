using datify_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace datify_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // Specify Database name for our AppUsers
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
