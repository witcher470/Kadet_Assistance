using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataTier.Entities.Abstract;
using DataTier.Entities.Concrete;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarBrandController : ControllerBase
    {
        private readonly EFDbContext _context;

        public CarBrandController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/CarBrand
        [HttpGet]
        public IEnumerable<CarBrand> GetCarBrands()
        {
            return _context.CarBrands;
        }

        // GET: api/CarBrand/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarBrand>> GetCarBrand(int id)
        {
            var carBrand = await _context.CarBrands.FindAsync(id);

            if (carBrand == null)
            {
                return NotFound();
            }

            return carBrand;
        }

        // PUT: api/CarBrand/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarBrand(int id, CarBrand carBrand)
        {
            if (id != carBrand.Id)
            {
                return BadRequest();
            }

            _context.Entry(carBrand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarBrandExists(id))
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

        // POST: api/CarBrand
        [HttpPost]
        public async Task<ActionResult<CarBrand>> PostCarBrand(CarBrand carBrand)
        {
            _context.CarBrands.Add(carBrand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarBrand", new { id = carBrand.Id }, carBrand);
        }

        // DELETE: api/CarBrand/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CarBrand>> DeleteCarBrand(int id)
        {
            var carBrand = await _context.CarBrands.FindAsync(id);
            if (carBrand == null)
            {
                return NotFound();
            }

            _context.CarBrands.Remove(carBrand);
            await _context.SaveChangesAsync();

            return carBrand;
        }

        private bool CarBrandExists(int id)
        {
            return _context.CarBrands.Any(e => e.Id == id);
        }
    }
}
