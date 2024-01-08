using Microsoft.EntityFrameworkCore;
using HotelBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HotelBooking.Server.Configurations.Entities
{
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    Id = 1,
                    Rating = 4.5m, // Example numerical rating from 0.0 to 5.0 Stars
                    Description = "Enjoyed the stay, great service!",
                    Date = new DateTime(2023, 1, 15),
                    CustomerId = 1
                },
                new Review
                {
                    Id = 2,
                    Rating = 3.0m,
                    Description = "Decent stay, room was comfortable",
                    Date = new DateTime(2023, 2, 5),
                    CustomerId = 2
                },
                new Review
                {
                    Id = 3,
                    Rating = 5.0m,
                    Description = "Outstanding experience, highly recommended!",
                    Date = new DateTime(2023, 3, 20),
                    CustomerId = 3
                },
                new Review
                {
                    Id = 4,
                    Rating = 2.5m,
                    Description = "Average stay, room cleanliness could be improved",
                    Date = new DateTime(2023, 4, 10),
                    CustomerId = 4
                }
            );
        }
    }
}
