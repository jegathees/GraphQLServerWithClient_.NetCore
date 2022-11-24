

namespace AdvancedGraphQLClient;

public record ProductsResponse(Product[] products);

public record ProductResponse(Product product);

public record CreateProductResponse(Product createProduct);
