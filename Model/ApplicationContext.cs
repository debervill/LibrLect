using Microsoft.EntityFrameworkCore;
using LibrLect.Model;

namespace LibrLect.Model
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
    {
        public DbSet<Users> User => Set<Users>();
        public DbSet<Books> Books => Set<Books>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
