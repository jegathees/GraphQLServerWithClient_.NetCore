using AdvancedGraphQL.Model;

namespace AdvancedGraphQL.Repository
{
    public interface IProductRepository
    {
        Product[] GetProducts();
        Product GetProductById(int id);
        Product Create(Product product);
    }
}
