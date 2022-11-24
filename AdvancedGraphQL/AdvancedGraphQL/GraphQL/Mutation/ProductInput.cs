using GraphQL.Types;

namespace AdvancedGraphQL.GraphQL.Mutation
{
    public class ProductInput : InputObjectGraphType
    {
        public ProductInput()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<IntGraphType>("quantity");
        }
    }
}
