using ECommerce.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerce.Entities.Concrete;

public class Product: Entity
{
    public string Name { get; set; }
    public float Cost { get; set; }
    
    // Navigation Property
    public Category Category { get; set; }
    
    // Foreign Key
    public int Category_Id { get; set; }
}