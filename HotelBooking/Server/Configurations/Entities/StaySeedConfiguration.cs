﻿using Microsoft.EntityFrameworkCore;
using HotelBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HotelBooking.Server.Configurations.Entities
{
    public class StaySeedConfiguration : IEntityTypeConfiguration<Stay>
    {
        public void Configure(EntityTypeBuilder<Stay> builder)
        {
			builder.HasData(
				new Stay
				{
					Id = 1,
					EmergencyContact = "12345678", // 8-digit numerical emergency contact
					OccupancyStatus = true,
					ComplimentaryServices = "Wi-Fi, Breakfast"
				},
				new Stay
				{
					Id = 2,
					EmergencyContact = "87654321", // 8-digit numerical emergency contact
					OccupancyStatus =  false,
					ComplimentaryServices = "Pool Access, Newspaper"
				},
				new Stay
				{
					Id = 3,
					EmergencyContact = "55558888", // 8-digit numerical emergency contact
					OccupancyStatus = true,
					ComplimentaryServices = "Gym Access, Parking"
				},
				new Stay
				{
					Id = 4,
					EmergencyContact = "33332222", // 8-digit numerical emergency contact
					OccupancyStatus = false,
					ComplimentaryServices = "Airport Shuttle"
				}
			);
        }
    }
}
