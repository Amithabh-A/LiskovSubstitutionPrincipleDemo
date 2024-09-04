/******************************************************************************
* Filename    = EmailNotificationTests.cs
*
* Author      = Amithabh A
*
* Product     = Notifications
* 
* Project     = EmailNotificationTests
*
* Description = Tests Email Notifications
*****************************************************************************/

using EmailNotification;
using System.Net.Mail; 
namespace EmailNotificationTests;

[TestClass]
public class EmailNotificationTests
{
    [TestMethod]
    public void TestValidEmail()
    {

        string[] emails = { "johndoe@gmail.com", "blah@example.com", "a@b.c", "sth.soth@dom.com", "A@B.C"};

        foreach(string email in emails)
        {
            EmailNotification.EmailNotification notification = new EmailNotification.EmailNotification(email);
            bool result = notification.Send(""); 
            Assert.IsTrue(result, $"Expected for {email} : true, Actual : {result}"); 
        }
    }

    [TestMethod]
    public void TestInvalidEmail()
    {

        string[] emails = {"hello", "a@b@c", "a.b.c", "a.b@c"};

        foreach (string email in emails)
        {
            EmailNotification.EmailNotification notification = new EmailNotification.EmailNotification(email);
            bool result = notification.Send("");
            Assert.IsFalse(result, $"Expected for {email} : false, Actual : {result}");
        }
    }

    [TestMethod]
    public void DirectCallWithNullOrEmpty()
    {

        string?[] emails = { string.Empty, null, "" };

        foreach (string? email in emails)
        {
            EmailNotification.EmailNotification notification = new EmailNotification.EmailNotification(email);
            bool result = notification.Send("");
            Assert.IsFalse(result, $"Expected for {email} : false, Actual : {result}");
        }
    }
}
