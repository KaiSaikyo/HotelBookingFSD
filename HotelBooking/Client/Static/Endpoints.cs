using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
        public static readonly string HotelsEndpoint = $"{Prefix}/hotels";
        public static readonly string RoomsEndpoint = $"{Prefix}/rooms";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string RoomTypesEndpoint = $"{Prefix}/roomtypes";
        public static readonly string StaysEndpoint = $"{Prefix}/stays";
    }
}
