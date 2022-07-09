using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class SearchUserTransactionVehicleRequest
    {
        public Guid? UserId { get; set; }

        public DateTime? SearchDate { get; set; }

        public string KeyWord { get; set; }
    }
}
