using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace DataTier.Entities.Concrete
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Введите фамилию")]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "Введите отчество")]
        public string ThirdName { get; set; }
        [Required(ErrorMessage = "Выберите роль")]
        public Role Role { get; set; }
        public DateTime StartWorkDate { get; set; }
        [Required(ErrorMessage = "Укажите страну")]
        public Country Country { get; set; }
        [Required(ErrorMessage = "Укажите основной язык")]
        public string MainLanguage { get; set; }
        [Required(ErrorMessage = "Укажите дополнительный язык ")]
        public string AnotherLanguage { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserStatus UserStatus { get; set; }
        [Required(ErrorMessage = "Введите номер телефона")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Введите Email")]
        public string Email { get; set; }
        public string Timezone { get; set; }
        [Required(ErrorMessage = "Введите SIP номер")]
        public string PhoneSIPNumber { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<Country> Countries { get; set; }

        public User()
        {
            Roles = new List<Role>();
            Countries = new List<Country>();
        }


    }
}
