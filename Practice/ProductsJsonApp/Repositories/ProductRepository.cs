using ProductsJsonApp.Models;
using System.Text;
using System.Text.Json;

namespace ProductsJsonApp.Repositories;

class ProductRepository
{
    private const string filePath = "products.json";
    private readonly List<Product> products;

    public ProductRepository()
    {
        this.products = this.LoadAll();
    }

    public void SaveAll()
    {
        var allProductsToSave = this.GetAll();

        var allProductsToSaveJson = JsonSerializer.Serialize(allProductsToSave);

        File.WriteAllText(filePath, allProductsToSaveJson);

        //IEnumerable<string> contents = allProducts.Select(product => product.ToString());
        //File.WriteAllLines("products.txt", contents);
    }

    private List<Product> LoadAll()
    {
        if(File.Exists(filePath) == false)
        {
            var createdFileStream = File.Create(filePath);

            var emptyArrayJson = "[]";
            var emptyArrayAsBytes = Encoding.ASCII.GetBytes(emptyArrayJson);
            createdFileStream.Write(emptyArrayAsBytes);
            createdFileStream.Flush();

            createdFileStream.Dispose();
        }

        var allLoadedProductsJson = File.ReadAllText(filePath);

        var allLoadedProducts = JsonSerializer.Deserialize<List<Product>>(allLoadedProductsJson) ?? new List<Product>();

        Product.IdCounter = allLoadedProducts.Max(product => product.Id);

        return allLoadedProducts;
    }

    public Product Create(string name, decimal price)
    {
        var newProduct = new Product(name, price);

        this.products.Add(newProduct);

        return newProduct;
    }

    public IEnumerable<Product> GetAll()
    {
        return this.products;
    }
}