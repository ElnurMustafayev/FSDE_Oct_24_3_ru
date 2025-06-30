namespace ProductsJsonApp.Services;

using ProductsJsonApp.Models;
using System.Text;
using System.Text.Json;

class ProductFileService
{
    public void SaveProducts(IEnumerable<Product> productsToSave)
    {
        StringBuilder sb = new StringBuilder(productsToSave.Count() * 40);

        foreach (var product in productsToSave)
        {
            sb.AppendLine(product.ToString());
        }

        File.WriteAllText("products.txt", sb.ToString());
    }

    public void SaveProduct(Product productToSave)
    {
        //File.AppendAllText("products.txt", productToSave.ToString() + '\n');
        File.AppendAllText("products.txt", JsonSerializer.Serialize(productToSave) + '\n');
    }

    public IEnumerable<Product> LoadProducts()
    {
        return Enumerable.Empty<Product>();
    }
}