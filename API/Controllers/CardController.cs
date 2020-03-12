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
    public class CardController : ControllerBase
    {
        private readonly EFDbContext _context;

        public CardController(EFDbContext context)
        {
            _context = context;
        }

       [HttpGet]
        public IActionResult GetCards()
        {
            var cards = _context.Cards

                  .Select(cd => new
                  {
                      cardId = cd.Id,
                      cardNumber = cd.CardNumber,
                      cardCost = cd.CardCost,
                      clientInfo = cd.ClientInfos.Select(cl => new
                      {
                          clientFirstName = cl.ClientFristName,
                          clientSecondName = cl.ClientSecondName,
                          clientThirdName = cl.ClientThirdName,
                          clientEmail=cl.Email,
                          clientCarModel=cl.CarBrand,
                          clientStateNumber=cl.StateNumber,
                          clientRegion=cl.Region
                      }),                    
                      duration = cd.Duration,
                      vin = cd.VIN,
                      services = cd.Services,
                      sellerFirstName = cd.SellerFirstName,
                      sellerSecondName = cd.SellerSecondName,
                      sellerThirdName = cd.SellerThirdName,
                      numberOfContractWithKadet = cd.NumberOfContractWithKadet,
                      dateOfContractWithKadet = cd.DateOfContractWithKadet,
                      numberOfContractWithClient = cd.NumberOfContractWithClient,
                      dateOfContractWithClient = cd.DateOfContractWithClient,
                      actionStartDate = cd.ActionStartDate,
                      managerFirstName = cd.ManagerFirstName,
                      managerSecondName = cd.ManagerSecondName,
                      managerThirdName = cd.ManagerThirdName,
                      cardStatus = cd.CardStatus,
                      deactivationDate = cd.DeactivationDate,
                      cardAppeal = cd.CardAppeal,
                      employerFirstName = cd.EmployerFirstName,
                      employerSsecondName = cd.EmployerSecondName,
                      employerThirdName = cd.EmployerThirdName
                  }) ; 
            return Ok(cards);

        }
    }
}
