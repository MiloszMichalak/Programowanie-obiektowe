using _3._03_zdarzenia.Enum;
using _3._03_zdarzenia.Models;

namespace _3._03_zdarzenia.Services;

// ROLE BASED ACCESS CONTROL
public class RBAC
{
    private readonly Dictionary<Role, List<Permission>> _permissions = new()
    {
        { Role.Admin, [Permission.Read, Permission.Write, Permission.Delete, Permission.ManageUsers] },
        { Role.Manager, [Permission.Read, Permission.Write] },
        { Role.User, [Permission.Read] }
    };

    public bool HasPermission(User user, Permission permission)
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