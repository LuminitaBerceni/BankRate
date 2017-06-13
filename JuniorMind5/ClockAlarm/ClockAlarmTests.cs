using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockAlarm
{
    [TestClass]
    public class ClockAlarmTests
    {
        [TestMethod]
        public void AlarmTests()
        {
            var AlarmForWeek = new Alarm { hour = 6 , day = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday };
            var AlarmForWeekend = new Alarm { hour = 8 , day = Days.Saturday | Days.Sunday };

            Assert.AreEqual(true, AlarmTrigger(6, Days.Monday, AlarmForWeek));
        }

        [Flags]
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 10,
            Saturday = 20,
            Sunday = 40
        }

        struct Alarm
        {
            public Days day;
            public int hour;
            public Alarm(int hour, Days day)
            {
                this.hour = hour;
                this.day = day;
            }
        }

        bool AlarmTrigger(int hour, Days day, Alarm alarm)
        {
            return ((day & alarm.day) != 0) && ((hour == alarm.hour));
        }
    }
}
