using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTier.Entities.Abstract;
using DataTier.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly EFDbContext _context;
        public UserController(EFDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetActiveUsers()
        {
            var users = _context.Users.Where(us => us.UserStatus == UserStatus.active)

                  .Select(ur => new
                  {
                      userId = ur.Id,
                      firstName = ur.FirstName,
                      secondName = ur.SecondName,
                      thirdName = ur.ThirdName,
                      role = ur.Role,
                      startWorkDate = ur.StartWorkDate,
                      country = ur.Country,
                      mainLanguage = ur.MainLanguage,
                      anotherLanguage = ur.AnotherLanguage,
                      login = ur.Login,
                      password = ur.Password,
                      userStatus = ur.UserStatus,
                      phoneNumber = ur.PhoneNumber,
                      email = ur.Email,
                      timeZone=ur.Timezone,
                      phoneSIPNumber = ur.PhoneSIPNumber
                  });
            return Ok(users);

        }
    }
}