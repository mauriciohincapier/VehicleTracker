using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleTracker.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string VIN { get; set; }
        public double PurchasePrice { get; set; }
        public string Notes { get; set; }
    }
}