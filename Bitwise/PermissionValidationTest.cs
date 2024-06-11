using Bitwise.PermissionValidation;

namespace Bitwise;

public static class PermissionValidationTest
{
    public static void Run()
    {
        var userPermissions = new UserPermissions
        {
            Identity = "refacore",
            Resource = "lecture",
            Permissions = Permissions.Read | Permissions.Write
        };

        foreach (var permission in Enum.GetValues<Permissions>())
        {
            if ((userPermissions.Permissions & permission) == permission)
            {
                Console.WriteLine($"user can {permission}");
            }
        }
    }
}
