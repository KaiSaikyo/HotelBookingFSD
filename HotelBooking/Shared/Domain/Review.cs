using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
	public class Review
	{
		public int Id { get; set; }

		[Required]
		[Range(0.0, 5.0, ErrorMessage = "Rating must be between 0.0 and 5.0")]
		public decimal? Rating { get; set; }

		[Required]
		[StringLength(500, MinimumLength = 3, ErrorMessage = "Description does not meet length requirements")]
		public string? Description { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime? Date { get; set; }

		[Required]
		public string? ImagePath { get; set; }

		[Required]
		public int? CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }

		[Required]
		public int? StayId { get; set; }
		public virtual Stay? Stay { get; set; }

	}
}