using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class UserTransactionVehicleResponse : FullAuditedEntityDto<Guid>
    {
        public Guid UserTransactionId { get; set; }

        public Guid VehicleId { get; set; }

        public int Amount { get; set; }

        public int ReviewRideQuality { get; set; }

        public int ReviewEngineQuality { get; set; }

        public string ReviewNote { get; set; }

        public UserResponse User { get; set; }

        public VehicleResponse Vehicle { get; set; }
    }
}
