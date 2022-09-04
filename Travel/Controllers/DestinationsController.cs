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
    }
}
