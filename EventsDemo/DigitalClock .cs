using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class DigitalClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += NewTime;
        }

        public void NewTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Current time: {e.Hour.ToString()} {e.Minute.ToString()} {e.Second.ToString()}");
        }
    }

    class Log
    {
        public void Subscribe(Clock clock)
        {
            clock.SecondChanged += LogTime;
        }

        public void LogTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Logging {e.Hour.ToString()} {e.Minute.ToString()} {e.Second.ToString()}");
        }
    }
}
