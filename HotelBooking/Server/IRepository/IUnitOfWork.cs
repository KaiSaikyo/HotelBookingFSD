using HotelBooking.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Hotel> Hotels { get; }
        IGenericRepository<RoomType> RoomTypes { get; }
        IGenericRepository<Room> Rooms { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Stay> Stays { get; }
    }
}