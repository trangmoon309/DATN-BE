using Datn.ApiManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Datn.ApiManagement.Permissions;

public class ApiManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ApiManagementPermissions.GroupName, L("Permission:ApiManagement"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ApiManagementResource>(name);
    }
}
