using ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Configuration;

public class ProductConfiguration: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasOne(p => p.Category)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.Category_Id);

        builder.HasData(new Product[]
        {
            new Product() { Id = 1, Name = "Nokia Phone", Cost = 20, Category_Id = 1 },
            new Product() { Id = 2, Name = "Pentium 1203", Cost = 2130, Category_Id = 1 },
            new Product() { Id = 3, Name = "GoalKeeper Gloves", Cost = 43, Category_Id = 3 }
        });
    }
}