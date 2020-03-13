using DataTier.Entities.Concrete.Statuses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class ServiceStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public ServiceStationStatus ServiceStationStatus { get; set; }
        public ICollection<DealerCenter> DealerCenters { get; set; }
        public ServiceStation()
        {
            DealerCenters = new List<DealerCenter>();
        }
    }
}
