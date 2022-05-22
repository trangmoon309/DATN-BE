using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class VehicleImageRequest
    {
        public Guid VehicleId { get; set; }

        public Guid FileInformationId { get; set; }
    }
}
