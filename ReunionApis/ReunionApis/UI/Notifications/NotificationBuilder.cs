using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Microsoft.UI.Notifications
{
    public sealed class NotificationBuilder
    {
        public NotificationBuilder() { }

        public NotificationBuilder AddText(string text)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Shows the notification.
        /// </summary>
        public void Show()
        {

        }

        /// <summary>
        /// Shows the notification within the specified collection.
        /// </summary>
        /// <param name="collectionId"></param>
        public void Show(string collectionId)
        {

        }

        /// <summary>
        /// Shows the notification to the specified user.
        /// </summary>
        /// <param name="user"></param>
        [DefaultOverload]
        public void Show(User user)
        {

        }

        /// <summary>
        /// Shows the notification to the specified user within the specified collection.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="collectionId"></param>
        [DefaultOverload]
        public void Show(string collectionId, User user)
        {

        }

        /// <summary>
        /// Schedules the notification.
        /// </summary>
        public void Schedule(DateTimeOffset deliveryTime)
        {

        }

        /// <summary>
        /// Schedules the notification within the specified collection.
        /// </summary>
        [DefaultOverload]
        public void Schedule(DateTimeOffset deliveryTime, string collectionId)
        {

        }

        /// <summary>
        /// Schedules the notification for the specified user.
        /// </summary>
        public void Schedule(DateTimeOffset deliveryTime, User user)
        {

        }

        /// <summary>
        /// Schedules the notification for the specified user within the specified collection.
        /// </summary>
        public void Schedule(DateTimeOffset deliveryTime, string collectionId, User user)
        {

        }

        /// <summary>
        /// Legacy method for obtaining XML to use with the platform APIs or SDKs that still use the platform APIs.
        /// </summary>
        /// <returns></returns>
        public XmlDocument BuildXml()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Legacy method for obtaining a platform <see cref="Windows.UI.Notifications.ToastNotification"/> to use with the platform APIs or SDKs that still use the platform APIs.
        /// </summary>
        /// <returns></returns>
        public Windows.UI.Notifications.ToastNotification BuildToastNotification()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Legacy method for initializing a builder using the legacy platform <see cref="Windows.Data.Xml.Dom.XmlDocument"/>.
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public NotificationBuilder InitializeFromXml(XmlDocument doc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Legacy method for initializing a builder using the legacy platform <see cref="Windows.UI.Notifications.ToastNotification"/>.
        /// </summary>
        /// <param name="notif"></param>
        /// <returns></returns>
        public NotificationBuilder InitializeFromToastNotification(Windows.UI.Notifications.ToastNotification notif)
        {
            throw new NotImplementedException();
        }
    }
}
