using Shop.Project.DAL.Repositories.Concrate;
using Shop.Project.Models.Concrate;

CategoryRepository categoryRepository = new CategoryRepository();
ProductRepository productRepository = new ProductRepository();
OrderRepository orderRepository = new OrderRepository();


Category category1 = new Category() { Name = "Et mehsullari" };
Category category2 = new Category() { Name = "Meyve" };
Category category3 = new Category() { Name = "Enerji ickileri" };


Product product1 = new Product() { Name = "Toyuq Qanad", Price = 15, CategoryId = 1 };
Product product2 = new Product() { Name = "Quzu Qanad", Price = 25, CategoryId = 1 };
Product product3 = new Product() { Name = "Mal Qanad", Price = 35, CategoryId = 1 };

Product product4 = new Product() { Name = "Heyva", Price = 5, CategoryId = 2 };
Product product5 = new Product() { Name = "Alma", Price = 15, CategoryId = 2 };


Product product6 = new Product() { Name = "Monster", Price = 5, CategoryId = 3 };
Product product7 = new Product() { Name = "RedBull", Price = 5, CategoryId = 3 };


Order order1 = new Order() { Adress = "General sixlinski 1" };




categoryRepository.Add(category1);
categoryRepository.Add(category2);
categoryRepository.Add(category3);

productRepository.Add(product1);
productRepository.Add(product2);
productRepository.Add(product3);
productRepository.Add(product4);
productRepository.Add(product5);
productRepository.Add(product6);
productRepository.Add(product7);

orderRepository.Add(order1);


//categoryRepository.SaveChanges();
//productRepository.SaveChanges();
//orderRepository.SaveChanges();




//productRepository.Delete(7);
//productRepository.SaveChanges();


var products = productRepository.GetAll().ToList();

foreach (var product in products)
    Console.WriteLine(product);



