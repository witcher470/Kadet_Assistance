using DataTier.Entities.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xunit.Sdk;

namespace DataTier.Entities.Concrete
{
    public class Card
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите номер карты")]
        [RegularExpression(@"/[^a-zA-Z0-9\-\_]{4,16}/$", ErrorMessage = "Некорректный номер телефона")]
        public int CardNumber { get; set; }
        [Required(ErrorMessage = "Введите стоимость карты")]
        public int CardCost { get; set; }
        public int ClientId { get; set; }
        public ClientInfo ClientInfo { get; set; }
        [Required(ErrorMessage = "Укажите срок действия карты ")]
        public DateTime Duration { get; set; }
        [Required(ErrorMessage = "Введите VIN ")]
        public int VIN { get; set; }        
        public string Color { get; set; }
        [Required(ErrorMessage = "Укажите доступные службы")]
        public Service Services { get; set; }
        [Required(ErrorMessage = "Введите имя продавца ")]
        public string SellerFirstName { get; set; }
        [Required(ErrorMessage = "Введите фамилию продавца ")]
        public string SellerSecondName { get; set; }
        [Required(ErrorMessage = "Введите отчество продавца ")]
        public string SellerThirdName { get; set; }
        [Required(ErrorMessage = "Введите номер контракта с Kadet ")]
        public int NumberOfContractWithKadet { get; set; }
        [Required(ErrorMessage = "Введите дату контракта с Kadet  ")]
        public DateTime DateOfContractWithKadet { get; set; }
        [Required(ErrorMessage = "Введите номер контракта с клиентом")]
        public int NumberOfContractWithClient { get; set; }
        [Required(ErrorMessage = "Введите дату контракта с клиентом")]
        public DateTime DateOfContractWithClient { get; set; }
        [Required(ErrorMessage = "Введите дату начала действия карты")]
        public DateTime ActionStartDate { get; set; }
        [Required(ErrorMessage = "Введите имя менеджера, продавшего карту")]
        public string ManagerFirstName { get; set; }
        [Required(ErrorMessage = "Введите фамилию менеджера, продавшего карту")]
        public string ManagerSecondName { get; set; }
        [Required(ErrorMessage = "Введите отчество менеджера, продавшего карту")]
        public string ManagerThirdName { get; set; }
        public CardStatus CardStatus { get; set; }
        [Required(ErrorMessage = "Введите дату деактивации карты ")]
        public DateTime DeactivationDate { get; set; }
        public string CardAppeal { get; set; }
        [Required(ErrorMessage = "Введите имя сотрудника ")]
        public string EmployerFirstName { get; set; }
        [Required(ErrorMessage = "Введите фамилию сотрудника ")]
        public string EmployerSecondName { get; set; }
        [Required(ErrorMessage = "Введите отчество сотрудника ")]
        public string EmployerThirdName { get; set; }
        public Card()
        {
        }
      
    }
}
