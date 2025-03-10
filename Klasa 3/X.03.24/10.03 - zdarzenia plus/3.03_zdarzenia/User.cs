namespace _3._03_zdarzenia;

// public User(string username)
// {
//     Username = username;
//     Roles = new List<Role>();
// }

public class User(string username)
{
    public string Username { get; set; } = username;
    public List<Role> Roles { get; set; } = new();

    public void AddRole(Role role)
    {
        if (!Roles.Contains(role))
        {
            Roles.Add(role);
        }
    }
}