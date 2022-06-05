using System;
using System.Collections.Generic;
using System.Text;
using static Datn.ApiManagement.Enums.Enums;

namespace Datn.ApiManagement.Models
{
    public class UserTransactionRequest
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

        public List<UserTransactionVehicleRequest> UserTransactionVehicles { get; set; }
    }
}
