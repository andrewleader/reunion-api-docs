using Microsoft.UI.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace Samples
{
    public class BadgeSamples
    {
        private User user;

        public void SetAndClearBadges()
        {
            // Set to number or glyph
            BadgeManager.Set(4);
            BadgeManager.Set(BadgeValue.Alarm);

            // Clear
            BadgeManager.Clear();

            // MUA APIs
            BadgeManager.Set(4, user);
            BadgeManager.Set(BadgeValue.Alarm, user);
            BadgeManager.Clear(user);
        }

        public void PeriodicUpdates()
        {
            // Start and stop periodic update
            BadgeManager.StartPeriodicUpdate(new Uri("https://myapp.com/badges"), PeriodicUpdateInterval.Daily);
            BadgeManager.StopPeriodicUpdate();

            // MUA APIs
            BadgeManager.StartPeriodicUpdate(new Uri("https://myapp.com/badges"), PeriodicUpdateInterval.Daily, user);
            BadgeManager.StopPeriodicUpdate(user);
        }
    }
}
