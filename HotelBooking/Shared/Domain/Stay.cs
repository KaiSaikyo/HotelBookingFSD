﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
	public class Stay
	{
		public int Id { get; set; }

		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"\d{8}", ErrorMessage = "Contact Number must be 8 digits")]
		public string? EmergencyContact { get; set; }

		[Required]
		[RegularExpression(@"^(true|false)$", ErrorMessage = "Status must be either 'true' or 'false'")]
		public string? OccupancyStatus { get; set; }

		[Required]
		[StringLength(500, MinimumLength = 3, ErrorMessage = "Complimentry Services does not meet length requirements")]
		public string? ComplimentaryServices { get; set; }

		[Required]
		public int? BookingId { get; set; }
		public virtual Booking? Booking { get; set; }

		[Required]
		public int? RoomId { get; set; }
		public virtual Room? Room { get; set; }

	}
}