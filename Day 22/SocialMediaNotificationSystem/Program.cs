using SocialMediaNotificationSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaNotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notificationQueue = new NotificationQueue(5000); // Set interval to 5 seconds 
            // Simulate receiving notifications
            notificationQueue.EnqueueNotification(new LikeNotification()); 
            notificationQueue.EnqueueNotification(new CommentNotification()); 
            notificationQueue.EnqueueNotification(new FollowNotification()); 
            
            // Keep the console application running
            Console.WriteLine("Notification system running. Press Enter to exit."); 
            Console.ReadLine();
        }
    }
}
