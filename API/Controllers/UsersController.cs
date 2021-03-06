﻿using System;
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
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUsersById(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
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
            var users = from us in _context.Users.Where(ur => ur.RoleId == 2)
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
            var users = from us in _context.Users.Where(ur => ur.RoleId == 2)
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
            var users = from us in _context.Users.Where(ur => ur.RoleId == 2)
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
            IQueryable<User> users = from us in _context.Users.Where(ur => ur.RoleId == 2)
                                     select us;
            IQueryable<Country> countries =from s in _context.Countries
                                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(us => us.CountryId == us.Country.Id).Where(us => us.Country.Name.Contains(searchString));
            }

            return Ok(users);
        }
        [HttpGet]
        public IActionResult SearchByMainLanguage(string searchString)
        {
            var users = from us in _context.Users.Where(ur => ur.RoleId == 2)
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
            var users = from us in _context.Users.Where(ur => ur.RoleId == 2)
                        select us;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.AnotherLanguage.Contains(searchString));
            }

            return Ok(users);
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetDispatchers()
        {
            IQueryable<User> users = _context.Users;
            if (users != null)
            {
                users = users.Where(os => os.RoleId == 2);
            }
            return users.ToList();
        }
        // GET: api/Users/5
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetSupervisors()
        {
            IQueryable<User> users = _context.Users;
            if (users != null)
            {
                users = users.Where(os => os.RoleId == 1);
            }
            return users.ToList();
        }
        [HttpGet]
        public IActionResult GetActiveDispatchers()
        {
            var users = _context.Users.Where(ur => ur.RoleId == 2).Where(us=>us.UserStatus == UserStatus.active);
            return Ok(users);
        }
        [HttpGet]
        public IActionResult GetOutletDispatchers()
        {
            var users = _context.Users.Where(ur => ur.RoleId == 2).Where(us => us.UserStatus == UserStatus.outlet);
            return Ok(users);
        }
        [HttpGet]
        public IActionResult GetOnSickLeaveDispatchers()
        {
            var users = _context.Users.Where(ur => ur.RoleId == 2).Where(us => us.UserStatus == UserStatus.onSickLeave);
            return Ok(users);
        }
        [HttpGet]
        public IActionResult GetOnHolidayDispatchers()
        {
            var users = _context.Users.Where(ur => ur.RoleId == 2).Where(us => us.UserStatus == UserStatus.onHoliday);
            return Ok(users);
        }
        [HttpGet]
        public IActionResult GetFiredDispatchers()
        {
            var users = _context.Users.Where(ur => ur.RoleId == 2).Where(us => us.UserStatus == UserStatus.fired);
            return Ok(users);
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
        public async Task<ActionResult> PostUser(PostUsersModel model)
        {
            var user = new User()
            {
                FirstName = model.FirstName,
                SecondName = model.SecondName,
                ThirdName = model.ThirdName,
                RoleId = model.RoleId,
                StartWorkDate = model.StartWorkDate,
                CountryId = model.CountryId,
                MainLanguage = model.MainLanguage,
                AnotherLanguage = model.AnotherLanguage,
                Login = model.Login,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                Timezone = model.Timezone,
                PhoneSIPNumber = model.PhoneSIPNumber,
                NumberOfProcessedApplications = 0


            };
                _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok();
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
