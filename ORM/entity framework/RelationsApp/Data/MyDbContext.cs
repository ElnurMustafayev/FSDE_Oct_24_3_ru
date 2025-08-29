namespace RelationsApp.Data;

using Microsoft.EntityFrameworkCore;
using RelationsApp.Data.Configurations;
using RelationsApp.Entities.ManyToMany;
using RelationsApp.Entities.OneToMany;
using RelationsApp.Models;

public class MyDbContext : DbContext
{
    private const string connectionString = "Server=localhost;Database=MyRelationalEfDb;User Id=admin;Password=admin;TrustServerCertificate=True;";
    // public DbSet<Product> Products { get; set; }

    // one-to-many
    // public DbSet<Entities.OneToMany.Post> Posts { get; set; }
    // public DbSet<Blog> Blogs { get; set; }

    // many-to-many
    public DbSet<Entities.ManyToMany.Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PostTag> PostTags { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());

        modelBuilder.Entity<PostTag>()
            .HasKey(pt => new { pt.PostsId, pt.TagsId });

        // modelBuilder.Entity<Product>()
        //     .Property(product => product.Code)
        //     .HasMaxLength(20)
        //     .HasColumnName("PRODUCT_CODE");

        // modelBuilder.Entity<Product>()
        //     .HasKey(product => product.ProductIdentifier);

        // modelBuilder.Entity<Product>()
        //     .HasIndex(product => product.Code)
        //     .IsUnique();
    }
}