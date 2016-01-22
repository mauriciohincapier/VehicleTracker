using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleTracker.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public int Mileage { get; set; }
        public string Note { get; set; }
    }
}