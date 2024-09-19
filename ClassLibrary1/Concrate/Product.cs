using Shop.Project.Models.Abstract;

namespace Shop.Project.Models.Concrate;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public float Price { get; set; }

    //Foreign Key
    public int CategoryId { get; set; }

    //Navigation Properties
    public Category Category { get; set; }
    public ICollection<Order> Orders { get; set; }

    public override string ToString()
    {
        return $"Name:{Name} - Price:{Price}";
    }

}
