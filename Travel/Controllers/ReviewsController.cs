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
        public async Task<ActionResult<IEnumerable<Review>>> Get()
        {
            {
                return await _db.Reviews.ToListAsync();
            }
        }

        //         // POST api/animals
        //         [HttpPost]
        //         public async Task<ActionResult<City>> Post(City city)
        //         {
        //             _db.Cities.Add(city);
        //             await _db.SaveChangesAsync();

        //             return CreatedAtAction("Post", new { id = city.CityId }, city);
        //         }

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
