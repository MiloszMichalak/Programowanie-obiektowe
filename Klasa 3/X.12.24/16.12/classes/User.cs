namespace Preferences.classes;

public enum Priorities
{
    Low,
    Medium,
    High
}

public class User
{
    public string Name { get; set; }
    public Priorities Priority { get; set; }
}