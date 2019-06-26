using System;
using System.Collections.Generic;


namespace udemy_exercises.exercise2
{
    public class exercise2_section5_q_1
    {

        List<int> dataList = new List<int>();
        public void getNumbersDivisibleBy3()
        {
            var count = 0;
            Console.WriteLine("The numbers between 1 and 100 and divisible by 3 are:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + ",");
                    dataList.Add(i);
                    count++;
                }
       
            }
            Console.WriteLine("\n Count of the numbers divisible by 3:{0}", count);
  
        }
    }
}
