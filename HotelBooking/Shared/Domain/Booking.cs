using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime? CheckInDate {  get; set; }

        public DateTime? CheckOutDate { get; set; }

        public string? Destination { get; set; }

        public int? NumGuest { get; set; }

        public string? Status { get; set; }

        public int HotelId { get; set; }

        public virtual Hotel? Hotel { get; set; }

        public int StaffId { get; set; }

        public virtual Staff? Staff { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }

        public int? RoomTypeId { get; set; }

        public virtual RoomType? RoomType { get; set; }
    }
}
