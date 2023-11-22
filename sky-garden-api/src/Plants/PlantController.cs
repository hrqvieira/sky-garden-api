using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sky_garden_api.src.wateringCans;

namespace sky_garden_api.src.Plants
{

    [ApiController]
    [Route("[controller]")]
    public class PlantController : Controller
    {
        private AppDbContext _context;

        public PlantController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("plants")]
        public ActionResult<IEnumerable<Plant>> Get()
        {
            var plants = _context.Plant.AsNoTracking().ToList();
            if (plants is null)
            {
                return NotFound();
            }
            return plants;
        }

        [HttpPost("registerPlant")]
        public ActionResult Post(Plant plant)
        {
            if (plant is null)
            {
                return BadRequest();
            }

            _context.Plant.Add(plant);
            _context.SaveChanges();

            //return Ok(plant);

            return new CreatedAtRouteResult("plants",
            new { id = plant.Id }, plant);
        }
    }
}
