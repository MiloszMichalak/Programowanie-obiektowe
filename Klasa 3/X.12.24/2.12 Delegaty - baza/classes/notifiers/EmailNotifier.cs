namespace _2._12_Delegaty.classes;

public class EmailNotifier
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Email wyslany: {message}");
    }
}