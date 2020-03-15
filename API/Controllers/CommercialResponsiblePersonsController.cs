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
    public class CommercialResponsiblePersonsController : ControllerBase
    {
        private readonly EFDbContext _context;

        public CommercialResponsiblePersonsController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/CommercialResponsiblePersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommercialResponsiblePerson>>> GetCommercialResponsiblePersons()
        {
            return await _context.CommercialResponsiblePersons.ToListAsync();
        }

        // GET: api/CommercialResponsiblePersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommercialResponsiblePerson>> GetCommercialResponsiblePerson(int id)
        {
            var commercialResponsiblePerson = await _context.CommercialResponsiblePersons.FindAsync(id);

            if (commercialResponsiblePerson == null)
            {
                return NotFound();
            }

            return commercialResponsiblePerson;
        }

        // PUT: api/CommercialResponsiblePersons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommercialResponsiblePerson(int id, CommercialResponsiblePerson commercialResponsiblePerson)
        {
            if (id != commercialResponsiblePerson.Id)
            {
                return BadRequest();
            }

            _context.Entry(commercialResponsiblePerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommercialResponsiblePersonExists(id))
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

        // POST: api/CommercialResponsiblePersons
        [HttpPost]
        public async Task<ActionResult<CommercialResponsiblePerson>> PostCommercialResponsiblePerson(CommercialResponsiblePerson commercialResponsiblePerson)
        {
            _context.CommercialResponsiblePersons.Add(commercialResponsiblePerson);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommercialResponsiblePerson", new { id = commercialResponsiblePerson.Id }, commercialResponsiblePerson);
        }

        // DELETE: api/CommercialResponsiblePersons/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CommercialResponsiblePerson>> DeleteCommercialResponsiblePerson(int id)
        {
            var commercialResponsiblePerson = await _context.CommercialResponsiblePersons.FindAsync(id);
            if (commercialResponsiblePerson == null)
            {
                return NotFound();
            }

            _context.CommercialResponsiblePersons.Remove(commercialResponsiblePerson);
            await _context.SaveChangesAsync();

            return commercialResponsiblePerson;
        }

        private bool CommercialResponsiblePersonExists(int id)
        {
            return _context.CommercialResponsiblePersons.Any(e => e.Id == id);
        }
    }
}
