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
using HotelBooking.Server.IRepository;
using HotelBooking.Shared.Domain;

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

        // GET: api/RoomTypes
        [HttpGet]
        /*public async Task<ActionResult<IEnumerable<RoomType>>> GetRoomTypes()
        {
          if (_context.RoomTypes == null)
          {
              return NotFound();
          }
            return await _context.RoomTypes.ToListAsync();
        }*/
        public async Task<IActionResult> GetRoomTypes()
        {
            var roomtypes = await _unitOfWork.RoomTypes.GetAll();
            return Ok(roomtypes);
        }

        // GET: api/RoomTypes/5
        [HttpGet("{id}")]
        /*public async Task<ActionResult<RoomType>> GetRoomType(int id)
        {
          if (_context.RoomTypes == null)
          {
              return NotFound();
          }
            var roomtype = await _context.RoomTypes.FindAsync(id);

            if (roomtype == null)
            {
                return NotFound();
            }

            return roomtype;
        }*/
        public async Task<IActionResult> GetRoomType(int id)
        {
            var roomtype = await _unitOfWork.RoomTypes.Get(q => q.Id == id);

            if (roomtype == null)
            {
                return NotFound();
            }

            return Ok(roomtype);
        }

        // PUT: api/RoomTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        /*public async Task<IActionResult> PutRoomType(int id, RoomType roomtype)
        {
            if (id != roomtype.Id)
            {
                return BadRequest();
            }

            _context.Entry(roomtype).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }*/

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

        // POST: api/RoomTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        /*public async Task<ActionResult<RoomType>> PostRoomType(RoomType roomtype)
        {
          if (_context.RoomTypes == null)
          {
              return Problem("Entity set 'ApplicationDbContext.RoomTypes'  is null.");
          }
            _context.RoomTypes.Add(roomtype);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoomType", new { id = roomtype.Id }, roomtype);
        }*/

        public async Task<ActionResult<RoomType>> PostRoomType(RoomType roomtype)
        {
            await _unitOfWork.RoomTypes.Insert(roomtype);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRoomType", new { id = roomtype.Id }, roomtype);
        }

        // DELETE: api/RoomTypes/5
        [HttpDelete("{id}")]
        /*public async Task<IActionResult> DeleteRoomType(int id)
        {
            if (_context.RoomTypes == null)
            {
                return NotFound();
            }
            var roomtype = await _context.RoomTypes.FindAsync(id);
            if (roomtype == null)
            {
                return NotFound();
            }

            _context.RoomTypes.Remove(roomtype);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoomTypeExists(int id)
        {
            return (_context.RoomTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }*/

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