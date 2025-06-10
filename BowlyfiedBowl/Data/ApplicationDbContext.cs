using Microsoft.EntityFrameworkCore;
using BowlyfiedBowl.Models;
using System.Collections.Generic;

namespace BowlyfiedBowl.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Bowl> Bowls { get; set; }
    }
}
