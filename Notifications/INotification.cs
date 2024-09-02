using System;
namespace Notifications
{
	public interface INotification
	{
		void Send(string message); 
	}
}

