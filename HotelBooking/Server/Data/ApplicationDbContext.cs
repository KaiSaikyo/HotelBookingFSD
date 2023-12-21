using Duende.IdentityServer.EntityFramework.Options;
using HotelBooking.Server.Configurations.Entities;
using HotelBooking.Server.Models;
using HotelBooking.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

namespace HotelBooking.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Stay> Stays { get; set; }
        public DbSet<Review> Reviews { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new StaffSeedConfiguration());
            builder.ApplyConfiguration(new HotelSeedConfiguration());
            builder.ApplyConfiguration(new RoomTypeSeedConfiguration());
			builder.ApplyConfiguration(new CustomerSeedConfiguration());
			builder.ApplyConfiguration(new ReviewSeedConfiguration());
			builder.ApplyConfiguration(new StaySeedConfiguration());
			builder.ApplyConfiguration(new BookingSeedConfiguration());
			builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
		}
    }
}
