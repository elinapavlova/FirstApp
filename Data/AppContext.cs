using Microsoft.EntityFrameworkCore;
using Models.User;


namespace Data
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=testdb;Username=postgres;Password=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
