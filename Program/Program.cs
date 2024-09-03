namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


/*

using Notifications;
using EmailNotification;
using SmsNotification; 
using NotificationService;
namespace Program;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("starting main program\n"); 
        INotification _emailInstance = new EmailNotification.EmailNotification("harrypotter@hogwarts.com");
        INotification _smsInstance = new SmsNotification.SmsNotification("+91 9846100100"); 

        NotificationService.NotificationService EmailService = new NotificationService.NotificationService(_emailInstance);
        NotificationService.NotificationService SmsService = new NotificationService.NotificationService(_smsInstance);

        EmailService.Notify("Hello via Email!");
        SmsService.Notify("Hello via Sms!");
    }
}

 */