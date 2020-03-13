using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class CarBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Fillial> Fillials { get; set; }
        public ICollection<DealerCenter> DealerCenters { get; set; }
        public ICollection<ClientInfo> ClientInfos { get; set; }
        public CarBrand()
        {
            Fillials = new List<Fillial>();
            DealerCenters = new List<DealerCenter>();
            ClientInfos = new List<ClientInfo>();
        }
    }
}
