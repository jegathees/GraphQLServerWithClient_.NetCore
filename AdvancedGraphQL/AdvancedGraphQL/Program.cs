

using AdvancedGraphQL.GraphQL.GraphTypes;
using AdvancedGraphQL.GraphQL.Mutation;
using AdvancedGraphQL.GraphQL.Queries;
using AdvancedGraphQL.GraphQL.Schemas;
using AdvancedGraphQL.Repository;
using GraphQL;
using GraphQL.Server;
using GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// add notes schema

// register graphQL

// default setup
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "GraphQLNetExample", Version = "v1" });
});

builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<ProductType>();
builder.Services.AddSingleton<ProductQuery>();
builder.Services.AddSingleton<ProductMutation>();
builder.Services.AddSingleton<ProductInput>();
builder.Services.AddSingleton<ISchema, ProductSchema>();

builder.Services.AddGraphQL(builder => builder
                .AddSystemTextJson());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GraphQLNetExample v1"));


}

//app.UseAuthorization();

//app.MapControllers();
app.UseGraphQLAltair();
app.UseGraphQL<ISchema>();


app.Run();