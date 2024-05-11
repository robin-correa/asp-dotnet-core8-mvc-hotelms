using HotelMS.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace HotelMS.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<RoomCategory> RoomCategories { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Default Hotel",
                    Address = "21 Robin Street",
                    Phone = "1121-1121-1121",
                    Email = "robin.correa21@gmail.com",
                    Website = "http://robincorrea.com",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<RoomCategory>().HasData(
                new RoomCategory
                {
                    Id = 1,
                    Name = "Standard",
                    Description = "Standard room",
                    TotalCapacity = 2,
                    TotalAdult = 2,
                    TotalChild = 1,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new RoomCategory
                {
                    Id = 2,
                    Name = "Deluxe",
                    Description = "Spacious and luxurious room",
                    TotalCapacity = 2,
                    TotalAdult = 2,
                    TotalChild = 1,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );
        }
    }
}
