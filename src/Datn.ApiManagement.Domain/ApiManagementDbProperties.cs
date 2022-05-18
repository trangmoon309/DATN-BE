namespace Datn.ApiManagement;

public static class ApiManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "ApiManagement";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "ApiManagement";

    public const string IdentityConnectionStringName = "Default";
}
