using Microsoft.EntityFrameworkCore;

namespace TouristRoutes.Persistence.Data
{
    public class AppDbContext : DbContext
    {
        private readonly DbContextOptions<AppDbContext> _dbContextOptions;

        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TouristRout>();
            modelBuilder.Entity<Attractivene>();
            
        }
    }
}
