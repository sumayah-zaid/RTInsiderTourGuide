using Microsoft.EntityFrameworkCore;

namespace RTInsiderTourGuide.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}