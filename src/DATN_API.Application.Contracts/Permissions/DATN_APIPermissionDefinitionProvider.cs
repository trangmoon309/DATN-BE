using DATN_API.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DATN_API.Permissions;

public class DATN_APIPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DATN_APIPermissions.GroupName, L("Permission:DATN_API"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DATN_APIResource>(name);
    }
}
