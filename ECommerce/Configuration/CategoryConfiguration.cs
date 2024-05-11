using ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Configuration;

public class CategoryConfiguration: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasMany(c => c.Products)
               .WithOne(p => p.Category);

        builder.HasData(new Category[]
        {
            new Category(){Id = 1 , Name = "Electronics"},
            new Category(){Id = 2 , Name = "Stationary"},
            new Category(){Id = 3 , Name = "Sport"}
        });
    }
}