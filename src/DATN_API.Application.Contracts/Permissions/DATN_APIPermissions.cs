using Volo.Abp.Reflection;

namespace DATN_API.Permissions;

public class DATN_APIPermissions
{
    public const string GroupName = "DATN_API";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(DATN_APIPermissions));
    }
}
