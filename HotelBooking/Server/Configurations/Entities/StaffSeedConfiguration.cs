using Microsoft.EntityFrameworkCore;
using HotelBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HotelBooking.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    Name = "AMOS TAN",
                    Email = "T.amos@gmail.com",
                    Password = "AT123",
                    Mobile = "98765432"
                },
                new Staff
                {
                    Id = 2,
                    Name = "JACK BRYAN",
                    Email = "JBman@hotmail.com",
                    Password = "JBpassword",
                    Mobile = "87654321"
                },
                new Staff
                {
                    Id = 3,
                    Name = "LIM HSING",
                    Email = "LSING@hotmail.com",
                    Password = "passwordLH",
                    Mobile = "65432109"
                },
                new Staff
                {
                    Id = 4,
                    Name = "TAY ZI XIANG",
                    Email = "TZXiang@gmail.com",
                    Password = "TZXTZX",
                    Mobile = "12345678"
                }
            );
        }
    }
}
