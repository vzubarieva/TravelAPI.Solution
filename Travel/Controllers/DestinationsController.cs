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
    public class DestinationsController : ControllerBase
    {
        private readonly TravelContext _db;

        // public class ResultGrouping
        // {
        //     public int DestinationId { get; set; }

        //     // public Review[] Results { get; set; }
        //     public int Count { get; set; }
        // }

        public DestinationsController(TravelContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destination>>> Get(string city)
        {
            IQueryable<Destination> query = _db.Destinations.AsQueryable();

            if (city != null)
            {
                query = query.Where(entry => entry.City == city);
            }

            return await query.ToListAsync();
        }

        [HttpGet("MostPopular")]
        // public async Task<ActionResult<IEnumerable<ResultGrouping>>> GetMostPopular(int limit)
        public async Task<ActionResult<IEnumerable<Destination>>> GetMostPopular(int limit)
        {
            IQueryable<Review> reviews = _db.Reviews;
            IQueryable<Destination> destinations = _db.Destinations;

            IQueryable<Destination> sortedDestinations = reviews
                // .Join(
                //     destinations,
                //     review => review.DestinationId,
                //     destination => destination.DestinationId,
                //     (review, destination) => new { Review = review, Destination = destination } // two tables now combined into single object
                // )
                .GroupBy(r => r.DestinationId)
                .OrderByDescending(r => r.Count())
                .Select(r => destinations.FirstOrDefault(d => d.DestinationId == r.Key));
            // .Select(
            //     r =>
            //         new ResultGrouping
            //         {
            //             DestinationId = r.Key,
            //             // Results = r.ToArray(),
            //             Count = r.Count()
            //         }
            // );

            return await sortedDestinations.ToListAsync();
        }
    }
}
