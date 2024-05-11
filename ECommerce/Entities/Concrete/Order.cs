using ECommerce.Entities.Abstract;

namespace ECommerce.Entities.Concrete;

public class Order: Entity
{
    public string productName { get; set; }
    public int count { get; set; }
    public float cost { get; set; }

}