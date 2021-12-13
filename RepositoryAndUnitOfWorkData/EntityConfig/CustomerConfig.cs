using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepositoryAndUnitOfWork.Data.Entity;

namespace RepositoryAndUnitOfWork.Data.EntityConfig
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => new { e.LastName, e.FirstName })
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
