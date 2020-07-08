using System;
using System.Timers;
namespace CountdownConsole.Data
{


    class TimerCD
    {
        public TimerCD()
        {
            countDTimer();
        }

        public static int number = 2000;
        public static bool countDTimer()
        {
            Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Elapsed += (s, e) => number -= 10;
            number -= 10;
            tm.Start();
            while (number > 0)
            {
                Console.WriteLine(number);
            }
            tm.Stop();
            return true;
        }

    }

}