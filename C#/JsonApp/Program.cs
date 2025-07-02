using JsonApp.Models;
using System.Text.Json;

/*
Product product = new Product("Phone", 1500)
{
    Category = ProductCategory.Phone,
    Count = 35,
    InStock = null,
};


Console.WriteLine("Original: " + product.ToString());

string productJson = JsonSerializer.Serialize(product);

Console.WriteLine("JSON: " + productJson);

Product deserializedProduct = JsonSerializer.Deserialize<Product>(productJson)!;

Console.WriteLine("Deserialized: " + deserializedProduct.ToString());
*/



List<Product> products = new List<Product>()
{
    new Product("product1", 111),
    new Product("product2", 222),
    new Product("product3", 333),
};

Console.WriteLine("Original: ");
products.ForEach(product => Console.WriteLine(product));

string productsJson = JsonSerializer.Serialize(products);

Console.WriteLine("JSON: ");
Console.WriteLine(productsJson);

var deserializedProducts = JsonSerializer.Deserialize<List<Product>>(productsJson);

Console.WriteLine("Deserialized: ");
deserializedProducts.ForEach(product => Console.WriteLine(product));