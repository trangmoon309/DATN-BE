using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class UserFavoriteVehicleRequest
    {
        public Guid UserId { get; set; }

        public Guid VehicleId { get; set; }
    }
}
