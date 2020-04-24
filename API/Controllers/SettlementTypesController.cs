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
    public class SettlementTypesController : ControllerBase
    {
        private readonly EFDbContext _context;

        public SettlementTypesController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/SettlementTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SettlementType>>> GetSettlementTypes()
        {
            return await _context.SettlementTypes.ToListAsync();
        }

        // GET: api/SettlementTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SettlementType>> GetSettlementType(int id)
        {
            var settlementType = await _context.SettlementTypes.FindAsync(id);

            if (settlementType == null)
            {
                return NotFound();
            }

            return settlementType;
        }

        // PUT: api/SettlementTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSettlementType(int id, SettlementType settlementType)
        {
            if (id != settlementType.Id)
            {
                return BadRequest();
            }

            _context.Entry(settlementType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SettlementTypeExists(id))
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

        // POST: api/SettlementTypes
        [HttpPost]
        public async Task<ActionResult<SettlementType>> PostSettlementType(SettlementType settlementType)
        {
            _context.SettlementTypes.Add(settlementType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSettlementType", new { id = settlementType.Id }, settlementType);
        }

        // DELETE: api/SettlementTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SettlementType>> DeleteSettlementType(int id)
        {
            var settlementType = await _context.SettlementTypes.FindAsync(id);
            if (settlementType == null)
            {
                return NotFound();
            }

            _context.SettlementTypes.Remove(settlementType);
            await _context.SaveChangesAsync();

            return settlementType;
        }

        private bool SettlementTypeExists(int id)
        {
            return _context.SettlementTypes.Any(e => e.Id == id);
        }
    }
}
