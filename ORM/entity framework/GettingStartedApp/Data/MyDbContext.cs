namespace GettingStartedApp.Data;

using GettingStartedApp.Models;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    private const string connectionString = "Server=localhost;Database=MyEfDb;User Id=admin;Password=admin;TrustServerCertificate=True;";
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(connectionString);
    }
}