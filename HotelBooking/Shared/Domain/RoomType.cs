using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class RoomType : IValidatableObject
	{
        public int Id { get; set; }

		[Required]
		[StringLength(500, MinimumLength = 3, ErrorMessage = "Description does not meet length requirements")]
		public string? Description { get; set; }

        [Required]
		[RegularExpression(@"^\d+(?:\.\d+)? sqm$", ErrorMessage = "Size must be a number followed by ' sqm'")]
		public string? Size { get; set; }

        [Required]
		[Range(0, 9999.99)]
		public decimal? Price { get; set; }

		[Required]
		public int HotelId { get; set; }

        public virtual Hotel? Hotel { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			throw new NotImplementedException();
		}
	}
}
