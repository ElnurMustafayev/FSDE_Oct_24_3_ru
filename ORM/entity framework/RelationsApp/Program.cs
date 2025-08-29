using Microsoft.EntityFrameworkCore;
using RelationsApp.Data;
using RelationsApp.Entities.ManyToMany;
// using RelationsApp.Entities.ManyToMany;
// using RelationsApp.Entities.OneToMany;

MyDbContext dbContext = new MyDbContext();

// var newBlog = new Blog {
//     Name = "IT",
//     SiteUri = null,
//     Posts = new List<Post>()
//     {
//         new Post {
//             Title = "C# basics",
//             Content = "...",
//             Archived = false,
//             PublishedOn = DateOnly.FromDateTime(DateTime.Now.AddDays(-20)),
//         },
//         new Post {
//             Title = "C# advanced",
//             Content = "......",
//             Archived = false,
//             PublishedOn = DateOnly.FromDateTime(DateTime.Now),
//         }
//     }
// };

//dbContext.Blogs.Add(newBlog);
//dbContext.SaveChanges();







// var firstPost = dbContext.Posts.First();

// var newBlog = new Blog
// {
//     Name = "Some blog",
//     SiteUri = null,
//     Posts = new List<Post>
//     {
//         firstPost
//     }
// };

// dbContext.Blogs.Add(newBlog);
// dbContext.SaveChanges();



// var blog = dbContext.Blogs.Find(2);

// var newPost = new Post
// {
//     Title = "qwerty",
//     Content = "qwerty",
//     Archived = true,
//     PublishedOn = DateOnly.FromDateTime(DateTime.Now.AddMonths(-10)),
//     Blog = blog
// };

// dbContext.Posts.Add(newPost);
// dbContext.SaveChanges();

// System.Console.WriteLine(newPost);



// var oddPostsQuery = from post in dbContext.Posts
//                     where post.Id % 2 == 1
//                     select post;

// var oddPosts = oddPostsQuery.ToList();

// var foundPost = oddPosts.First();

// foundPost.BlogId = 2;

// dbContext.Posts.Update(foundPost);
// dbContext.SaveChanges();

// System.Console.WriteLine(foundPost);






// dbContext.Posts.Add(new RelationsApp.Entities.ManyToMany.Post());
// dbContext.Tags.Add(new RelationsApp.Entities.ManyToMany.Tag());

dbContext.PostTags.Add(new PostTag
{
    Post = new Post(),
    Tag = new Tag(),
});
dbContext.SaveChanges();














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


// var productToUpdate = new Product
// {
//     ProductIdentifier = 5,
//     Name = "UNKNOWN",
//     Code = "UNKNOWN",
// };

// dbContext.Products.Update(productToUpdate);
// dbContext.SaveChanges();