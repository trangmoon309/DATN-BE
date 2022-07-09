using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class VehicleResponse : FullAuditedEntityDto<Guid>
    {
        public Guid VehicleTypeId { get; set; }

        public Guid VehicleLineId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Amount { get; set; }

        public int RemainAmount { get; set; }

        public double KilometerTravel { get; set; }

        public string LicensePlate { get; set; }

        public double RentalPrice { get; set; }

        public double DepositPrice { get; set; }

        public Guid ImageUrl { get; set; }

        public VehicleTypeResponse VehicleType { get; set; }

        public VehicleLineResponse VehicleLine { get; set; }

        public List<VehiclePropertyResponse> VehicleProperties { get; set; }

        public List<VehicleImageResponse> VehicleImages { get; set; }
    }
}
