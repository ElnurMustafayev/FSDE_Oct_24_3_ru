using System.Xml.Linq;

namespace ProductsJsonApp.Models;

public class Product
{
    private static int idCounter = 0;
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ProductCategory? Category { get; set; }
    public bool? InStock { get; set; }
    public int? Count { get; set; }
    public DateTime AddedDateTime { get; set; }

    public Product(string name, decimal price)
    {
        this.Id = ++Product.idCounter;
        this.Name = name;
        this.Price = price;
        this.AddedDateTime = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price:C}, Category: {Category}, In Stock: {InStock}, Count: {Count}, Added: {AddedDateTime}";
    }
}