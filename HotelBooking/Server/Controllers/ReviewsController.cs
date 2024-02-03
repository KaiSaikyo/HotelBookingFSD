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
    public class ReviewsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReviewsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetReviews()
        {
            var reviews = await _unitOfWork.Reviews.GetAll(
                includes: q => q.Include(x => x.Customer!).Include(x => x.Stay!));
            return Ok(reviews);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReview(int id)
        {
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id/*,
                includes: q => q.Include(x => x.Customer!).Include(x => x.Stay!)*/);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReview(int id, Review review)
        {
            if (id != review.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Reviews.Update(review);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ReviewExists(id))
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
        public async Task<ActionResult<Review>> PostReview(Review review)
        {
            await _unitOfWork.Reviews.Insert(review);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReview", new { id = review.Id }, review);
        }

		//
		[HttpGet("stay/{stayId:int}")]
		public async Task<ActionResult<bool>> DoesStayExistinReview(int stayId)
		{
			var review = await _unitOfWork.Reviews.Get(q => q.StayId == stayId);

			if (review == null)
			{
				return Ok(false);
			}

			return Ok(true);
		}

		[HttpPut("cascade-delete/{stayId:int}")]
		public async Task<ActionResult<Review>> DeleteStayFromReview(int stayId)
		{
			var review = await _unitOfWork.Reviews.Get(q => q.StayId == stayId);

			if (review == null)
			{
				return NotFound();
			}

			await _unitOfWork.Reviews.Delete(review.Id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}
		//

		//
		[HttpGet("customer/{customerId:int}")]
		public async Task<ActionResult<bool>> DoesCustomerExistinReview(int customerId)
		{
			var review = await _unitOfWork.Reviews.Get(q => q.CustomerId == customerId);

			if (review == null)
			{
				return Ok(false);
			}

			return Ok(true);
		}

		[HttpPut("cascade-delete/{customerId:int}")]
		public async Task<ActionResult<Review>> DeleteCustomerFromReview(int customerId)
		{
			var review = await _unitOfWork.Reviews.Get(q => q.CustomerId == customerId);

			if (review == null)
			{
				return NotFound();
			}

			await _unitOfWork.Reviews.Delete(review.Id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}
		//

		[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            if (_unitOfWork.Reviews == null)
            {
                return NotFound();
            }

            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);

            if (review == null)
            {
                return NotFound();
            }

            await _unitOfWork.Reviews.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ReviewExists(int id)
        {
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
            return review != null;
        }
    }
}
