using ProductsJsonApp.Models;
using ProductsJsonApp.Repositories;

namespace ProductsJsonApp.Services;


// Product
//      Create +
//      Read +
//      Update
//      Delete

class ProductMenuService
{
    private readonly ProductRepository repository;

    public ProductMenuService()
    {
        this.repository = new ProductRepository();
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

        var createdProduct = this.repository.Create(name, price);
        this.repository.SaveAll();

        Console.WriteLine($"Product has been created successfully with id '{createdProduct.Id}'");

        Console.ReadKey(true);
    }

    public void Read()
    {
        var allProducts = this.repository.GetAll();
        if(allProducts.Any() == false)
        {
            Console.WriteLine("There are no products...");
        }
        else
        {
            foreach (var product in allProducts)
            {
                Console.WriteLine(product);
            }
        }

        Console.ReadKey(true);
    }
}