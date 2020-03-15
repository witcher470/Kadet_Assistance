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
    public class DealerCentersController : ControllerBase
    {
        private readonly EFDbContext _context;

        public DealerCentersController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/DealerCenters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DealerCenter>>> GetDealerCenters()
        {
            return await _context.DealerCenters.ToListAsync();
        }

        // GET: api/DealerCenters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DealerCenter>> GetDealerCenter(int id)
        {
            var dealerCenter = await _context.DealerCenters.FindAsync(id);

            if (dealerCenter == null)
            {
                return NotFound();
            }

            return dealerCenter;
        }

        // PUT: api/DealerCenters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDealerCenter(int id, DealerCenter dealerCenter)
        {
            if (id != dealerCenter.Id)
            {
                return BadRequest();
            }

            _context.Entry(dealerCenter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DealerCenterExists(id))
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

        // POST: api/DealerCenters
        [HttpPost]
        public async Task<ActionResult<DealerCenter>> PostDealerCenter(DealerCenter dealerCenter)
        {
            _context.DealerCenters.Add(dealerCenter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDealerCenter", new { id = dealerCenter.Id }, dealerCenter);
        }

        // DELETE: api/DealerCenters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DealerCenter>> DeleteDealerCenter(int id)
        {
            var dealerCenter = await _context.DealerCenters.FindAsync(id);
            if (dealerCenter == null)
            {
                return NotFound();
            }

            _context.DealerCenters.Remove(dealerCenter);
            await _context.SaveChangesAsync();

            return dealerCenter;
        }

        private bool DealerCenterExists(int id)
        {
            return _context.DealerCenters.Any(e => e.Id == id);
        }
    }
}
