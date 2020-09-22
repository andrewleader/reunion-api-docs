using Microsoft.UI.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

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
            NotificationManager.Clear(user);

            // Clear notifications for a user and collection
            NotificationManager.Clear(user, "collectionId");
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

        public async void GetNotifications()
        {
            // Get current notifications
            var notifs = await NotificationManager.GetNotificationsAsync();

            // Get current notifications for a collection
            notifs = await NotificationManager.GetNotificationsAsync("collectionId");

            // Get current notifications for a user
            notifs = await NotificationManager.GetNotificationsAsync(user);

            // Get current notifications for a collection and user
            notifs = await NotificationManager.GetNotificationsAsync("collectionId", user);

            var notif = notifs.First();
        }

        public void InteropWithPlatformOrOldSdks()
        {
            Windows.Data.Xml.Dom.XmlDocument platformXml = LegacyGenerateXml();
            Windows.UI.Notifications.ToastNotification toast = LegacyGenerateToast();

            // Can show a toast using legacy XML
            new NotificationBuilder()
                .InitializeFromXml(platformXml)
                .Show();

            // Can show a toast using legacy toast notification
            new NotificationBuilder()
                .InitializeFromToastNotification(toast)
                .Show();

            // Can construct a notification using new APIs and obtain legacy XML to send using legacy APIs
            SendLegacyXml(new NotificationBuilder()
                .AddText("Hello world")
                .BuildXml());

            // Can construct a notification using new APIs and obtain legacy toast to send using legacy APIs
            SendLegacyToast(new NotificationBuilder()
                .AddText("Hello world")
                .BuildToastNotification());
        }

        private Windows.Data.Xml.Dom.XmlDocument LegacyGenerateXml()
        {
            throw new NotImplementedException();
        }

        private Windows.UI.Notifications.ToastNotification LegacyGenerateToast()
        {
            throw new NotImplementedException();
        }

        private void SendLegacyXml(Windows.Data.Xml.Dom.XmlDocument doc)
        {
            SendLegacyToast(new Windows.UI.Notifications.ToastNotification(doc));
        }

        private void SendLegacyToast(Windows.UI.Notifications.ToastNotification notif)
        {
            Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier().Show(notif);
        }

        public async void CreateNotificationCollection()
        {
            var collection = new NotificationCollection(
                "collectionId",
                "My collection",
                "myArgs",
                new Uri("ms-appx://Assets/CollectionIcon.png"));

            await NotificationManager.Collections.SaveAsync(collection);

            // MUA API
            await NotificationManager.Collections.SaveAsync(collection, user);
        }

        public async void ManageNotificationCollections()
        {
            // Get all collections
            IReadOnlyList<NotificationCollection> collections = await NotificationManager.Collections.GetAsync();

            // Get a specific collection
            NotificationCollection collection = await NotificationManager.Collections.GetAsync("collectionId");

            // Remove a collection
            await NotificationManager.Collections.RemoveAsync("collectionId");

            // Remove all collections
            await NotificationManager.Collections.RemoveAllAsync();

            // MUA APIs
            collections = await NotificationManager.Collections.GetAsync(user);
            collection = await NotificationManager.Collections.GetAsync("collectionId", user);
            await NotificationManager.Collections.RemoveAsync("collectionId", user);
            await NotificationManager.Collections.RemoveAllAsync(user);
        }
    }
}
