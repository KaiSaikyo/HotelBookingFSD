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
    public class StaysController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StaysController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetStays()
        {
            var stays = await _unitOfWork.Stays.GetAll(
				includes: q => q.Include(x => x.Booking!).Include(x => x.Room!));
            return Ok(stays);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStay(int id)
        {
            var stay = await _unitOfWork.Stays.Get(q => q.Id == id);

            if (stay == null)
            {
                return NotFound();
            }

            return Ok(stay);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStay(int id, Stay stay)
        {
            if (id != stay.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Stays.Update(stay);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await StayExists(id))
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
        public async Task<ActionResult<Stay>> PostStay(Stay stay)
        {
            await _unitOfWork.Stays.Insert(stay);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStay", new { id = stay.Id }, stay);
        }

        //
        [HttpGet("booking/{bookingId:int}")]
        public async Task<ActionResult<bool>> DoesBookingExistinStay(int bookingId)
        {
            var stay = await _unitOfWork.Stays.Get(q => q.BookingId == bookingId);

            if (stay == null)
            {
                return Ok(false);
            }

            return Ok(true);
        }

        [HttpPut("cascade-delete/{bookingId:int}")]
        public async Task<ActionResult<Stay>> DeleteBookingFromStay(int bookingId)
        {
            var stay = await _unitOfWork.Stays.Get(q => q.BookingId == bookingId);

            if (stay == null)
            {
                return NotFound();
            }

            await _unitOfWork.Stays.Delete(stay.Id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }
        //

        //
        [HttpGet("room/{roomId:int}")]
        public async Task<ActionResult<bool>> DoesRoomExistinStay(int roomId)
        {
            var stay = await _unitOfWork.Stays.Get(q => q.RoomId == roomId);

            if (stay == null)
            {
                return Ok(false);
            }

            return Ok(true);
        }

        [HttpPut("cascade-delete/{roomId:int}")]
        public async Task<ActionResult<Stay>> DeleteRoomFromStay(int roomId)
        {
            var stay = await _unitOfWork.Stays.Get(q => q.RoomId == roomId);

            if (stay == null)
            {
                return NotFound();
            }

            await _unitOfWork.Stays.Delete(stay.Id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }
        //

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStay(int id)
        {
            if (_unitOfWork.Stays == null)
            {
                return NotFound();
            }

            var stay = await _unitOfWork.Stays.Get(q => q.Id == id);

            if (stay == null)
            {
                return NotFound();
            }

            await _unitOfWork.Stays.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> StayExists(int id)
        {
            var stay = await _unitOfWork.Stays.Get(q => q.Id == id);
            return stay != null;
        }
    }
}