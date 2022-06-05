using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class VehicleRequest
    {
        public Guid VehicleTypeId { get; set; }

        public Guid VehicleLineId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Amount { get; set; }

        public double KilometerTravel { get; set; }

        public string LicensePlate { get; set; }

        public double RentalPrice { get; set; }

        public double DepositPrice { get; set; }

        public List<VehiclePropertyRequest> VehicleProperties { get; set; }
    }

    public class UpdateVehicleRequest
    {
        public Guid VehicleTypeId { get; set; }

        public Guid VehicleLineId { get; set; }

        public string Code { get; set; }

        public string Color { get; set; }

        public int Amount { get; set; }

        public double KilometerTravel { get; set; }

        public string LicensePlate { get; set; }

        public double RentalPrice { get; set; }

        public double DepositPrice { get; set; }

        public List<UpdateVehiclePropertyRequest> VehicleProperties { get; set; }
    }
}
