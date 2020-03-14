﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
}
