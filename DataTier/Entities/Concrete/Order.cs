﻿using DataTier.Entities.Concrete.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTimeOrdered { get; set; }
        [Required(ErrorMessage = "Введите данные клиента ")]
        public int ClientId { get; set; }
        public ClientInfo ClientInfo { get; set; }
        public string TechnicalAssistanceCardNumber { get; set; }
        public string Location { get; set; }
        public string PointOfDeparture { get; set; }
        public string PointOfDestination { get; set; }
        [Required(ErrorMessage = "Выберите необходимую услугу")]
        public int ServiceId { get; set; }
        public Service Services { get; set; }
        [Required(ErrorMessage = "Укажите цену для клиента")]
        public int ServicesCostForClient { get; set; }
        [Required(ErrorMessage = "Укажите цену для подрядчика")]
        public int ServicesCostForContractor { get; set; }
        [Required(ErrorMessage = "Укажите комиссию компании")]
        public int CompanyComission { get; set; }
        public DateTime ServiceTime { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int ServiceRating { get; set; }
        public string OperatorComment { get; set; }
        public string ClientReview { get; set; }

    }
}
