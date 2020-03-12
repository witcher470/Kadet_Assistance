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
    public class FillialController : ControllerBase
    {
        private readonly EFDbContext _context;
        public FillialController(EFDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetActiveFillials()
        {
            var fillials = _context.Fillials.Where(fs => fs.FillialStatus == FillialStatus.active)

                  .Select(fl => new
                  {
                    fillialId = fl.Id,
                    fillialName = fl.Name,
                    location  =fl.Location,
                    dealerCenter = fl.DealerCenter,
                    carBrands = fl.CarBrands,
                    fillialStatus = fl.FillialStatus
                  });
            return Ok(fillials);

        }
    }
}