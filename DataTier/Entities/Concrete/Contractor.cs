using DataTier.Entities.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class Contractor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя подрядчика ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Введите фамилию подрядчика ")]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "Введите отчество подрядчика ")]
        public string ThirdName { get; set; }
        [Required(ErrorMessage = "Введите номер телефона подрядчика ")]
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public ContractorStatus ContractorStatus { get; set; }
        public int Rating { get; set; }
        public Service Services { get; set; }
        public string Cities { get; set; }
        [Required(ErrorMessage = "Введите ссылку на прайс лист подрядчика ")]
        public string PriceList { get; set; }
        [Required(ErrorMessage = "Выберите метод оплаты")]
        public PaymentMethod PaymentMethod { get; set; }
        public string AnotherPhoneNumber { get; set; }
        public string WorkTime { get; set; }
        [Required(ErrorMessage = "Введите количество эвакуаторов у подрядчика ")]
        public int NumberOfTrucks { get; set; }
        [Required(ErrorMessage = "Введите грузоподъемность эвакуаторов у подрядчика ")]
        public int CarryingCapacityOfTrucks { get; set; }
        [Required(ErrorMessage = "Введите длину платформы эвакуаторов у подрядчика ")]
        public int PlatformLenght { get; set; }
        public string YearOfManufactureOfTrucks { get; set; }
        [Required(ErrorMessage = "Укажите, есть ли в наличии подкатные тележки ")]
        public TrolleysStatus TrolleysStatus { get; set; }
        [Required(ErrorMessage = "Укажите, есть ли в наличии эвакуаторы с краном-манипулятором")]
        public CraneManipulatorStatus CraneManipulatorStatus { get; set; }
        public Service AnotherServices {get;set;}
        public ICollection<PaymentMethod> PaymentMethods { get; set; }

        public Contractor()
        {
            PaymentMethods = new List<PaymentMethod>();
        }
    }
}
