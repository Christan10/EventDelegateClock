using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class Clock
    {
        public delegate void SecondChangedHandler(object clock, TimeInfoEventArgs e);

        public event SecondChangedHandler SecondChanged;

        public void Run()
        {
            for (;;)
            {
                Thread.Sleep(1000);
                DateTime now = DateTime.Now;
                TimeInfoEventArgs timeInfoEventArgs = new TimeInfoEventArgs(now.Hour, now.Minute, now.Second);
                
                Console.WriteLine($"{now.Hour}:{now.Minute}:{now.Second}");

                SecondChanged?.Invoke(this, timeInfoEventArgs);
            }
        }
    }
}