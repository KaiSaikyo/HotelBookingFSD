using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Server.Data;
using HotelBooking.Shared.Domain;
using HotelBooking.Server.IRepository;

namespace HotelBooking.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var bookings = await _unitOfWork.Bookings.GetAll(
                includes: q => q.Include(x => x.Customer!).Include(x => x.Staff!).Include(x => x.Hotel!).Include(x => x.RoomType!));
            return Ok(bookings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Bookings.Update(booking);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            await _unitOfWork.Bookings.Insert(booking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
        }

        //
        [HttpGet("hotel/{hotelId:int}")]
        public async Task<ActionResult<bool>> DoesHotelExistinBooking(int hotelId)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.HotelId == hotelId);

            if (booking == null)
            {
                return Ok(false);
            }

            return Ok(true);
        }

        [HttpPut("cascade-delete/{hotelId:int}")]
        public async Task<ActionResult<Booking>> DeleteHotelFromBooking(int hotelId)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.HotelId == hotelId);

            if (booking == null)
            {
                return NotFound();
            }

            await _unitOfWork.Stays.Delete(booking.Id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }
		//

		//
		[HttpGet("roomtype/{roomtypeId:int}")]
		public async Task<ActionResult<bool>> DoesRoomTypeExistinBooking(int roomtypeId)
		{
			var booking = await _unitOfWork.Bookings.Get(q => q.RoomTypeId == roomtypeId);

			if (booking == null)
			{
				return Ok(false);
			}

			return Ok(true);
		}

		[HttpPut("cascade-delete/{roomtypeId:int}")]
		public async Task<ActionResult<Booking>> DeleteRoomTypeFromBooking(int roomtypeId)
		{
			var booking = await _unitOfWork.Bookings.Get(q => q.RoomTypeId == roomtypeId);

			if (booking == null)
			{
				return NotFound();
			}

			await _unitOfWork.Bookings.Delete(booking.Id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}
		//

		//
		[HttpGet("customer/{customerId:int}")]
		public async Task<ActionResult<bool>> DoesCustomerExistinBooking(int customerId)
		{
			var booking = await _unitOfWork.Bookings.Get(q => q.CustomerId == customerId);

			if (booking == null)
			{
				return Ok(false);
			}

			return Ok(true);
		}

		[HttpPut("cascade-delete/{customerId:int}")]
		public async Task<ActionResult<Booking>> DeleteCustomerFromBooking(int customerId)
		{
			var booking = await _unitOfWork.Bookings.Get(q => q.CustomerId == customerId);

			if (booking == null)
			{
				return NotFound();
			}

			await _unitOfWork.Bookings.Delete(booking.Id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}
		//

		//
		[HttpGet("staff/{staffId:int}")]
		public async Task<ActionResult<bool>> DoesStaffExistinBooking(int staffId)
		{
			var booking = await _unitOfWork.Bookings.Get(q => q.StaffId == staffId);

			if (booking == null)
			{
				return Ok(false);
			}

			return Ok(true);
		}

		[HttpPut("cascade-delete/{staffId:int}")]
		public async Task<ActionResult<Booking>> DeleteStaffFromBooking(int staffId)
		{
			var booking = await _unitOfWork.Bookings.Get(q => q.StaffId == staffId);

			if (booking == null)
			{
				return NotFound();
			}

			await _unitOfWork.Bookings.Delete(booking.Id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}
		//

		[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            if (_unitOfWork.Bookings == null)
            {
                return NotFound();
            }

            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

		private async Task<bool> BookingExists(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            return booking != null;
        }
    }
}