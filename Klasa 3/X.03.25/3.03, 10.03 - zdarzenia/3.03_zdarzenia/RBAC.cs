namespace _3._03_zdarzenia;

// ROLE BASED ACCESS CONTROL
public class RBAC
{
    private readonly Dictionary<Role, List<string>> _permissions = new()
    {
        { Role.Admin, ["Read", "Write", "Delete"] },
        { Role.Manager, ["Read", "Write"] },
        { Role.User, ["Read"] }
    };

    public bool HasPermission(User user, string permission)
    {
        foreach (var role in user.Roles)
        {
            if (_permissions.ContainsKey(role) && _permissions[role].Contains(permission))
            {
                return true;
            }
        }

        return false;
    }
}