using SmsNamespace; 
namespace SmsNotificationTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestValidPhoneNumber()
    {
        string[] numbers = {"+1 9846100100", "+999 0000000000", "+3 0", "+5555 9"};
        foreach(string number in numbers)
        {
            SmsNotification notification = new SmsNotification(number);
            bool result = notification.Send("Test SMS");
            Assert.IsTrue(result, $"Expected result for number {number} : true, Obtained result : {result}"); 
        }
    }

    [TestMethod]
    public void TestInvalidPhoneNumber()
    {
        string[] numbers = {"+", "+ ", "+ 4321", "+123", "+456 ", " ", "      ",
            "748932", "1", "-", "-7892", "-89 780", "jfi9e32", "+12 jfo020"};
        foreach(string number in numbers)
        {
            SmsNotification notification = new SmsNotification(number);
            bool result = notification.Send("Test SMS");
            Assert.IsFalse(result, $"Expected result for number {number} : false, Obtained result : {result}"); 
        }
    }

    [TestMethod]
    public void DirectCallWithNullOrEmpty()
    {
        string?[] numbers = { String.Empty, null};
        foreach(string? number in numbers)
        {
            SmsNotification notification = new SmsNotification(number);
            bool result = notification.Send("Test SMS");
            Assert.IsFalse(result, $"Expected result for number {number} : false, Obtained result : {result}");
        }
    }
}
