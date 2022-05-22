using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using static Datn.ApiManagement.Enums.Enums;

namespace Datn.ApiManagement.Entities
{
    public class UserTransaction : FullAuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }

        public string Code { get; set; }

        public DateTime ReceivedVehicleDate { get; set; }

        public DateTime ReturnedVehicleDate { get; set; }

        public double TotalCost { get; set; }

        public string CancelReason { get; set; }

        public int ReviewServiceQuality { get; set; }

        public CostStatus CostStatus { get; set; }

        public RentalStatus RentalStatus { get; set; }

        public List<UserTransactionVehicle>  UserTransactionVehicles { get; set; }
    }
}
