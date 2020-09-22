using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Microsoft.UI.Notifications
{
    public sealed class NotificationBuilder
    {
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
    }
}
