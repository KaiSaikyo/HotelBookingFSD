using Microsoft.EntityFrameworkCore;
using HotelBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HotelBooking.Server.Configurations.Entities
{
    public class RoomSeedConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                new Room
                {
                    Id = 1,
                    Number = "704A",
                    Amenities = "2 King Beds",
                    RoomMinStay = 3,
                    RoomMaxStay = 5,
                    RoomTypeId = 1
                },
                new Room
                {
                    Id = 2,
                    Number = "680B",
                    Amenities = "1 King Bed, 1 Office Room",
                    RoomMinStay = 2,
                    RoomMaxStay = 3,
                    RoomTypeId = 2
                },
                new Room
                {
                    Id = 3,
                    Number = "530F",
                    Amenities = "2 Single Beds",
                    RoomMinStay = 4,
                    RoomMaxStay = 5,
                    RoomTypeId = 3
                },
                new Room
                {
                    Id = 4,
                    Number = "745C",
                    Amenities = "1 Single Bed, 1 Fax Machine",
                    RoomMinStay = 1,
                    RoomMaxStay = 3,
                    RoomTypeId = 4
                }
            );
        }
    }
}
