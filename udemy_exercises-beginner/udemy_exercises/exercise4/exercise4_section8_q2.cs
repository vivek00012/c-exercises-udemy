using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace udemy_exercises.exercise4
{
    public class exercise4_section8_q2
    {

        public void typeInput()
        {
            Console.WriteLine("Please give your input :");

            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }
         
            var arrayList = new List<int>();
            foreach (var x in input.Split('-'))
            {
                arrayList.Add(Convert.ToInt32(x));
            }
            var uniquelist = new List<int>();
            var includeDuplicates = false;
            foreach (var no in arrayList)
            {
                if (!uniquelist.Contains(no))
                {
                    uniquelist.Add(no);
                   
                }
                else
                {
                    includeDuplicates = true;
                    break;
                }
            }

            if (includeDuplicates)
            {
                Console.WriteLine("Duplicate");
            }
            else
            {
                foreach(var x in arrayList)
                {
                    Console.WriteLine(x);
                }
            }

        }
    }
}
