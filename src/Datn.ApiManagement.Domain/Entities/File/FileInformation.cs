using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;


namespace Datn.ApiManagement.Entities
{
    public class FileInformation : Entity<Guid>
    {
        public string Name { get; set; }

        public string Type { get; set; }
    }
}
