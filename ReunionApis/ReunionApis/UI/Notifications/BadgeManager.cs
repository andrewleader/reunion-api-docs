using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Microsoft.UI.Notifications
{
    public static class BadgeManager
    {
        [DefaultOverload]
        public static void Set(uint number)
        {

        }

        public static void Set(BadgeValue badgeValue)
        {

        }

        [DefaultOverload]
        public static void Set(uint number, User user)
        {

        }

        public static void Set(BadgeValue badgeValue, User user)
        {

        }

        public static void Clear()
        {

        }

        public static void Clear(User user)
        {

        }

        public static void StartPeriodicUpdate(Uri uri, PeriodicUpdateInterval interval)
        {

        }

        public static void StopPeriodicUpdate()
        {

        }

        public static void StartPeriodicUpdate(Uri uri, PeriodicUpdateInterval interval, User user)
        {

        }

        public static void StopPeriodicUpdate(User user)
        {

        }
    }
}
