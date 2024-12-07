using Microsoft.EntityFrameworkCore;


namespace backend {
    public class RentEZDbContext : DbContext {
        public RentEZDbContext(DbContextOptions<RentEZDbContext> options) : base(options)
        {
            
        }

        // registering the model, model folder still empty
        


        // allows us to put data into the database
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // empty for now no tables to put data in
        }
     
    }
}
