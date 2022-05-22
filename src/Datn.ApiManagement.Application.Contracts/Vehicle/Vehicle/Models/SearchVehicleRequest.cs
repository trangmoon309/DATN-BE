using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class SearchVehicleRequest
    {
        public Guid VehicleTypeId { get; set; }

        public Guid VehicleLineId { get; set; }

        public string KeyWord { get; set; } 
    }
}
