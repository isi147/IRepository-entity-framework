using Shop.Project.DAL.Context;
using Shop.Project.DAL.Repositories.Concrate;

namespace Shop.Project.Main;

public class UnitOfWork
{
    private readonly ShopDbContext _context;

    public UnitOfWork(ShopDbContext context, ProductRepository productRepository, CategoryRepository categoryRepository, OrderRepository orderRepository)
    {
        _context = context;
        this.productRepository = productRepository;
        this.categoryRepository = categoryRepository;
        this.orderRepository = orderRepository;
    }

    public ProductRepository productRepository { get; }
    public CategoryRepository categoryRepository { get; }
    public OrderRepository orderRepository { get; }



}
