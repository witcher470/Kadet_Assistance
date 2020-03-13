﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete.Enums
{
    public class SettlementPeriod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<DealerCenter> DealerCenters { get; set; }
        public SettlementPeriod()
        {
            DealerCenters = new List<DealerCenter>();
        }
    }
}
