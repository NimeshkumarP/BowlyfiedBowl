using Microsoft.EntityFrameworkCore;
using BolyfiedBowl.Models;
using System.Collections.Generic;
using BolyfiedApp.Data;

namespace BolyfiedApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Bowl> Bowls { get; set; }
    }
}
public static class DbInitializer
{
    public static void Seed(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        if (!context.Bowls.Any())
        {
            context.Bowls.AddRange(
                new Bowl { Material = "Plastic", Capacity = "500ml", Dimensions = "6x6x3 in", Weight = "150g", ColorOptions = "Red", MicrowaveSafe = true, DishwasherSafe = true, MadeIn = "Canada" },
                new Bowl { Material = "Ceramic", Capacity = "750ml", Dimensions = "5x5x2.5 in", Weight = "350g", ColorOptions = "Blue", MicrowaveSafe = true, DishwasherSafe = true, MadeIn = "Canada" },
                new Bowl { Material = "Bamboo", Capacity = "600ml", Dimensions = "6.5x6.5x3.5 in", Weight = "120g", ColorOptions = "Green", MicrowaveSafe = false, DishwasherSafe = true, MadeIn = "Canada" },
                new Bowl { Material = "Stainless Steel", Capacity = "1000ml", Dimensions = "7x7x4 in", Weight = "500g", ColorOptions = "Silver", MicrowaveSafe = false, DishwasherSafe = true, MadeIn = "Canada" },
                new Bowl { Material = "Silicone", Capacity = "300ml", Dimensions = "5x5x2 in", Weight = "100g", ColorOptions = "Yellow", MicrowaveSafe = true, DishwasherSafe = true, MadeIn = "Canada" }
            );
            context.SaveChanges();
        }
    }
}
