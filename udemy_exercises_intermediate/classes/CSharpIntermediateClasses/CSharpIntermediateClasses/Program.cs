using System;

namespace CSharpIntermediateClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Stop Watch will automatically start once you run the application !!Type Start to start the application");

            var startWatch = new StartStopWatch();
            var stopWatch = new StopStopWatch();
            //Console.WriteLine(startWatch.GetInitialTime(DateTime.Now.ToLongTimeString()));
            //var StartTime = ;
            Console.WriteLine(stopWatch.GetDuration(startWatch.GetInitialTime(DateTime.Now.ToLongTimeString())));
           // Console.WriteLine(st);


        }
    }
}
