using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Datn.ApiManagement.EntityFrameworkCore
{
    public class ApiManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ApiManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {
        }
    }
}