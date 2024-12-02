namespace _2._12_Delegaty.classes;

public class SMSNotifier
{
    public void SendSMS(string message)
    {
        Console.WriteLine($"SMS wyslany: {message}");
    }
}