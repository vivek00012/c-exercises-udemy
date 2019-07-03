using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateClasses
{
    class StartStopWatch
    {

        private string _startTime;

        public string GetInitialTime()
        {
            this._startTime=DateTime.Now.ToLongTimeString();
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
                    Console.WriteLine("The Start time is "+ _startTime);
                    return _startTime;
                }
                else
                {
                    return "Invalid Command Provided";
                }
            }

           
           

        }
    }
}
