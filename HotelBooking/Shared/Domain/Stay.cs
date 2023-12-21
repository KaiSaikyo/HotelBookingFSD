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

    }
}
