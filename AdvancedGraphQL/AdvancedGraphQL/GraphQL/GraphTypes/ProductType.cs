using AdvancedGraphQL.Model;
using GraphQL.Types;

namespace AdvancedGraphQL.GraphQL.GraphTypes
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.id);
            Field(x => x.name);
            Field(x => x.Quantity);
        }
    }
}
