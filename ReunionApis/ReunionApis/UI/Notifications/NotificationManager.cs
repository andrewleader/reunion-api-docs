using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Microsoft.UI.Notifications
{
    public sealed class NotificationManager
    {
        /// <summary>
        /// Clear all notifications. Note that if you're using collections, this only clears your main notifications, and not any collection notifications.
        /// </summary>
        public static void Clear()
        {

        }

        /// <summary>
        /// Clears all notifications within the specified collection.
        /// </summary>
        /// <param name="collectionId"></param>
        [DefaultOverload]
        public static void Clear(string collectionId)
        {

        }

        /// <summary>
        /// Clears all notifications for the specified user.
        /// </summary>
        /// <param name="user"></param>
        public static void Clear(User user)
        {

        }

        /// <summary>
        /// Clears all notifications for the specified user within the specified collection.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="collectionId"></param>
        public static void Clear(User user, string collectionId)
        {

        }

        public static void RemoveByTag(string tag)
        {

        }

        [DefaultOverload]
        public static void RemoveByTag(string tag, string collectionId)
        {

        }

        public static void RemoveByTag(string tag, User user)
        {

        }

        public static void RemoveByTag(string tag, string collectionId, User user)
        {

        }

        public static void RemoveByTagAndGroup(string tag, string group)
        {

        }

        [DefaultOverload]
        public static void RemoveByTagAndGroup(string tag, string group, string collectionId)
        {

        }

        public static void RemoveByTagAndGroup(string tag, string group, User user)
        {

        }

        public static void RemoveByTagAndGroup(string tag, string group, string collectionId, User user)
        {

        }

        public static void RemoveGroup(string group)
        {

        }

        [DefaultOverload]
        public static void RemoveGroup(string group, string collectionId)
        {

        }

        public static void RemoveGroup(string group, User user)
        {

        }

        public static void RemoveGroup(string group, string collectionId, User user)
        {
        }

        /// <summary>
        /// Gets all current notifications that are still visible to the user.
        /// </summary>
        /// <returns></returns>
        public static IAsyncOperation<IReadOnlyList<Notification>> GetNotificationsAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all current notifications for the specified collection that are still visible to the user.
        /// </summary>
        /// <param name="collectionId"></param>
        /// <returns></returns>
        [DefaultOverload]
        public static IAsyncOperation<IReadOnlyList<Notification>> GetNotificationsAsync(string collectionId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all current notifications for the specified user that are still visible to the user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static IAsyncOperation<IReadOnlyList<Notification>> GetNotificationsAsync(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all current notifications for the specified collection and user that are still visible to the user.
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static IAsyncOperation<IReadOnlyList<Notification>> GetNotificationsAsync(string collectionId, User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the collections manager.
        /// </summary>
        public static NotificationCollectionManager Collections { get; }
    }
}
