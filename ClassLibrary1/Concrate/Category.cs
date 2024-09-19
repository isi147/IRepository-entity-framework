using Shop.Project.Models.Abstract;

namespace Shop.Project.Models.Concrate;

public class Category : BaseEntity
{
    public string Name { get; set; }

    //Navigation Properties
    public ICollection<Product> Products { get; set; }
}
