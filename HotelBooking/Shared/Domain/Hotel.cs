using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class Hotel 
	{
        public int Id { get; set; }

		[Required]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "Name does not meet length requirements")]
		public string? Name { get; set; }

		[Required]
		[StringLength(200, MinimumLength = 3, ErrorMessage = "Address does not meet length requirements")]
		public string? Address { get; set; }

		[Required]
		[StringLength(500, MinimumLength = 3, ErrorMessage = "Description does not meet length requirements")]
		public string? Description { get; set; }

		[Required]
		[StringLength(500, MinimumLength = 3, ErrorMessage = "Description does not meet length requirements")]
		public string? Amenities { get; set; }

		[Required]
		[Range(0.0, 5.0, ErrorMessage = "Rating must be between 0.0 and 5.0")]
		public decimal? Rating { get; set; }
		
		[Required]
		[RegularExpression(@"^(true|false)$", ErrorMessage = "Availability must be either 'true' or 'false'")]
		public string? Availability { get; set; }

		
		public string? ImagePath { get; set; }
	}
}
