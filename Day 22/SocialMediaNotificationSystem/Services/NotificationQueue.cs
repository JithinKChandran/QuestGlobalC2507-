using SocialMediaNotificationSystem.Models;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace SocialMediaNotificationSystem.Services
{
    internal class NotificationQueue
    {
        private readonly ConcurrentQueue<INotification> _notifications; 
        private readonly int _interval;
        private readonly Timer _timer; 
        public NotificationQueue(int intervalInMilliseconds) 
        { _notifications = new ConcurrentQueue<INotification>(); 
            _interval = intervalInMilliseconds; 
            _timer = new Timer(SendNotifications, null, 0, _interval); 
        }
        public void EnqueueNotification(INotification notification) 
        { 
            _notifications.Enqueue(notification);
        }
        private void SendNotifications(object state) 
        {
            while (_notifications.TryDequeue(out var notification)) 
            {
                Task.Run(() => notification.SendNotification()); 
            }
        }
    }
}
