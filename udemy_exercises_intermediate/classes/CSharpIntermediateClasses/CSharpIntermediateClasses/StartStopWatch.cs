using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateClasses
{
    class StartStopWatch
    {

        public string StartTime { get; private set; }

        public string GetInitialTime(string time)
        {
            this.StartTime = time;
            while (true)
            {
                var userInput = Console.ReadLine();

                if (userInput != "Start")
                {
                    Console.WriteLine("Please Try again");

                    continue;

                }
               
                if (userInput == "Start")
                {
                    Console.WriteLine("The Start time is "+time);
                    return time;
                }
                else
                {
                    return "Invalid Command Provided";
                }
            }

           
           

        }
    }
}
