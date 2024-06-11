namespace Bitwise.PermissionValidation;

public class UserPermissions
{
    public string Identity { get; set; } = string.Empty;

    public string Resource { get; set; } = string.Empty;

    public Permissions Permissions { get; set; }
}
