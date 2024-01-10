using Microsoft.EntityFrameworkCore;
using HotelBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HotelBooking.Server.Configurations.Entities
{
    public class RoomTypeSeedConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasData(
                new RoomType
                {
                    Id = 1,
                    Description = "The Twin Room",
                    Size = "25 sqm",
                    Price = (decimal?)2404.00,
                    HotelId = 1
                },
                new RoomType
                {
                    Id = 2,
                    Description = "Deluxe Twin Room",
                    Size = "20 sqm",
                    Price = (decimal?)2324.00,
                    HotelId = 1
                },
                new RoomType
                {
                    Id = 3,
                    Description = "Single Office Room",
                    Size = "15 sqm",
                    Price = (decimal?)1531.00,
                    HotelId = 2
                },
                new RoomType
                {
                    Id = 4,
                    Description = "Single Room",
                    Size = "5 sqm",
                    Price = (decimal?)592.50,
                    HotelId = 4
                }
            );
        }
    }
}