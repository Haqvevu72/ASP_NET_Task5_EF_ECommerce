using ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Database;

public class ECommerceDb: DbContext
{
    public ECommerceDb(DbContextOptions<ECommerceDb> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECommerceDb).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    // My Entites
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}