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
    public sealed class NotificationCollectionManager
    {
        /// <summary>
        /// Gets the current notification collections.
        /// </summary>
        /// <returns></returns>
        public IAsyncOperation<IReadOnlyList<NotificationCollection>> GetAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the current notification collections for the specified user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IAsyncOperation<IReadOnlyList<NotificationCollection>> GetAsync(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a specific collection with the specified collection ID. Returns null if doesn't exist.
        /// </summary>
        /// <param name="collectionId"></param>
        /// <returns></returns>
        [DefaultOverload]
        public IAsyncOperation<NotificationCollection> GetAsync(string collectionId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a specific collection with the specified collection ID for the specified user. Returns null if doesn't exist.
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public IAsyncOperation<NotificationCollection> GetAsync(string collectionId, User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds or updates the specified notification collection.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public IAsyncAction SaveAsync(NotificationCollection collection)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds or updates the specified notification collection for the specified user.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public IAsyncAction SaveAsync(NotificationCollection collection, User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the specified collection if it exists.
        /// </summary>
        /// <param name="collectionId"></param>
        /// <returns></returns>
        public IAsyncAction RemoveAsync(string collectionId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the specified collection for the specified user if it exists.
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public IAsyncAction RemoveAsync(string collectionId, User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes all toast collections.
        /// </summary>
        /// <returns></returns>
        public IAsyncAction RemoveAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes all toast collections for the specified user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IAsyncAction RemoveAllAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
