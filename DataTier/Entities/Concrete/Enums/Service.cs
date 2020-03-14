using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete.Enums
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ServiceStatus ServiceStatus { get; set; }
        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }
        public Service()
        {
            Orders = new List<Order>();
        }
    }
}
