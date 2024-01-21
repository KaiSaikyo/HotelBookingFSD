using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class Room
    {
        public int Id { get; set; }

        //alphanumeric room numbers
        public string? Number { get; set; }

        public string? Amenities { get; set; }

        public int? RoomMinStay { get; set; } // Short for small integer values

        public int? RoomMaxStay { get; set; } // Short for small integer values

        public int RoomTypeId { get; set; }

        public virtual RoomType? RoomType { get; set; }
    }
}
