using Microsoft.UI.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Notifications;

namespace Samples
{
    public class NotificationSamples
    {
        private User user;

        public void ShowNotification()
        {
            // Show a notification
            new NotificationBuilder()
                .AddText("Hello world")
                .Show();

            // Show a notification in a collection
            new NotificationBuilder()
                .AddText("Hello world")
                .Show("collectionId");

            // Show a notification to a user
            new NotificationBuilder()
                .AddText("Hello world")
                .Show(user);

            // Show a notification to a user in a collection
            new NotificationBuilder()
                .AddText("Hello world")
                .Show("collectionId", user);
        }

        public void ScheduleNotification(DateTime deliveryTime)
        {
            // Schedule a notification
            new NotificationBuilder()
                .AddText("Hello world")
                .Schedule(deliveryTime);

            // Schedule a notification for a collection
            new NotificationBuilder()
                .AddText("Hello world")
                .Schedule(deliveryTime, "collectionId");

            // Schedule a notification for a user
            new NotificationBuilder()
                .AddText("Hello world")
                .Schedule(deliveryTime, user);

            // Schedule a notification for a user and collection
            new NotificationBuilder()
                .AddText("Hello world")
                .Schedule(deliveryTime, "collectionId", user);
        }

        public void ClearNotifications()
        {
            // Clear notifications
            NotificationManager.Clear();

            // Clear notifications from a collection
            NotificationManager.Clear("collectionId");

            // Clear notifications for a user
            NotificationManager.ClearForUser(user);

            // Clear notifications for a user and collection
            NotificationManager.ClearForUser(user, "collectionId");
        }

        public void RemoveNotificationByTag()
        {
            // Remove by tag
            NotificationManager.RemoveByTag("tag");
            NotificationManager.RemoveByTag("tag", "collectionId");
            NotificationManager.RemoveByTag("tag", user);
            NotificationManager.RemoveByTag("tag", "collectionId", user);

            // Remove by tag and group
            NotificationManager.RemoveByTagAndGroup("tag", "group");
            NotificationManager.RemoveByTagAndGroup("tag", "group", "collectionId");
            NotificationManager.RemoveByTagAndGroup("tag", "group", user);
            NotificationManager.RemoveByTagAndGroup("tag", "group", "collectionId", user);

            // Remove group
            NotificationManager.RemoveGroup("group");
            NotificationManager.RemoveGroup("group", "collectionId");
            NotificationManager.RemoveGroup("group", user);
            NotificationManager.RemoveGroup("group", "collectionId", user);
        }
    }
}
