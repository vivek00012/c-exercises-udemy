using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_exercises.exercise3
{
    public class exercise3_section6_q5
    {
        public void inputString()
        {
            try
            {
                var array = new List<string>();
                while (true)
                {
                    Console.WriteLine("please input list of string");
                    var input = Console.ReadLine();
                    array.AddRange(input.Split(','));

                    if (array.Count == 0 || array.Count < 5 || string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("invalid list !please retry");
                        array.Clear();
                        continue;
                    }
                    break;
                }

                array.Sort();
                Console.WriteLine("The smallest three numbers in array is");
                for(var i = 0; i < array.Count; i++)
                {
                    if (i >= 2)
                    {
                        array.RemoveAt(i);
                    }
                }

                foreach(var x in array)
                {
                    Console.WriteLine(x);
                }



                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
