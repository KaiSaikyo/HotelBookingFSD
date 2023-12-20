using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class Staff
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set;}

        public string? Mobile { get; set; }
    }
}
