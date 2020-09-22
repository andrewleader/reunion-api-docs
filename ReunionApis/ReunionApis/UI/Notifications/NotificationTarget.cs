using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace Microsoft.UI.Notifications
{
    public sealed class NotificationTarget
    {
        public static NotificationTarget Get(string collectionId)
        {
            throw new NotImplementedException();
        }

        public static NotificationTarget GetForUser(User user)
        {
            throw new NotImplementedException();
        }


        public static NotificationTarget GetForUser(User user, string collectionId)
        {
            throw new NotImplementedException();
        }
    }
}
