using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UI.Notifications
{
    public sealed class NotificationCollection
    {
        /// <summary>
        /// Initializes a new notification collection with all the required properties.
        /// </summary>
        /// <param name="id">The ID for the collection.</param>
        /// <param name="displayName">The display name of the collection.</param>
        /// <param name="launchArgs">The launch args that are passed back to your app when the collection title is clicked.</param>
        /// <param name="iconUri">The icon URI that is displayed for the collection.</param>
        public NotificationCollection(string id, string displayName, string launchArgs, Uri iconUri)
        {

        }

        /// <summary>
        /// Gets the ID of the collection.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets or sets the display name of the collection
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the launch args that are passed back to your app when the collection title is clicked.
        /// </summary>
        public string LaunchArgs { get; set; }

        /// <summary>
        /// Gets or sets the icon URI that is displayed for the collection.
        /// </summary>
        public Uri IconUri { get; set; }
    }
}
