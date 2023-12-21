using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class Stay
    {
        public int Id { get; set; }

        public string? EmergencyContact { get; set; }

        public bool OccupancyStatus { get; set; }

        public string? ComplimentaryServices { get; set; }

        public int BookingId {  get; set; }

        public virtual Booking? Booking { get; set; }

        public int RoomId { get; set; }

        public virtual Room? Room { get; set; }
    }
}
