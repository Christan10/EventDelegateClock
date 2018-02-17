using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Clock clock = new Clock();
            
            DigitalClock digitalClock = new DigitalClock();
            digitalClock.Subscribe(clock);

            Log log = new Log();
            log.Subscribe(clock);

            clock.Run();
        }
    }
}
