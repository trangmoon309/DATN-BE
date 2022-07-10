using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class UserCartRequest
    {
        public Guid UserId { get; set; }

        public Guid VehicleId { get; set; }

        public DateTime RentDate { get; set; }

        public int Quantity { get; set; }
    }

    public class UpdateUserCartRequest
    {
        public Guid? Id { get; set; }

        public Guid UserId { get; set; }

        public Guid VehicleId { get; set; }

        public DateTime RentDate { get; set; }

        public int Quantity { get; set; }

        public bool IsRanOut { get; set; }
    }
}
