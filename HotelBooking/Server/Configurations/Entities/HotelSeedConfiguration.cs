using Microsoft.EntityFrameworkCore;
using HotelBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HotelBooking.Server.Configurations.Entities
{
    public class HotelSeedConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hilton Hotel",
                    Address = "333 Orchard Rd, Mandarin Orchard Singapore",
                    Description = "Hilton Hotels & Resorts is a global brand of full-service hotels and resorts.",
                    Amenities = "Breakfast, Wifi, Gym",
                    Rating = (decimal?)3.5,
                    Availability = true
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Fullerton Hotel",
                    Address = "1 Fullerton Square, Singapore 049178",
                    Description = "The Fullerton Hotel Singapore offers 5-star luxury rooms & suites with exceptional services.",
                    Amenities = "Breakfast, Gym, Laundry",
                    Rating = (decimal?)5.0,
                    Availability = true
                },
                new Hotel
                {
                    Id = 3,
                    Name = "St 81 Hotel",
                    Address = "768 Upper Serangoon Rd, Singapore 534636",
                    Description = "Your go-to hotel for awesome rates, comfortable rooms, and accessible locations.",
                    Amenities = "Game Center, Swimming Pool, Wifi",
                    Rating = (decimal?)3.0,
                    Availability = false
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Hard Rock Hotel",
                    Address = "Desaru Coast, Jln Pantai 3, 81930, Johor, Malaysia",
                    Description = "Your ultimate destination getaway at the leading entertainment hotel in Desaru Coast, Johor, Malaysia.",
                    Amenities = "Breakfast, Wifi, Gym",
                    Rating = (decimal?)2.5,
                    Availability = true
                }
            );
        }
    }
}