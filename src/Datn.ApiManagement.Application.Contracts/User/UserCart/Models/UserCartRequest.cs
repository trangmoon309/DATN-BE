﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class UserCartRequest
    {
        public Guid UserId { get; set; }

        public Guid VehicleId { get; set; }

        public int Quantity { get; set; }
    }
}
