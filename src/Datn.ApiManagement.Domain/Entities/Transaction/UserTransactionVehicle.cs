﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Datn.ApiManagement.Entities
{
    public class UserTransactionVehicle : FullAuditedAggregateRoot<Guid>
    {
        public Guid UserTransactionId { get; set; }

        public Guid VehicleId { get; set; }

        public int ReviewRideQuality { get; set; }

        public int ReviewEngineQuality { get; set; }

        public string ReviewNote { get; set; }

        public Vehicle Vehicle { get; set; }

        public UserTransaction UserTransaction { get; set; }
    }
}
