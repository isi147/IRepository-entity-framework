using Shop.Project.Models.Abstract;

namespace Shop.Project.Models.Concrate;

public class Order : BaseEntity
{
    public string Adress { get; set; }

    //Navigation Properties
    public ICollection<Product> Products { get; set; }
}
