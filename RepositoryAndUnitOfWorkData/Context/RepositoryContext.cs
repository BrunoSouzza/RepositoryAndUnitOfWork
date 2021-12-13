using Microsoft.EntityFrameworkCore;
using RepositoryAndUnitOfWork.Data.Entity;
using RepositoryAndUnitOfWork.Data.EntityConfig;

namespace RepositoryAndUnitOfWork.Data.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}
