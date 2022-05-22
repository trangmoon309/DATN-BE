﻿using Datn.ApiManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Datn.ApiManagement.Repositories
{
    public interface IVehiclePropertyRepository : IRepository<VehicleProperty, Guid>
    {
        IQueryable<VehicleProperty> GetList();
    }
}
