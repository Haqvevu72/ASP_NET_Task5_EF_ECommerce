using ECommerce.Entities.Abstract;

namespace ECommerce.Entities.Concrete;

public class Category: Entity
{
    public string Name { get; set; }
    
    // Navigation Property
    public ICollection<Product> Products { get; set; }
}