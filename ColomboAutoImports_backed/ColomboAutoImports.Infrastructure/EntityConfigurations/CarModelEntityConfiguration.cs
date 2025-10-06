using ColomboAutoImports.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColomboAutoImports.Infrastructure.EntityConfigurations
{
    public class CarModelEntityConfiguration : IEntityTypeConfiguration<CarModelEntity>
    {
        public void Configure(EntityTypeBuilder<CarModelEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
