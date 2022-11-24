using AdvancedGraphQL.GraphQL.GraphTypes;
using AdvancedGraphQL.Model;
using AdvancedGraphQL.Repository;
using GraphQL;
using GraphQL.Types;

namespace AdvancedGraphQL.GraphQL.Queries
{
    public class ProductQuery: ObjectGraphType
    {
        [Obsolete]
        public ProductQuery(IProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>
                (Name = "products", resolve: x => productRepository.GetProducts());

            Field<ProductType>("product", arguments: new QueryArguments(
            new QueryArgument<IntGraphType> { Name = "id" }
            ), resolve: x => productRepository.GetProductById(x.GetArgument<int>("id")));
        }

    }
}
