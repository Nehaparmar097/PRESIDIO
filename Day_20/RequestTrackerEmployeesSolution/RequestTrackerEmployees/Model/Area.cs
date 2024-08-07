﻿using System;
using System.Collections.Generic;

namespace RequestTrackerEmployees.Model
{
    public partial class Area
    {
        public Area()
        {
            Employees = new HashSet<Employee>();
        }

        public string Area1 { get; set; } = null!;
        public string? Zipcode { get; set; }
        public string? AreaDescription { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
