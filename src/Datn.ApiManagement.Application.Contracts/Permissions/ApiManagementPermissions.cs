using Volo.Abp.Reflection;

namespace Datn.ApiManagement.Permissions;

public class ApiManagementPermissions
{
    public const string GroupName = "ApiManagement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ApiManagementPermissions));
    }
}
