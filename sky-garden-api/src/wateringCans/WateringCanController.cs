using System.Net.Http; 
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;

namespace sky_garden_api.src.wateringCans
{
    [ApiController]
    [Route("[controller]")]
    public class WateringCanController : Controller
    {
        private AppDbContext _context;

        public WateringCanController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("wateringCans")]
        public ActionResult<IEnumerable<WateringCan>> Get()
        {
            var wateringCans = _context.WateringCan.AsNoTracking().ToList();
            if (wateringCans is null)
            {
                return NotFound();
            }
            return wateringCans;
        }

        [HttpPost("registerWateringCan")]
        public ActionResult Post(WateringCan wateringCan)
        {
            if (wateringCan is null)
            {
                return BadRequest();
            }

            _context.WateringCan.Add(wateringCan); 
            _context.SaveChanges();
         
            return new CreatedAtRouteResult("ObterCategoria",
            new { id = wateringCan.Id }, wateringCan);
        }


    }
}
