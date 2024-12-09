using Microsoft.EntityFrameworkCore;
using backend.Models;  // Correct namespace for your models

namespace backend.Data // Make sure this matches your folder structure
{
    public class RentEZDbContext : DbContext
    {
        public RentEZDbContext(DbContextOptions<RentEZDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
