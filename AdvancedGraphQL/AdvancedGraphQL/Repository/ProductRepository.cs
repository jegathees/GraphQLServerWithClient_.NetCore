using AdvancedGraphQL.Model; 
namespace AdvancedGraphQL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products = new List<Product>
        {
            new Product(1, "Laptop",20),
            new Product(2, "Mouse",40),
            new Product(3, "Keyboard",30),
            new Product(4, "Monitor",10)
        };
        public Product[] GetProducts() 
        {
            return products.ToArray();
        }
        public Product GetProductById(int id)
        {
            return GetProducts().FirstOrDefault(a => a.id == id);
        }
        public Product Create(Product product)
        {
            products.Add(product);
            return product;
        }
    }
}
