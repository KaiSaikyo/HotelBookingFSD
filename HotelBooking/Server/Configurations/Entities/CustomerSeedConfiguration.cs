using Microsoft.EntityFrameworkCore;
using HotelBooking.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HotelBooking.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
			builder.HasData(
				new Customer
				{
					Id = 1,
					Name = "SARA JONES",
					Email = "sara.jones@example.com",
					Password = "sara123",
					Mobile = "87654321",
					PaymentType = "CreditCard",
					CardNumber = "1234567812345678", 
					Cvv = "123", 
					ExpiryDate = new DateTime(2025, 12, 31) 
				},
				new Customer
				{
					Id = 2,
					Name = "MIKE SMITH",
					Email = "mike.smith@example.com",
					Password = "mikepass",
					Mobile = "98765432",
					PaymentType = "DebitCard",
					CardNumber = "9876543210987654", 
					Cvv = "456", 
					ExpiryDate = new DateTime(2024, 6, 30) 
				},
				new Customer
				{
					Id = 3,
					Name = "JASON LEE",
					Email = "jason.lee@example.com",
					Password = "jasonPass",
					Mobile = "87651234",
					PaymentType = "CreditCard",
					CardNumber = "8765123412345678", 
					Cvv = "789", 
					ExpiryDate = new DateTime(2026, 11, 30) 
				},
				new Customer
				{
					Id = 4,
					Name = "EMILY TAN",
					Email = "emily.tan@example.com",
					Password = "emilyPwd",
					Mobile = "98762345",
					PaymentType = "DebitCard",
					CardNumber = "9876234512345678", 
					Cvv = "567", 
					ExpiryDate = new DateTime(2028, 8, 31) 
				}
			);
        }
    }
}
