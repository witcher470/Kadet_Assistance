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
                      hasFillial = dc.HasFillial,
                      fillials = dc.Fillials,
                      country = dc.Countries.Select(c=> new
                      {
                          countryName = c.Name
                      }),
                      carBrands = dc.CarBrands,
                      dealerCenterStatus = dc.DealerCenterStatus,
                      website = dc.Website,
                      receptionPhoneNumber = dc.ReceptionPhoneNumber,
                      workingHours = dc.WorkingHours,
                      billingInformation = dc.BillingInformation,
                      legalPersonInfo = dc.LegalPersons.Select(lp=> new
                      {
                          legalPersonName = lp.Name,
                          legalPersonBillingInformation = lp.BillingInformation,
                          legalPersonDirectorOrSignatory = lp.DirectorOrSignatory
                      }),
                      dateTimeOfContract = dc.DateTimeOfContract,
                      settlementPeriod = dc.SettlementPeriod,
                      settlementType = dc.SettlementType,
                      commercialResponsiblePersonInfo = dc.CommercialResponsiblePersons.Select(crp => new 
                      { 
                        commercialResponsiblePersonName = crp.Name,
                        commercialResponsiblePersonPhoneNumber = crp.PhoneNumber,
                        commercialResponsiblePersonEmail=crp.Email
                      }),
                      accountingResponsiblePersonInfo = dc.AccountingResponsiblePersons.Select(arp => new
                      {
                          accountingResponsiblePersonName=arp.Name,
                          accountingResponsiblePersonPhoneNumber = arp.PhoneNumber,
                          accountingResponsiblePersonEmail=arp.Email
                      }),
                      technicalAssistanceCardSeries = dc.TechnicalAssistanceCardSeries,
                      typesAndFillingOfServicePackages = dc.TypesAndFillingOfServicePackages,
                      materialsLink = dc.MaterialsLink,
                      anotherProducts = dc.AnotherProducts,
                      login = dc.Login,
                      password = dc.Password,
                      cooperatorName = dc.CooperatorName,
                      cooperatorPhoneNumber = dc.CooperatorPhoneNumber,
                      serviceStations = dc.ServiceStations
                  });
            return Ok(dealerCenters);

        }
    }
}