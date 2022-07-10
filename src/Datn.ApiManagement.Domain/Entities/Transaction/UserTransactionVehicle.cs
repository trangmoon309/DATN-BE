using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Datn.ApiManagement.Entities
{
    public class UserTransactionVehicle : FullAuditedAggregateRoot<Guid>
    {
        public Guid UserTransactionId { get; set; }

        public int Amount { get; set; }

        public Guid VehicleId { get; set; }

        public int ReviewRideQuality { get; set; }

        public int ReviewEngineQuality { get; set; }

        public string ReviewNote { get; set; }

        public Vehicle Vehicle { get; set; }

        public UserTransaction UserTransaction { get; set; }
    }

    public class UserTransactionVehicleGroupByVehicle
    {
        public Guid VehicleId { get; set; }

        public List<UserTransactionVehicle> UserTransactionVehicles { get; set; } = new List<UserTransactionVehicle>();

        public bool IsVehicleRanOutOfAmount { get;set; }

        public int UsingAmount { get; set; }
    }
}
