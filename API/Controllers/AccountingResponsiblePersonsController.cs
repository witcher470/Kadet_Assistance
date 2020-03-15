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
    public class AccountingResponsiblePersonsController : ControllerBase
    {
        private readonly EFDbContext _context;

        public AccountingResponsiblePersonsController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/AccountingResponsiblePersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountingResponsiblePerson>>> GetAccountingResponsiblePersons()
        {
            return await _context.AccountingResponsiblePersons.ToListAsync();
        }

        // GET: api/AccountingResponsiblePersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountingResponsiblePerson>> GetAccountingResponsiblePerson(int id)
        {
            var accountingResponsiblePerson = await _context.AccountingResponsiblePersons.FindAsync(id);

            if (accountingResponsiblePerson == null)
            {
                return NotFound();
            }

            return accountingResponsiblePerson;
        }

        // PUT: api/AccountingResponsiblePersons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccountingResponsiblePerson(int id, AccountingResponsiblePerson accountingResponsiblePerson)
        {
            if (id != accountingResponsiblePerson.Id)
            {
                return BadRequest();
            }

            _context.Entry(accountingResponsiblePerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountingResponsiblePersonExists(id))
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

        // POST: api/AccountingResponsiblePersons
        [HttpPost]
        public async Task<ActionResult<AccountingResponsiblePerson>> PostAccountingResponsiblePerson(AccountingResponsiblePerson accountingResponsiblePerson)
        {
            _context.AccountingResponsiblePersons.Add(accountingResponsiblePerson);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccountingResponsiblePerson", new { id = accountingResponsiblePerson.Id }, accountingResponsiblePerson);
        }

        // DELETE: api/AccountingResponsiblePersons/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AccountingResponsiblePerson>> DeleteAccountingResponsiblePerson(int id)
        {
            var accountingResponsiblePerson = await _context.AccountingResponsiblePersons.FindAsync(id);
            if (accountingResponsiblePerson == null)
            {
                return NotFound();
            }

            _context.AccountingResponsiblePersons.Remove(accountingResponsiblePerson);
            await _context.SaveChangesAsync();

            return accountingResponsiblePerson;
        }

        private bool AccountingResponsiblePersonExists(int id)
        {
            return _context.AccountingResponsiblePersons.Any(e => e.Id == id);
        }
    }
}
