using Notifications; 
namespace SmsNotification;

public class SmsNotification : INotification
{
    string _phoneNumber;

    public SmsNotification(string phoneNumber)
    {
        _phoneNumber = phoneNumber; 
    }

    public void Send(string message)
    {
        Console.WriteLine($"Sms sent from {_phoneNumber} : {message}"); 
    }
}

