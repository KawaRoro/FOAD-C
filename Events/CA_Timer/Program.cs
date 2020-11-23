using System;
using System.Timers;

namespace CA_Timer
{
    class Program
    {
        public static void Main()
        {
            Timer newTimer = new Timer();
            newTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            newTimer.Interval = 1000;
            newTimer.Start();

            while (Console.Read() != 'q')
            {
                ;    // we can write anything here if we want, leaving this part blank won’t bother the code execution.
            }

        }

        public static void CreateTimer(int _delay)
        {
            int Delay = _delay*1000;
            Timer newTimer = new Timer();
            newTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            newTimer.Interval = Delay;//2000;
            newTimer.Start();

            while (Console.Read() != 'q')
            {
                ;    // we can write anything here if we want, leaving this part blank won’t bother the code execution.
            }
        }

        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            Console.Write(" \r{0} ", DateTime.Now);
        }

        public static void DeleteTimer(Timer _timer)
        {
            _timer.Stop();
        }
    }
}
