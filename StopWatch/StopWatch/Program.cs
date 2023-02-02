using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
     class StopWatch
    {

        private DateTime StartTime;
        private DateTime EndTime;
        private bool running;


        public void Start()
        {
            if (running)
            {
                throw new InvalidOperationException("Stopwatch in already Running");
            }
            StartTime = DateTime.Now;
            running = true;
        }

        public void Stop()
        {
            if (!running)
            {
                throw new InvalidOperationException("Stopwatch in not Running");
            }

            EndTime = DateTime.Now;
            running = false;
        }
        public TimeSpan GetInterval()
        {
            var Duration = EndTime - StartTime;
            return Duration;
        }
    }

    public  class Program
    {
        static void Main(string[] args)
        {

            var stopwatch = new StopWatch();


            for( var i=0; i< 2; i++ ) {

                stopwatch.Start();
                Thread.Sleep(8000);

                stopwatch.Stop();

                Console.WriteLine("duration" + stopwatch.GetInterval());

                Console.WriteLine("Press Enter to Run Stopwatch One More Time");

                Console.ReadLine();


            }
        }
    }

    
}
