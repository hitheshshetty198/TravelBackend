using Microsoft.EntityFrameworkCore;
using TravelBackend.Models;

namespace TravelBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Place> Places { get; set; }
    }
}
