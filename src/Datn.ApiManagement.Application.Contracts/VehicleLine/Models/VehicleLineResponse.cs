﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class VehicleLineResponse : FullAuditedEntityDto<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
