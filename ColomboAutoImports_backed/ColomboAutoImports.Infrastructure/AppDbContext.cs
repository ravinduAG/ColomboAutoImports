using Microsoft.EntityFrameworkCore;
using ColomboAutoImports.Core.Entities;
using ColomboAutoImports.Infrastructure.EntityConfigurations;

namespace ColomboAutoImports.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<CarModelEntity> CarModels => Set<CarModelEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarModelEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
