using Microsoft.EntityFrameworkCore;
using HotelBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HotelBooking.Server.Configurations.Entities
{
    public class BookingSeedConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                new Booking
                {
                    Id = 1,
                    CheckInDate = new DateTime(2023, 1, 15),
                    CheckOutDate = new DateTime(2023, 1, 20),
                    Destination = "City A",
                    NumGuest = 2,
                    Status = true,
                    HotelId = 1,
                    StaffId = 1,
                    CustomerId = 1
                },
                new Booking
                {
                    Id = 2,
                    CheckInDate = new DateTime(2023, 2, 5),
                    CheckOutDate = new DateTime(2023, 2, 10),
                    Destination = "City B",
                    NumGuest = 1,
                    Status = true,
                    HotelId = 2,
                    StaffId = 2,
                    CustomerId = 2
                },
                new Booking
                {
                    Id = 3,
                    CheckInDate = new DateTime(2023, 3, 20),
                    CheckOutDate = new DateTime(2023, 3, 25),
                    Destination = "City C",
                    NumGuest = 3,
                    Status = false,
                    HotelId = 3,
                    StaffId = 3,
                    CustomerId = 3
                },
                new Booking
                {
                    Id = 4,
                    CheckInDate = new DateTime(2023, 4, 10),
                    CheckOutDate = new DateTime(2023, 4, 15),
                    Destination = "City D",
                    NumGuest = 2,
                    Status = true,
                    HotelId = 4,
                    StaffId = 4,
                    CustomerId = 4
                }
            );
        }
    }
}
