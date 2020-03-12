﻿using DataTier.Entities.Concrete.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xunit.Sdk;

namespace DataTier.Entities.Concrete
{
    public class ClientInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя клиента ")]
        public string ClientFristName { get; set; }
        [Required(ErrorMessage = "Введите фамилию клиента ")]
        public string ClientSecondName { get; set; }
        [Required(ErrorMessage = "Введите отчество клиента ")]
        public string ClientThirdName { get; set; }
        [Required(ErrorMessage = "Введите Email клиента ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите номер телефона клиента клиента ")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Введите модель машины клиента ")]
        public CarBrand CarBrand { get; set; }
        [Required(ErrorMessage = "Введите государственный номер автомобиля клиента ")]
        public string StateNumber { get; set; }
        [Required(ErrorMessage = "Введите регион обслуживания клиента ")]
        public string Region { get; set; }
        public ICollection<CarBrand> CarBrands { get; set; }
        public ClientInfo()
        {
            CarBrands = new List<CarBrand>();
        }


    }
}    
