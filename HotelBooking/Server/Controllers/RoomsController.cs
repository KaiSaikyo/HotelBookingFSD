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
    public class RoomsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetRooms()
        {
            var rooms = await _unitOfWork.Rooms.GetAll(
				includes: q => q.Include(x => x.RoomType!));
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            var room = await _unitOfWork.Rooms.Get(q => q.Id == id);

            if (room == null)
            {
                return NotFound();
            }

            return Ok(room);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Rooms.Update(room);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RoomExists(id))
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
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            await _unitOfWork.Rooms.Insert(room);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRoom", new { id = room.Id }, room);
        }

		//
		[HttpGet("roomtype/{roomtypeId:int}")]
		public async Task<ActionResult<bool>> DoesRoomTypeExistinRoom(int roomtypeId)
		{
			var room = await _unitOfWork.Rooms.Get(q => q.RoomTypeId == roomtypeId);

			if (room == null)
			{
				return Ok(false);
			}

			return Ok(true);
		}

		[HttpPut("cascade-delete/{roomtypeId:int}")]
		public async Task<ActionResult<Room>> DeleteRoomTypeFromRoom(int roomtypeId)
		{
			var room = await _unitOfWork.Rooms.Get(q => q.RoomTypeId == roomtypeId);

			if (room == null)
			{
				return NotFound();
			}

			await _unitOfWork.Rooms.Delete(room.Id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}
		//

		[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            if (_unitOfWork.Rooms == null)
            {
                return NotFound();
            }

            var room = await _unitOfWork.Rooms.Get(q => q.Id == id);

            if (room == null)
            {
                return NotFound();
            }

            await _unitOfWork.Rooms.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RoomExists(int id)
        {
            var room = await _unitOfWork.Rooms.Get(q => q.Id == id);
            return room != null;
        }
    }
}