using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataTier.Entities.Abstract;
using DataTier.Entities.Concrete.Enums;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SettlementPeriodsController : ControllerBase
    {
        private readonly EFDbContext _context;

        public SettlementPeriodsController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/SettlementPeriods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SettlementPeriod>>> GetSettlementPeriods()
        {
            return await _context.SettlementPeriods.ToListAsync();
        }

        // GET: api/SettlementPeriods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SettlementPeriod>> GetSettlementPeriod(int id)
        {
            var settlementPeriod = await _context.SettlementPeriods.FindAsync(id);

            if (settlementPeriod == null)
            {
                return NotFound();
            }

            return settlementPeriod;
        }

        // PUT: api/SettlementPeriods/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSettlementPeriod(int id, SettlementPeriod settlementPeriod)
        {
            if (id != settlementPeriod.Id)
            {
                return BadRequest();
            }

            _context.Entry(settlementPeriod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SettlementPeriodExists(id))
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

        // POST: api/SettlementPeriods
        [HttpPost]
        public async Task<ActionResult<SettlementPeriod>> PostSettlementPeriod(SettlementPeriod settlementPeriod)
        {
            _context.SettlementPeriods.Add(settlementPeriod);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSettlementPeriod", new { id = settlementPeriod.Id }, settlementPeriod);
        }

        // DELETE: api/SettlementPeriods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SettlementPeriod>> DeleteSettlementPeriod(int id)
        {
            var settlementPeriod = await _context.SettlementPeriods.FindAsync(id);
            if (settlementPeriod == null)
            {
                return NotFound();
            }

            _context.SettlementPeriods.Remove(settlementPeriod);
            await _context.SaveChangesAsync();

            return settlementPeriod;
        }

        private bool SettlementPeriodExists(int id)
        {
            return _context.SettlementPeriods.Any(e => e.Id == id);
        }
    }
}
