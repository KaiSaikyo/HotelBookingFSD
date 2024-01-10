using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Shared.Domain
{
    public class Review
    {
        public int Id { get; set; }

        //decimal(2,1) for numerical rating 0.0 to 5.0 Stars
        public decimal? Rating { get; set; }

        public string? Description { get; set; }

        public DateTime? Date { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }

        /*public int StayId { get; set; }

        public virtual Stay? Stay { get; set; }*/
    }
}
