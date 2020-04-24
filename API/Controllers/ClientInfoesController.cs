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
    public class ClientInfoesController : ControllerBase
    {
        private readonly EFDbContext _context;

        public ClientInfoesController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/ClientInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientInfo>>> GetClientInfos()
        {
            return await _context.ClientInfos.ToListAsync();
        }

        // GET: api/ClientInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientInfo>> GetClientInfo(int id)
        {
            var clientInfo = await _context.ClientInfos.FindAsync(id);

            if (clientInfo == null)
            {
                return NotFound();
            }

            return clientInfo;
        }

        // PUT: api/ClientInfoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientInfo(int id, ClientInfo clientInfo)
        {
            if (id != clientInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(clientInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientInfoExists(id))
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

        // POST: api/ClientInfoes
        [HttpPost]
        public async Task<ActionResult<ClientInfo>> PostClientInfo(ClientInfo clientInfo)
        {
            _context.ClientInfos.Add(clientInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientInfo", new { id = clientInfo.Id }, clientInfo);
        }

        // DELETE: api/ClientInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ClientInfo>> DeleteClientInfo(int id)
        {
            var clientInfo = await _context.ClientInfos.FindAsync(id);
            if (clientInfo == null)
            {
                return NotFound();
            }

            _context.ClientInfos.Remove(clientInfo);
            await _context.SaveChangesAsync();

            return clientInfo;
        }

        private bool ClientInfoExists(int id)
        {
            return _context.ClientInfos.Any(e => e.Id == id);
        }
    }
}
