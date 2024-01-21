using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Shared.Domain
{
	public class Booking : IValidatableObject
	{
		public int Id { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime? CheckInDate { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime? CheckOutDate { get; set; }

		[Required]
		[StringLength(200, MinimumLength = 3, ErrorMessage = "Destination does not meet length requirements")]
		public string? Destination { get; set; }

		[Required]
		[Range(1, 10)]
		public int? NumGuest { get; set; }

		[Required]
		[RegularExpression(@"^(true|false)$", ErrorMessage = "Status must be either 'true' or 'false'")]
		public string? Status { get; set; }

		[Required]
		public int HotelId { get; set; }
		public virtual Hotel? Hotel { get; set; }

		[Required]
		public int StaffId { get; set; }
		public virtual Staff? Staff { get; set; }

		[Required]
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }

		public int? RoomTypeId { get; set; }
		public virtual RoomType? RoomType { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (CheckInDate != null && CheckOutDate != null)
			{
				if (CheckInDate >= CheckOutDate)
				{
					yield return new ValidationResult("CheckInDate must be earlier than CheckOutDate", new[] { "CheckInDate" });
				}
			}
		}
	}
}