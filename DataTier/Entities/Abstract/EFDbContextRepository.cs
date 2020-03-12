using DataTier.Entities.Concrete;
using DataTier.Entities.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Abstract
{
    public class EFDbContextRepository : IEFDbContextRepository
    {
        private EFDbContext _context = new EFDbContext();

        public IEnumerable<User> Users { get { return _context.Users; } }

        public IEnumerable<Card> Cards { get { return _context.Cards; } }

        public IEnumerable<Contractor> Contractors { get { return _context.Contractors; } }

        public IEnumerable<DealerCenter> DealerCenters { get { return _context.DealerCenters; } }

        public IEnumerable<Fillial> Fillials { get { return _context.Fillials; } }
        public IEnumerable<Order> Orders { get { return _context.Orders; } }

        public IEnumerable<ServiceStation> ServiceStations { get { return _context.ServiceStations; } }

        public IEnumerable<HasFillial> HasFillials { get { return _context.HasFillials; } }

        public IEnumerable<PaymentMethod> PaymentMethods { get { return _context.PaymentMethods; } }

        public IEnumerable<Role> Roles { get { return _context.Roles; } }

        public IEnumerable<Service> Services { get { return _context.Services; } }

        public IEnumerable<SettlementPeriod> SettlementPeriods { get { return _context.SettlementPeriods; } }

        public IEnumerable<SettlementType> SettlementTypes { get { return _context.SettlementTypes; } }

        public IEnumerable<ClientInfo> ClientInfos { get { return _context.ClientInfos; } }

        public IEnumerable<Country> Countries { get { return _context.Countries; } }

        public IEnumerable<CarBrand> CarBrands { get { return _context.CarBrands; } }

        public IEnumerable<CommercialResponsiblePerson> CommercialResponsiblePersons { get { return _context.CommercialResponsiblePersons; } }

        public IEnumerable<AccountingResponsiblePerson> AccountingResponsiblePersons { get { return _context.AccountingResponsiblePersons; } }

        public IEnumerable<LegalPerson> LegalPersons { get { return _context.LegalPersons; } }

       
    }
}
