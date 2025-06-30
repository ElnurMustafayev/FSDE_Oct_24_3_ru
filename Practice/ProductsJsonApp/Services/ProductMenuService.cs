using ProductsJsonApp.Models;

namespace ProductsJsonApp.Services;


// Product
//      Create +
//      Read +
//      Update
//      Delete

class ProductMenuService
{
    private readonly List<Product> products;
    private readonly ProductFileService productFileService;

    public ProductMenuService()
    {
        this.products = new List<Product>();
        this.productFileService = new ProductFileService();
    }

    public void Create()
    {
        Console.Write("Name: ");
        var name = Console.ReadLine();
        ArgumentNullException.ThrowIfNullOrWhiteSpace(name);

        Console.Write("Price: ");
        var priceStr = Console.ReadLine();
        if(decimal.TryParse(priceStr, out decimal price) == false)
        {
            throw new ArgumentException("Price must be numeric!");
        }

        var newProduct = new Product(name, price);
        this.products.Add(newProduct);

        //this.productFileService.SaveProducts(this.products);
        this.productFileService.SaveProduct(newProduct);
    }

    public void Read()
    {
        if(this.products.Any() == false)
        {
            Console.WriteLine("There are no products...");
            return;
        }

        foreach (var product in this.products)
        {
            Console.WriteLine(product);
        }
    }
}