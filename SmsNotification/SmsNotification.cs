/******************************************************************************
* Filename    = SmsNotification.cs
*
* Author      = Amithabh A
*
* Product     = Notifications
* 
* Project     = SmsNotification
*
* Description = Implements Sms Notifications
*****************************************************************************/

using Notifications;
using System.Text.RegularExpressions; 
namespace SmsNamespace;

public class SmsNotification : INotification
{
    string? _phoneNumber;

    public SmsNotification(string? phoneNumber)
    {
        _phoneNumber = phoneNumber; 
    }

    public bool Send(string message)
    {
        // Avoid invalid phone numbers such as null or empty
        if(string.IsNullOrEmpty(_phoneNumber))
        {
            return false; 
        }

        // matching pattern +{<country-code>}{<SPACE>}{<phone-number>} to _phoneNumber
        // to check its validity
        string pattern = @"^\+?\d{1,4} \d+$";
        Regex regex = new Regex(pattern);

        if(regex.IsMatch(_phoneNumber))
        {
            Console.WriteLine($"Sms sent from {_phoneNumber} : {message}");
            return true; 
        }

        return false; 
    }
}

