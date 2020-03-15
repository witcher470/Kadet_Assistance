using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class LegalPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BillingInformation { get; set; }
        public string DirectorOrSignatory { get; set; }
    }
}
