using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTier.Entities.Abstract;
using DataTier.Entities.Concrete.Statuses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceStationController : ControllerBase
    {
        private readonly EFDbContext _context;
        public ServiceStationController(EFDbContext context)
        {
            _context = context;
        }

       [HttpGet]
        public IActionResult GetActiveFillials()
        {
            var serviceStations = _context.ServiceStations.Where(sts => sts.ServiceStationStatus == ServiceStationStatus.active)

                  .Select(st => new
                  {
                      serviceStationId = st.Id,
                      serviceStationName=st.Name,
                      serviceStationCountry=st.Country,
                      serviceStationCity = st.City,
                      serviceStationStreet=st.Street,
                      serviceStationHomeNumber=st.HomeNumber,
                      serviceStationStatus = st.ServiceStationStatus
                  });
            return Ok(serviceStations);

        }
    }
}