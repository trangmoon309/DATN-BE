using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Datn.ApiManagement.Entities
{
    public class UserFavoriteVehicle : FullAuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }

        public Guid VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
