using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete
{
   public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Contractor> Contractors { get; set; }
        public PaymentMethod()
        {
            Orders = new List<Order>();
            Contractors = new List<Contractor>();
        }
    }
}
