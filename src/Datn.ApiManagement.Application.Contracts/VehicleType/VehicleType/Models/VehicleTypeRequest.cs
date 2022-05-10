using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class VehicleTypeRequest
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public List<VehicleTypeDetailRequest> VehicleTypeDetails { get; set; }
    }
}
