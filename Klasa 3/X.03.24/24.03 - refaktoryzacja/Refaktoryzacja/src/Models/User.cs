using zdarzenia_1.Enums;

namespace zdarzenia_1.Models;

public class User
{
    public User(string username)
    {
        Username = username;
        Roles = new List<Role>();
    }

    public string Username { get; set; }
    public List<Role> Roles { get; set; }

    public void AddRole(Role role)
    {
        if (!Roles.Contains(role)) Roles.Add(role);
    }
}