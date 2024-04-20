﻿using System;
using System.Collections.Generic;

namespace MyWpfAppForDb.Models.Database.Entities
{
    public partial class DeliveryPoint
    {
        public DeliveryPoint()
        {
            Employees = new HashSet<Employee>();
            Orders = new HashSet<Order>();
        }

        public int DeliveryPointId { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public decimal? Rating { get; set; }
        public string? Zipcode { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
