using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Datn.ApiManagement.Entities
{
    public class Vehicle : FullAuditedAggregateRoot<Guid>
    {
        public Guid VehicleTypeId { get; set; }

        public Guid VehicleLineId { get; set; }

        public string Code { get; set; }

        public string Color { get; set; }

        public double KilometerTravel { get; set; }

        public string LicensePlate { get; set; }

        public double RentalPrice { get; set; }

        public double DepositPrice { get; set; }

        public VehicleType VehicleType { get; set; }

        public VehicleLine VehicleLine { get; set; }

        public List<VehicleProperty> VehicleProperties { get; set; }    
    }
}
