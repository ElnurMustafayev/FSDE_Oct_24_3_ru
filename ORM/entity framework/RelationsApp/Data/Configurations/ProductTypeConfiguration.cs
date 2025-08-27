using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RelationsApp.Models;

namespace RelationsApp.Data.Configurations;

public class ProductTypeConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .Property(product => product.Code)
            .HasMaxLength(20)
            .HasColumnName("PRODUCT_CODE");

        builder
            .HasKey(product => product.ProductIdentifier);

        builder
            .HasIndex(product => product.Code)
            .IsUnique();

        builder
            .ToTable("MY_PRODUCTS");
    }
}