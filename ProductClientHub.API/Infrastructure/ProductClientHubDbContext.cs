using Microsoft.EntityFrameworkCore;    
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.Infrastructure
{
    public class ProductClientHubDbContext : DbContext
    {
        public ProductClientHubDbContext(DbContextOptions<ProductClientHubDbContext> options)
            : base(options)
        {
        }

        // DbSets (exemplos – você pode remover ou ajustar)
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aqui você centraliza as configurações das entidades
            // modelBuilder.ApplyConfiguration(new ProductConfiguration());
            // modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }
    }
}
