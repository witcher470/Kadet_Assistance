using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class HasFillial
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public ICollection<DealerCenter> DealerCenters { get; set; }
        public HasFillial()
        {
            DealerCenters = new List<DealerCenter>();
        }
    }
}
