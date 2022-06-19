using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.MockDatas
{
    public static class VehicleMock
    {
        public static List<VehicleTypeRequest> VehicleType()
        {
            return new List<VehicleTypeRequest>()
            {
                new VehicleTypeRequest()
                {
                    Name = "Motor Cross"
                },
                new VehicleTypeRequest()
                {
                    Name = "Motor Scooter"
                },
                new VehicleTypeRequest()
                {
                    Name = "Motor Street"
                },
                new VehicleTypeRequest()
                {
                    Name = "Motor Sprot"
                },
                new VehicleTypeRequest()
                {
                    Name = "Motor Cruiser"
                },
                new VehicleTypeRequest()
                {
                    Name = "Micro"
                },
                new VehicleTypeRequest()
                {
                    Name = "Sedan"
                },
                new VehicleTypeRequest()
                {
                    Name = "CUV"
                },
                new VehicleTypeRequest()
                {
                    Name = "SUV"
                },
                new VehicleTypeRequest()
                {
                    Name = "Carbiolet"
                },
                new VehicleTypeRequest()
                {
                    Name = "Couple"
                },
                new VehicleTypeRequest()
                {
                    Name = "Roadster"
                },
                new VehicleTypeRequest()
                {
                    Name = "Pick-up Truck"
                },
                new VehicleTypeRequest()
                {
                    Name = "Van"
                },
                new VehicleTypeRequest()
                {
                    Name = "Limousine"
                },
            };
        }
    }
}
