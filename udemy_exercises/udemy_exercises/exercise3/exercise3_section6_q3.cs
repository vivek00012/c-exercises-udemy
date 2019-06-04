using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_exercises.exercise3
{
    public class exercise3_section6_q3
    {
        public void inputNumber()
        {
            try
            {

                var arrayList = new List<int>();


                while (arrayList.Count < 5)
                {
                    Console.WriteLine("Please input number :");
                    var input = Convert.ToInt32(Console.ReadLine());
                    if (arrayList.Contains(input))
                    {
                        Console.WriteLine("You have already entered"+input);
                        continue;
                    }
                    arrayList.Add(input);
                    arrayList.Sort();
                    foreach (var x in arrayList)
                    {
                        Console.WriteLine(x);
                    }
                }
                
               
            }
            catch (Exception)
            {
                Console.WriteLine("Not a vaid input");
            }
        }
    }
}
