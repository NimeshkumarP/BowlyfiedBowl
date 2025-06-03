using Microsoft.EntityFrameworkCore;
using BolyfiedApp.Models;
using System.Collections.Generic;

namespace BolyfiedApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Bowl> Bowls { get; set; }
    }
}
