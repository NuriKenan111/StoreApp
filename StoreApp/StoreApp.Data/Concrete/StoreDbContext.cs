
using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Concrete;

namespace StoreApp.Data.Concrete;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {
        
    }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>{
                new(){ Id = 1, Name = "Iphone 15" , Price = 1000, Description = "Nice Phone",Category = "Phone"},
                new(){ Id = 2, Name = "Iphone 14" , Price = 900, Description = "Good Phone",Category = "Phone"},
                new(){ Id = 3, Name = "Iphone 13" , Price = 800, Description = "Best Phone",Category = "Phone"},
                new(){ Id = 4, Name = "Iphone 12" , Price = 700, Description = "Super Phone",Category = "Phone"},
                new(){ Id = 5, Name = "Iphone 11" , Price = 600, Description = "Good Phone",Category = "Phone"},
                new(){ Id = 6, Name = "Iphone 10" , Price = 500, Description = "Best Phone",Category = "Phone"},
                new(){ Id = 7, Name = "Iphone 9" , Price = 400, Description = "Super Phone",Category = "Phone"},
            }
        
        );
        
    }
}