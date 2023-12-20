using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class RoomType
    {
        public int Id { get; set; } 

        public string? Description { get; set; }

        public string? Size { get; set; }

        public decimal? Price { get; set; }

        public int HotelId { get; set; }

        public virtual Hotel? Hotel { get; set; }
    }
}
