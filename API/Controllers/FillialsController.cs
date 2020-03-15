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
    public class FillialsController : ControllerBase
    {
        private readonly EFDbContext _context;

        public FillialsController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/Fillials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fillial>>> GetFillials()
        {
            return await _context.Fillials.ToListAsync();
        }

        // GET: api/Fillials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fillial>> GetFillial(int id)
        {
            var fillial = await _context.Fillials.FindAsync(id);

            if (fillial == null)
            {
                return NotFound();
            }

            return fillial;
        }

        // PUT: api/Fillials/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFillial(int id, Fillial fillial)
        {
            if (id != fillial.Id)
            {
                return BadRequest();
            }

            _context.Entry(fillial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FillialExists(id))
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

        // POST: api/Fillials
        [HttpPost]
        public async Task<ActionResult<Fillial>> PostFillial(Fillial fillial)
        {
            _context.Fillials.Add(fillial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFillial", new { id = fillial.Id }, fillial);
        }

        // DELETE: api/Fillials/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fillial>> DeleteFillial(int id)
        {
            var fillial = await _context.Fillials.FindAsync(id);
            if (fillial == null)
            {
                return NotFound();
            }

            _context.Fillials.Remove(fillial);
            await _context.SaveChangesAsync();

            return fillial;
        }

        private bool FillialExists(int id)
        {
            return _context.Fillials.Any(e => e.Id == id);
        }
    }
}
