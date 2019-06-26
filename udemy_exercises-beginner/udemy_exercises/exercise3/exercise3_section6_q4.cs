using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_exercises.exercise3
{
   public class exercise3_section6_q4
    {
        public void inputNumber()
        {


           
                var arrayList = new List<int>();


                while (true)
                {
                    Console.Write("Enter a number (or 'Quit' to exit): ");

                    var input = Console.ReadLine();

                    if (input.ToLower() == "quit")

                    {
                        break;
                    }
                    
                        arrayList.Add(Convert.ToInt32(input));
                    


                }

                var uniqueList = new List<int>();

                foreach (var x in arrayList)
                {
                    if (!uniqueList.Contains(x))
                    {
                        uniqueList.Add(x);
                    }
                }
                Console.WriteLine("the unique numbers are :");

                foreach(var data in uniqueList)
                {
                    Console.WriteLine(data);
                }
            }
           
        }
    
}
