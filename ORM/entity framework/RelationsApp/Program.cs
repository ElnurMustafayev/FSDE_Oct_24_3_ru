// Products
// Code == "AGSHDA1245162"



using RelationsApp.Data;
using RelationsApp.Models;

MyDbContext dbContext = new MyDbContext();

//var product = dbContext.Products.FirstOrDefault(product => product.Code == "P003");





// var productsQuery = dbContext.Products.Where(product => product.ProductIdentifier <= 3);

// var products = productsQuery.ToList();

// foreach (var product in products)
// {
//     System.Console.WriteLine(product);
// }

// var result = dbContext.Products
//     .Select(product => new { Id = product.ProductIdentifier, product.Code })
//     .Take(2)
//     .ToList();

// foreach (var item in result)
// {
//     System.Console.WriteLine(item);
// }


// var product = dbContext.Products.FirstOrDefault(product => product.Code == "P003");

// if (product is not null)
// {
//     dbContext.Products.Remove(product);
//     dbContext.SaveChanges();
// }


// dbContext.Products.Remove(new Product
// {
//     ProductIdentifier = 1,
//     Name = "UNKNOWN",
//     Code = "UNKNOWN",
// });

// dbContext.SaveChanges();


var productToUpdate = new Product
{
    ProductIdentifier = 5,
    Name = "UNKNOWN",
    Code = "UNKNOWN",
};

dbContext.Products.Update(productToUpdate);
dbContext.SaveChanges();