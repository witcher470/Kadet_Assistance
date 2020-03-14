using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTier.Entities.Abstract;
using DataTier.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerCenterController : ControllerBase
    {
        private readonly EFDbContext _context;
        public DealerCenterController(EFDbContext context)
        {
            _context = context;
        }

       [HttpGet]
        public IActionResult GetActiveDealerCenters()
        {
            var dealerCenters = _context.DealerCenters.Where(dcs => dcs.DealerCenterStatus == DealerCenterStatus.active)

                  .Select(dc => new
                  {
                      dealerCenterId = dc.Id,
                      name=dc.Name,
                      fillials = dc.Fillial,
                      country = dc.Country,
                      carBrands = dc.CarBrand,
                      dealerCenterStatus = dc.DealerCenterStatus,
                      website = dc.Website,
                      receptionPhoneNumber = dc.ReceptionPhoneNumber,
                      workingHours = dc.WorkingHours,
                      billingInformation = dc.BillingInformation,
                      legalPersonInfo = dc.LegalPerson,
                      dateTimeOfContract = dc.DateTimeOfContract,
                      settlementPeriod = dc.SettlementPeriod,
                      settlementType = dc.SettlementType,
                      commercialResponsiblePersonInfo = dc.CommercialResponsiblePerson,
                      accountingResponsiblePersonInfo = dc.AccountingResponsiblePerson,
                      technicalAssistanceCardSeries = dc.TechnicalAssistanceCardSeries,
                      typesAndFillingOfServicePackages = dc.TypesAndFillingOfServicePackages,
                      materialsLink = dc.MaterialsLink,
                      anotherProducts = dc.AnotherProducts,
                      login = dc.Login,
                      password = dc.Password,
                      cooperatorName = dc.CooperatorName,
                      cooperatorPhoneNumber = dc.CooperatorPhoneNumber,
                      serviceStations = dc.ServiceStation
                  });
            return Ok(dealerCenters);

        }
    }
}