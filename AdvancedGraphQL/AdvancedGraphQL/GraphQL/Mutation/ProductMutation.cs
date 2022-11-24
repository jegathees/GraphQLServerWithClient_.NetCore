using AdvancedGraphQL.GraphQL.GraphTypes;
using AdvancedGraphQL.Model;
using AdvancedGraphQL.Repository;
using GraphQL;
using GraphQL.Types;

namespace AdvancedGraphQL.GraphQL.Mutation
{
    public class ProductMutation : ObjectGraphType
    {
        [Obsolete]
        public ProductMutation(IProductRepository productRepository)
        {
            Field<ProductType>("createproduct",
                arguments: new QueryArguments { new QueryArgument<ProductInput> { Name = "product" }},
                resolve: x => productRepository.Create(x.GetArgument<Product>("product")));
        }
    }
}
