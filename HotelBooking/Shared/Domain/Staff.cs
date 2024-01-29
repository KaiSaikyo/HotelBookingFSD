using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Shared.Domain
{
    public class Staff
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
		public string? Password { get; set;}
		
		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"\d{8}", ErrorMessage = "Contact Number must be 8 digits")]
		public string? Mobile { get; set; }

	}
}
