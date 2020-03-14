using DataTier.Entities.Concrete;
using DataTier.Entities.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Abstract
{
    public interface IEFDbContextRepository
    {
        IEnumerable<Card> Cards { get; }
        IEnumerable<Contractor> Contractors { get; }
        IEnumerable<DealerCenter> DealerCenters { get; }
        IEnumerable<Fillial> Fillials { get; }
        IEnumerable<Order> Orders { get; }
        IEnumerable<ServiceStation> ServiceStations { get; }
        IEnumerable<User> Users { get; }
        IEnumerable<PaymentMethod> PaymentMethods { get; }
        IEnumerable<Role> Roles { get; }
        IEnumerable<Service> Services { get; }
        IEnumerable<SettlementPeriod> SettlementPeriods { get; }
        IEnumerable<SettlementType> SettlementTypes { get; }
        IEnumerable<ClientInfo> ClientInfos { get; }
        IEnumerable<Country> Countries { get; }
        IEnumerable<CarBrand> CarBrands { get; }
        IEnumerable<CommercialResponsiblePerson> CommercialResponsiblePersons { get; }
        IEnumerable<AccountingResponsiblePerson> AccountingResponsiblePersons { get; }
        IEnumerable<LegalPerson> LegalPersons { get; }
    }
}
