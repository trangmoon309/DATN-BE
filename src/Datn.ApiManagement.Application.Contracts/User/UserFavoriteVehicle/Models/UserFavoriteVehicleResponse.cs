﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class UserFavoriteVehicleResponse : FullAuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }

        public Guid VehicleId { get; set; }

        public VehicleResponse Vehicle { get; set; }
    }
}
