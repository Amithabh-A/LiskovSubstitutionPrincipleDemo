using System;
namespace Notifications
{
	public interface INotification
	{
		/// <summary>
		/// Send() returns message status. If status is true, message has written on terminal, and vice versa. 
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		bool Send(string message); 
	}
}

