using Notifications; 
namespace EmailNotification;

public class EmailNotification : INotification
{
    string _emailId; 

    public EmailNotification(string emailid)
    {
        _emailId = emailid; 
    }

    public void Send(string message)
    {
        Console.WriteLine($"Email from {_emailId} : {message}"); 
    }
}

