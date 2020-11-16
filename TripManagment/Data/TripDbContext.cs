using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TripManagment.Data.Models;

namespace TripManagment.Data
{
    public class TripDbContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }

        public TripDbContext(DbContextOptions<TripDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TripsEntityConfiguration());
        }

        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
