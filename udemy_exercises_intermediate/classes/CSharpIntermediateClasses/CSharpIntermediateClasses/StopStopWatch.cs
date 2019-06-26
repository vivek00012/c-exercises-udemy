using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateClasses
{
    class StopStopWatch
    {
        public  string stopTime
        {
            get;private set;
        }
        private DateTime dtime1;
        private DateTime dtime2;


        public string GetDuration(string initialTime)
        {
            Console.WriteLine("Type Stop to stop the StopWatch");
           
            var UserInput = Console.ReadLine();
            if (UserInput == "Stop")
            {
                this.stopTime = DateTime.Now.ToLongTimeString();
                DateTime.TryParse(stopTime, out dtime1);
                DateTime.TryParse(initialTime, out dtime2);
                var timeDiff = dtime1 - dtime2;
                var Duration = timeDiff.Hours.ToString("00") + "HRS" + ":" + timeDiff.Minutes.ToString("00") + "MINS" + ":" + timeDiff.Seconds.ToString("00") + "SECS";
                var msg ="The Duration is "+ timeDiff.Hours.ToString("00")+"HRS"+":"+ timeDiff.Minutes.ToString("00") + "MINS" + ":"+ timeDiff.Seconds.ToString("00") + "SECS";
                return msg;
            }

            else
            {
                return "Invalid Command Provided";
            }

           
        }


    }
}
