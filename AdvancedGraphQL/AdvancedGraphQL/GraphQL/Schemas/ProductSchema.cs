using AdvancedGraphQL.GraphQL.Mutation;
using AdvancedGraphQL.GraphQL.Queries;
using GraphQL.Types;

namespace AdvancedGraphQL.GraphQL.Schemas
{
    public class ProductSchema : Schema
    {
        public ProductSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<ProductQuery>();
            Mutation = serviceProvider.GetRequiredService<ProductMutation>();
        }
    }
}
