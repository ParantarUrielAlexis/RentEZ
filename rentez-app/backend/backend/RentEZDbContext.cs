using Microsoft.EntityFrameworkCore;
using backend.Models;  // Correct namespace for your models

namespace backend.Data // Make sure this matches your folder structure
{
    public class RentEZDbContext : DbContext
    {
        public RentEZDbContext(DbContextOptions<RentEZDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationship between User and Property
            modelBuilder.Entity<Property>()
                .HasOne(p => p.User)
                .WithMany(u => u.Properties) // Assumes `Properties` collection exists in `User`
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.Cascade);

           
            // Seed Properties
            modelBuilder.Entity<Property>().HasData(
                new Property
                {
                    PropertyID = 1,
                    UserID = 1,
                    Name = "Cozy Apartment",
                    Street = "123 Main St",
                    City = "Metropolis",
                    Province = "NY",
                    Description = "A cozy apartment in the heart of the city.",
                    Price = 1200.00M
                },
                new Property
                {
                    PropertyID = 2,
                    UserID = 2,
                    Name = "Luxury Villa",
                    Street = "456 Elm St",
                    City = "Gotham",
                    Province = "CA",
                    Description = "A luxurious villa with stunning views.",
                    Price = 5000.00M
                }
            );
        }


    }

}
