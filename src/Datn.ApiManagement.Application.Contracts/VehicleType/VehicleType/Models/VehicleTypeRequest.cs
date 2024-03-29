﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class VehicleTypeRequest
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<VehicleTypeDetailRequest> VehicleTypeDetails { get; set; }
    }

    public class UpdateVehicleTypeRequest
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<UpdateVehicleTypeDetailRequest> VehicleTypeDetails { get; set; }
    }
}
