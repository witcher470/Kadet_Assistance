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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LegalPersonsController : ControllerBase
    {
        private readonly EFDbContext _context;

        public LegalPersonsController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/LegalPersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegalPerson>>> GetLegalPersons()
        {
            return await _context.LegalPersons.ToListAsync();
        }

        // GET: api/LegalPersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegalPerson>> GetLegalPerson(int id)
        {
            var legalPerson = await _context.LegalPersons.FindAsync(id);

            if (legalPerson == null)
            {
                return NotFound();
            }

            return legalPerson;
        }

        // PUT: api/LegalPersons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLegalPerson(int id, LegalPerson legalPerson)
        {
            if (id != legalPerson.Id)
            {
                return BadRequest();
            }

            _context.Entry(legalPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegalPersonExists(id))
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

        // POST: api/LegalPersons
        [HttpPost]
        public async Task<ActionResult<LegalPerson>> PostLegalPerson(LegalPerson legalPerson)
        {
            _context.LegalPersons.Add(legalPerson);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLegalPerson", new { id = legalPerson.Id }, legalPerson);
        }

        // DELETE: api/LegalPersons/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LegalPerson>> DeleteLegalPerson(int id)
        {
            var legalPerson = await _context.LegalPersons.FindAsync(id);
            if (legalPerson == null)
            {
                return NotFound();
            }

            _context.LegalPersons.Remove(legalPerson);
            await _context.SaveChangesAsync();

            return legalPerson;
        }

        private bool LegalPersonExists(int id)
        {
            return _context.LegalPersons.Any(e => e.Id == id);
        }
    }
}
