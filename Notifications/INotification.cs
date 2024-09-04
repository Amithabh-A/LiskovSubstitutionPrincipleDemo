/******************************************************************************
* Filename    = INotification.cs
*
* Author      = Amithabh A
*
* Product     = Notifications
* 
* Project     = Notifications
*
* Description = Interface for Email and SMS Notifications
*****************************************************************************/

using System;
namespace Notifications
{

	public interface INotification
	{
        /// <summary>
        /// Returns message status. If status is true, message has written on terminal, and vice versa. 
        /// </summary>
        /// <param name="message"> message to be passed(printed on the console) </param>
        /// <returns> message status </returns>
        bool Send(string message); 
	}
}

