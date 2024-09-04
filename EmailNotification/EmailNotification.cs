using Notifications;
using System.Text.RegularExpressions; 
namespace EmailNotification;

public class EmailNotification : INotification
{
    string? _emailId; 

    public EmailNotification(string? emailid)
    {
        _emailId = emailid; 
    }

    public bool Send(string message)
    {

        if(string.IsNullOrEmpty(_emailId))
        {
            return false; 
        }

        // regular expression to validate an email address
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);   
        if(regex.IsMatch(_emailId))
        {
            Console.WriteLine($"Email from {_emailId} : {message}");   
            return true; 
        }
        
        return false; 
    }
}
