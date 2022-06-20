using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class VehiclePropertyRequest
    {
        public Guid VehicleTypeDetailId { get; set; }

        public string Description { get; set; }

        public string VehiclePropertyName { get; set; }

        public string Value { get; set; }
    }

    public class UpdateVehiclePropertyRequest
    {
        public Guid? Id { get; set; }

        public Guid VehicleTypeDetailId { get; set; }

        public string Description { get; set; }

        public string Value { get; set; }
    }
}
