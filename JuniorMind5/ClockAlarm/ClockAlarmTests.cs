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

        [TestMethod]
        public void AlarmTestsForWeekend()
        {
            var AlarmForWeek = new Alarm { hour = 6, day = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday };
            var AlarmForWeekend = new Alarm { hour = 8, day = Days.Saturday | Days.Sunday };

            Assert.AreEqual(true, AlarmTrigger(8, Days.Sunday, AlarmForWeekend));
        }

        [Flags]
        enum Days
        {
            Monday = 0x1,
            Tuesday = 0x2,
            Wednesday = 0x4,
            Thursday = 0x8,
            Friday = 0x10,
            Saturday = 0x20,
            Sunday = 0x40
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
