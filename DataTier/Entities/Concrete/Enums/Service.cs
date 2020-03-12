using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete.Enums
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ServiceStatus ServiceStatus { get; set; }
    }
}
