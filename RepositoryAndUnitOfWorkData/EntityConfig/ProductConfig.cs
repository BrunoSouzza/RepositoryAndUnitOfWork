using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepositoryAndUnitOfWork.Data.Entity;

namespace RepositoryAndUnitOfWork.Data.EntityConfig
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(c => new { c.Description, c.Name })
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(c => c.Price).HasPrecision(10, 2);
        }
    }
}
