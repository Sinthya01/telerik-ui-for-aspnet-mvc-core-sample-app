﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikWebApplicationMVC6.Models
{
    public class OrderViewModel
    {
        public int OrderID
        {
            get;
            set;
        }

        public string CustomerID { get; set; }

        public string ContactName
        {
            get;
            set;
        }

        public decimal? Freight
        {
            get;
            set;
        }

        public string ShipAddress
        {
            get;
            set;
        }

        [Required]
        public DateTime? OrderDate
        {
            get;
            set;
        }

        public DateTime? ShippedDate
        {
            get;
            set;
        }

        public string ShipCountry
        {
            get;
            set;
        }

        public string ShipCity
        {
            get;
            set;
        }

        public string ShipName
        {
            get;
            set;
        }

        public int? EmployeeID
        {
            get;
            set;
        }
    }
}
