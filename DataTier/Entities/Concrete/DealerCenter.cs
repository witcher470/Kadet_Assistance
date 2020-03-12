using DataTier.Entities.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class DealerCenter
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите название дилерского центра ")]
        public string Name { get; set; }
        public HasFillial HasFillial { get; set; }
        [Required(ErrorMessage = "Укажите страну, в которой расположен дилерский центр")]
        public Country Country { get; set; }
        [Required(ErrorMessage = "Укажите город, в котором расположен дилерский центр")]
        public string City { get; set; }
        [Required(ErrorMessage = "Укажите улицу, на которой расположен дилерский центр")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Укажите номер дома, в котором расположен дилерский центр")]
        public string HomeNumber { get; set; }
        [Required(ErrorMessage = "Укажите марки машин, которые продаёт дилерский центр")]
        public CarBrand CarBrand { get; set; }
        public DealerCenterStatus DealerCenterStatus { get; set; }
        public string Website { get; set; }
        [Required(ErrorMessage = "Укажите номер телефона дилерского центра")]
        public string ReceptionPhoneNumber { get; set; }
        public DateTime WorkingHours { get; set; }
        public string BillingInformation { get; set; }
        [Required(ErrorMessage = "Укажите юридическое лицо ")]
        public LegalPerson LegalPerson { get; set; }
        public DateTime DateTimeOfContract { get; set; }
        public SettlementPeriod SettlementPeriod { get; set; }
        public SettlementType SettlementType { get; set; }
        [Required(ErrorMessage = "Укажите CommercialResponsiblePerson ")]
        public CommercialResponsiblePerson CommercialResponsiblePerson { get; set; }
        [Required(ErrorMessage = "Укажите AccountingResponsiblePerson ")]
        public AccountingResponsiblePerson AccountingResponsiblePerson { get; set; }
        public string TechnicalAssistanceCardSeries  { get; set; }
        public string TypesAndFillingOfServicePackages { get; set; }
        public string MaterialsLink { get; set; }
        public string AnotherProducts { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string CooperatorName { get; set; }
        public string CooperatorPhoneNumber { get; set; }
        public ICollection<ServiceStation> ServiceStations { get; set; }
        public ICollection<Fillial> Fillials { get; set; }
        public ICollection<HasFillial> HasFillials { get; set; }
        public ICollection<SettlementPeriod> SettlementPeriods { get; set; }
        public ICollection<SettlementType> SettlementTypes { get; set; }
        public ICollection<Country> Countries { get; set; }
        public ICollection<CarBrand> CarBrands { get; set; }
        public ICollection<CommercialResponsiblePerson> CommercialResponsiblePersons { get; set; }
        public ICollection<AccountingResponsiblePerson> AccountingResponsiblePersons { get; set;}
        public ICollection<LegalPerson> LegalPersons { get; set; }



        public DealerCenter()
        {
            Fillials = new List<Fillial>();
            ServiceStations = new List<ServiceStation>();
            HasFillials = new List<HasFillial>();
            SettlementPeriods = new List<SettlementPeriod>();
            SettlementTypes = new List<SettlementType>();
            Countries = new List<Country>();
            CarBrands = new List<CarBrand>();
            CommercialResponsiblePersons = new List<CommercialResponsiblePerson>();
            AccountingResponsiblePersons = new List<AccountingResponsiblePerson>();
            LegalPersons = new List<LegalPerson>();
        }


    }
}
