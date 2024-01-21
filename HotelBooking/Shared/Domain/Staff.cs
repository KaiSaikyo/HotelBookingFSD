using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Shared.Domain
{
    public class Staff : IValidatableObject
    {
        public int Id { get; set; }
		[Required]
		public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set;}

        public string? Mobile { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			throw new NotImplementedException();
		}
	}
}
