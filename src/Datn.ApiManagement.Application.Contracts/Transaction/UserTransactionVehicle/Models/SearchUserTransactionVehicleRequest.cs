using System;
using System.Collections.Generic;
using System.Text;
using static Datn.ApiManagement.Enums.Enums;

namespace Datn.ApiManagement.Models
{
    public class SearchUserTransactionVehicleRequest
    {
        public Guid? UserId { get; set; }

        public DateTime? ReceiveDate { get; set; }

        public DateTime? RetunrnDate { get; set; }

        public CostStatus? CostStatus { get; set; }

        public RentalStatus? RentalStatus { get; set; }

        public string KeyWord { get; set; }
    }
}
