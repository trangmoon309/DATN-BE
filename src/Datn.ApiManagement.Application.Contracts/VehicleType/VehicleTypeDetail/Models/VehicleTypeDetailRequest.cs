using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class VehicleTypeDetailRequest
    {
        public string Name { get; set; }
    }
    public class UpdateVehicleTypeDetailRequest
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }
    }

}
