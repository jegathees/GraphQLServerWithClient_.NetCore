
using AdvancedGraphQLClient;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

var client = new GraphQLHttpClient("https://localhost:7075/graphql", new NewtonsoftJsonSerializer());

var query = new GraphQLRequest
{
    Query = @"
    {
        products
        {
            ...ProductValue
        }
    }"
};

var response = await client.SendQueryAsync<ProductsResponse>(query);

foreach (var product in response.Data.products)
{
    Console.WriteLine($"{product.name},{product.Quantity}");
    
}

query = new GraphQLRequest
{
    Query = @"    
        query firstproduct($id:Int!)
        {
        product(id:$id){
            id,
            name,
            quantity
        }
    }",
    OperationName = "firstproduct",
    Variables = new {id=2}
};

var singleResponse = await client.SendQueryAsync<ProductResponse>(query);
Console.WriteLine(singleResponse.Data.product);

query = new GraphQLRequest
{
    Query = @"    
        mutation add($prod:ProductInput)
        {
        createproduct(product:$prod){
            id,
            name,
            quantity
        }
    }",
    OperationName = "add",
    Variables = new { prod = new { id = 6, name = "Speaker", quantity = 70 } }
};

var mutationResponse = await client.SendQueryAsync<CreateProductResponse>(query);
Console.WriteLine(mutationResponse.Data.createProduct);

query = new GraphQLRequest
{
    Query = @"
    fragment ProductValue on ProductType{
        id,
        name,
        quantity
    }"
};

Console.ReadLine();