﻿using DataTier.Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xunit;
using Xunit.Sdk;
namespace DataTier.Entities.Concrete
{
    public class PostUsersModel
    {
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Введите фамилию")]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "Введите отчество")]
        public string ThirdName { get; set; }
        public int RoleId { get; set; }
        public DateTime StartWorkDate { get; set; }
        public int CountryId { get; set; }
        public string MainLanguage { get; set; }
        [Required(ErrorMessage = "Укажите дополнительный язык ")]
        public string AnotherLanguage { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "Введите номер телефона")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Введите Email")]
        public string Email { get; set; }
        public string Timezone { get; set; }
        [Required(ErrorMessage = "Введите SIP номер")]
        public string PhoneSIPNumber { get; set; }
    }
}
