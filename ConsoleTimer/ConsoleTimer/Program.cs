using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.consoleTimer();
            Console.ReadLine();
        }
        class StopWatch
        { 
            public async void consoleTimer()
            {
                TimeSpan timer = new TimeSpan(0, 0, 0);
                TimeSpan addTick = new TimeSpan(0, 0, 1);

                for (int i = 0; i < 3600; i++)
                {                    
                    await Task.Delay(1000);
                    timer = timer.Add(addTick);
                    Console.Clear();
                    Console.WriteLine(timer);
                }      
            }
        }
    }
}
