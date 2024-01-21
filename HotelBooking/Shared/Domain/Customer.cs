using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
	public class Customer : IValidatableObject
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "Name does not meet length requirements")]
		public string? Name { get; set; }

		[Required]
		[DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not a valid email")]
		[EmailAddress]
		public string? Email { get; set; }

		[Required]
		[RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{3,100}$", ErrorMessage = "Password must contain at least one letter, one digit, and one special character")]
		public string? Password { get; set; }

		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"\d{8}", ErrorMessage = "Contact Number must be 8 digits")]
		public string? Mobile { get; set; }

		[Required]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "Payment Type does not meet length requirements")]
		public string? PaymentType { get; set; }

		[Required]
		[RegularExpression(@"^\d{16}$", ErrorMessage = "Card number must be 16 digits")]
		public string? CardNumber { get; set; }

		[Required]
		[RegularExpression(@"^\d{3}$", ErrorMessage = "CVV must be a 3-digit number")]
		public string? Cvv { get; set; }

		[Required]
		[DataType(DataType.Date, ErrorMessage = "Invalid date format")]
		public DateTime? ExpiryDate { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (ExpiryDate != null && ExpiryDate < DateTime.Today)
			{
				yield return new ValidationResult("Expiry date must be in the future", new[] { "ExpiryDate" });
			}
		}
	}
}