using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class Room : IValidatableObject
	{
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"\d{3,}\w$", ErrorMessage = "Number must have at least 3 digits followed by a letter")]
        public string? Number { get; set; }

		[Required]
		[StringLength(500, MinimumLength = 3, ErrorMessage = "Amenities does not meet length requirements")]
		public string? Amenities { get; set; }

		[Required]
		[Range(1, 10)]
		public int? RoomMinStay { get; set; }

		[Required]
		[Range(1, 10)]
		public int? RoomMaxStay { get; set; }

		public int? RoomTypeId { get; set; }

        public virtual RoomType? RoomType { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (RoomMaxStay != null && RoomMinStay != null)
			{
				if (RoomMaxStay < RoomMinStay)
				{
					yield return new ValidationResult("Max Stay must be greater than or equal to Min Stay", new[] { "RoomMaxStay" });
				}
			}
		}
	}
}
