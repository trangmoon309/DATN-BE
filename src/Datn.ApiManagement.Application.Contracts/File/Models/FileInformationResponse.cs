using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class FileInformationResponse : EntityDto<Guid>
    {
        public string Name { get; set; }

        public string Type { get; set; }
    }
}
