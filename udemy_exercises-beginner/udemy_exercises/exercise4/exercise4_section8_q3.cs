using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_exercises.exercise4
{
   public class exercise4_section8_q3
    {
        public  void checkTime()
        {
            Console.WriteLine("Please Write Your Time :");

            var input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input) || input.IndexOf(':') == -1)
            {
                Console.WriteLine("invalid time");
            }

            var hourPart = Convert.ToInt32(input.Split(':')[0]);
            var minutePart =Convert.ToInt32(input.Split(':')[1]);


            if (hourPart >= 0 && hourPart <= 23 && minutePart >= 00 && minutePart <= 59)
            {
                Console.WriteLine("The time is valid and time is {0}:{1}",hourPart,minutePart);
            }
            else
            {
                Console.WriteLine("Invalid Time");

            }




        }
    }
}
