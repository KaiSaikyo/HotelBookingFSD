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
    public class StaysController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StaysController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Stays
        [HttpGet]
        /*public async Task<ActionResult<IEnumerable<Stay>>> GetStays()
        {
          if (_context.Stays == null)
          {
              return NotFound();
          }
            return await _context.Stays.ToListAsync();
        }*/
        public async Task<IActionResult> GetStays()
        {
            var stays = await _unitOfWork.Stays.GetAll();
            return Ok(stays);
        }

        // GET: api/Stays/5
        [HttpGet("{id}")]
        /*public async Task<ActionResult<Stay>> GetStay(int id)
        {
          if (_context.Stays == null)
          {
              return NotFound();
          }
            var stay = await _context.Stays.FindAsync(id);

            if (stay == null)
            {
                return NotFound();
            }

            return stay;
        }*/
        public async Task<IActionResult> GetStay(int id)
        {
            var stay = await _unitOfWork.Stays.Get(q => q.Id == id);

            if (stay == null)
            {
                return NotFound();
            }

            return Ok(stay);
        }

        // PUT: api/Stays/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        /*public async Task<IActionResult> PutStay(int id, Stay stay)
        {
            if (id != stay.Id)
            {
                return BadRequest();
            }

            _context.Entry(stay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StayExists(id))
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

        // POST: api/Stays
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        /*public async Task<ActionResult<Stay>> PostStay(Stay stay)
        {
          if (_context.Stays == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Stays'  is null.");
          }
            _context.Stays.Add(stay);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStay", new { id = stay.Id }, stay);
        }*/

        public async Task<ActionResult<Stay>> PostStay(Stay stay)
        {
            await _unitOfWork.Stays.Insert(stay);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStay", new { id = stay.Id }, stay);
        }

        // DELETE: api/Stays/5
        [HttpDelete("{id}")]
        /*public async Task<IActionResult> DeleteStay(int id)
        {
            if (_context.Stays == null)
            {
                return NotFound();
            }
            var stay = await _context.Stays.FindAsync(id);
            if (stay == null)
            {
                return NotFound();
            }

            _context.Stays.Remove(stay);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StayExists(int id)
        {
            return (_context.Stays?.Any(e => e.Id == id)).GetValueOrDefault();
        }*/

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