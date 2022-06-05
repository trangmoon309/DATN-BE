using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using static Datn.ApiManagement.Enums.Enums;

namespace Datn.ApiManagement.Models
{
    public class UserTransactionResponse : FullAuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }

        public UserResponse User { get; set; }

        public string Code { get; set; }

        public DateTime ReceivedVehicleDate { get; set; }

        public DateTime ReturnedVehicleDate { get; set; }

        public double TotalCost { get; set; }

        public double DepositCosted { get; set; }

        public string CancelReason { get; set; }

        public int ReviewServiceQuality { get; set; }

        public CostStatus CostStatus { get; set; }

        public RentalStatus RentalStatus { get; set; }

        public List<UserTransactionVehicleResponse> UserTransactionVehicles { get; set; }
    }
}
