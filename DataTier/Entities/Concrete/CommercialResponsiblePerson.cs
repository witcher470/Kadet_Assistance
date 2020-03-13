using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class CommercialResponsiblePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<DealerCenter> DealerCenters { get; set; }
        public CommercialResponsiblePerson()
        {
            DealerCenters = new List<DealerCenter>();
        }
    }
}
