using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class Hotel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Description { get; set; }

        public string? Amenities { get; set; }

        //decimal(2,1) for numerical rating 0.0 to 5.0 Stars
        public decimal? Rating { get; set; }

        //staff to limit hotel availability for booking
        public bool Availability { get; set; }
    }
}
