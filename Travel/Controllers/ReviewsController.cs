using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;
using System;
using System.Linq;

namespace Travel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly TravelContext _db;

        public ReviewsController(TravelContext db)
        {
            _db = db;
        }

        // GET api/reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetCity(string city, int mostPopular)
        {
            IQueryable<Review> query = _db.Reviews.AsQueryable();

            IQueryable<Review> reviews = _db.Reviews;
            IQueryable<Destination> destinations = _db.Destinations;

            if (mostPopular > 0)
            {
                query = query.Where(entry => entry.Rating >= mostPopular);
            }
            if (city != null)
            {
                // query =
                //     from r in _db.Reviews
                //     join d in _db.Destinations on r.DestinationId equals d.DestinationId
                //     where d.City == city
                //     select r;
                query = reviews
                    .Join(
                        destinations,
                        review => review.ReviewId,
                        destination => destination.DestinationId,
                        (review, destination) => new { Review = review, Destination = destination } // two tables now combined into single object
                    )
                    .Where(reviewAndDestination => reviewAndDestination.Destination.City == city) // filter by accessing destination property in combined object
                    .Select(reviewAndDestination => reviewAndDestination.Review); // discard Destination and select only Review so types of query match
            }

            return await query.ToListAsync();
        }

        // POST api/reviews
        [HttpPost]
        public async Task<ActionResult<Review>> Post(Review review)
        {
            _db.Reviews.Add(review);
            await _db.SaveChangesAsync();

            return CreatedAtAction("Post", new { id = review.ReviewId }, review);
        }

        //         [HttpGet("{id}")]
        //         public async Task<ActionResult<City>> GetCity(int id)
        //         {
        //             var city = await _db.Cities.FindAsync(id);

        //             if (city == null)
        //             {
        //                 return NotFound();
        //             }

        //             return city;
        //         }

        //         // PUT: api/Animals/5
        //         [HttpPut("{id}")]
        //         public async Task<IActionResult> Put(int id, City city)
        //         {
        //             if (id != city.CityId)
        //             {
        //                 return BadRequest();
        //             }

        //             _db.Entry(city).State = EntityState.Modified;

        //             try
        //             {
        //                 await _db.SaveChangesAsync();
        //             }
        //             catch (DbUpdateConcurrencyException)
        //             {
        //                 if (!CityExists(id))
        //                 {
        //                     return NotFound();
        //                 }
        //                 else
        //                 {
        //                     throw;
        //                 }
        //             }

        //             return NoContent();
        //         }

        //         // DELETE: api/Animals/5
        //         [HttpDelete("{id}")]
        //         public async Task<IActionResult> DeleteCity(int id)
        //         {
        //             var city = await _db.Cities.FindAsync(id);
        //             if (city == null)
        //             {
        //                 return NotFound();
        //             }

        //             _db.Cities.Remove(city);
        //             await _db.SaveChangesAsync();

        //             return NoContent();
        //         }

        //         private bool CityExists(int id)
        //         {
        //             return _db.Cities.Any(e => e.CityId == id);
        //         }
    }
}
