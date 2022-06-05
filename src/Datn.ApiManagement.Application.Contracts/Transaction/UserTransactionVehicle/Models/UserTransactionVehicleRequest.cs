using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class UserTransactionVehicleRequest
    {
        public Guid VehicleId { get; set; }

        public int ReviewRideQuality { get; set; }

        public int ReviewEngineQuality { get; set; }

        public string ReviewNote { get; set; }
    }
}
