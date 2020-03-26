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
    public class UsersController : ControllerBase
    {
        private readonly EFDbContext _context;

        public UsersController(EFDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {

            return await _context.Users.ToListAsync();
        }
        // GET: api/UsersSortedByStatus
        [HttpGet]
        public IActionResult GetUsersSortedByStatus()
        {
            var users = _context.Users.OrderBy(us => us.UserStatus);
            return Ok(users);
        }
        // GET: api/UsersSortedByRole
        [HttpGet]
        public IActionResult GetUsersSortedByRole()
        {
            var users = _context.Users.OrderBy(us => us.Role);
            return Ok(users);
        }
        [HttpGet]
        public IActionResult SearchByFirstName(string searchString)
        {
            var users = from us in _context.Users
                        select us;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.FirstName.Contains(searchString));
            }

            return Ok(users);
        }
        [HttpGet]
        public IActionResult SearchBySecondName(string searchString)
        {
            var users = from us in _context.Users
                        select us;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.SecondName.Contains(searchString));
            }

            return Ok(users);
        }
        [HttpGet]
        public IActionResult SearchByThirdName(string searchString)
        {
            var users = from us in _context.Users
                        select us;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.ThirdName.Contains(searchString));
            }

            return Ok(users);
        }
        [HttpGet]
        public IActionResult SearchByCountry(string searchString)
        {
            var users = from us in _context.Users
                        select us;

            if (!String.IsNullOrEmpty(searchString))
            {

                users = users.Include<Country>.Where(s => s.Country.CountryName == searchString);
            }

            return Ok(users);
        }
        [HttpGet]
        public IActionResult SearchByMainLanguage(string searchString)
        {
            var users = from us in _context.Users
                        select us;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.MainLanguage.Contains(searchString));
            }

            return Ok(users);
        }
        [HttpGet]
        public IActionResult SearchByAnotherLanguage(string searchString)
        {
            var users = from us in _context.Users
                        select us;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.AnotherLanguage.Contains(searchString));
            }

            return Ok(users);
        }
        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
