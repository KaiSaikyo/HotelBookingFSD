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
    public class RoomTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetRoomTypes()
        {
            var roomtypes = await _unitOfWork.RoomTypes.GetAll(includes: q => q.Include(x => x.Hotel!));
            return Ok(roomtypes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomType(int id)
        {
            var roomtype = await _unitOfWork.RoomTypes.Get(q => q.Id == id);

            if (roomtype == null)
            {
                return NotFound();
            }

            return Ok(roomtype);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomType(int id, RoomType roomtype)
        {
            if (id != roomtype.Id)
            {
                return BadRequest();
            }

            _unitOfWork.RoomTypes.Update(roomtype);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RoomTypeExists(id))
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
        public async Task<ActionResult<RoomType>> PostRoomType(RoomType roomtype)
        {
            await _unitOfWork.RoomTypes.Insert(roomtype);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRoomType", new { id = roomtype.Id }, roomtype);
        }

		//
		[HttpGet("hotel/{hotelId:int}")]
		public async Task<ActionResult<bool>> DoesHotelExistinRoomType(int hotelId)
		{
			var roomtype = await _unitOfWork.RoomTypes.Get(q => q.HotelId == hotelId);

			if (roomtype == null)
			{
				return Ok(false);
			}

			return Ok(true);
		}

		[HttpPut("cascade-delete/{hotelId:int}")]
		public async Task<ActionResult<RoomType>> DeleteHotelFromRoomType(int hotelId)
		{
			var roomtype = await _unitOfWork.RoomTypes.Get(q => q.HotelId == hotelId);

			if (roomtype == null)
			{
				return NotFound();
			}

			await _unitOfWork.Stays.Delete(roomtype.Id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}
		//

		[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomType(int id)
        {
            if (_unitOfWork.RoomTypes == null)
            {
                return NotFound();
            }

            var roomtype = await _unitOfWork.RoomTypes.Get(q => q.Id == id);

            if (roomtype == null)
            {
                return NotFound();
            }

            await _unitOfWork.RoomTypes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RoomTypeExists(int id)
        {
            var roomtype = await _unitOfWork.RoomTypes.Get(q => q.Id == id);
            return roomtype != null;
        }
    }
}