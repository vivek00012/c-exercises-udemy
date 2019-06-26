using System;

namespace udemy_exercises.exercise2
{
   public class exercise2_section5_q_5
    {
       public void findMax()
        {
            Console.WriteLine("Please Provide list of string seperated by ','");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach(var el in numbers)
            {
                var no = Convert.ToInt32(el);
                if (no > max)
                {
                    max = no;
                }

            }
            Console.WriteLine("The maximum number is {0}",max);
            

        }
    }
}
