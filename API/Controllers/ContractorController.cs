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
    public class ContractorController : ControllerBase
    {
        private readonly EFDbContext _context;

        public ContractorController(EFDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetActiveContractors()
        {
            var contractors = _context.Contractors.Where(cs => cs.ContractorStatus == ContractorStatus.active)

                  .Select(ct => new
                  {
                      contractorId =ct.Id,
                      firstName= ct.FirstName,
                      secondName = ct.SecondName,
                      thirdName  = ct.ThirdName,
                      phoneNumber = ct.PhoneNumber,
                      login = ct.Login,
                      contractorStatus = ct.ContractorStatus,
                      rating = ct.Rating,
                      services = ct.Services,
                      cities = ct.Cities,
                      priceList= ct.PriceList,
                      paymentMethod = ct.PaymentMethod,
                      anotherPhoneNumber= ct.AnotherPhoneNumber,
                      wotkTime = ct.WorkTime,
                      numberOfTrucks =ct.NumberOfTrucks,
                      carryingCapacityOfTrucks=ct.CarryingCapacityOfTrucks,
                      platformLenght = ct.PlatformLenght,
                      yearOfManufactureOfTrucks = ct.YearOfManufactureOfTrucks,
                      trolleysStatus = ct.TrolleysStatus,
                      craneManipulatorStatus =ct.CraneManipulatorStatus,
                      anotherServices = ct.AnotherServices
                  });
            return Ok(contractors);

        }
    }
}