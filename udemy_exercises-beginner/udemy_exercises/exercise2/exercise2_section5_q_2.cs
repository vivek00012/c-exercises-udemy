using System;
using System.Collections.Generic;


namespace udemy_exercises.exercise2
{
    public class exercise2_section5_q_2
    {
        List<float> arrayList = new List<float>();

        public void getSum()
        {
            var sum=0;

            while (true)
            {

                Console.Write("Please input any number or press type ok to exit : ");
                var data = Console.ReadLine();
                if (data.ToLower() == "ok")
                {
                    break;
                  
                }
                sum += Convert.ToInt32(data);
             


                //getSum();

            }
            Console.WriteLine("Sum of all numbers is: " + sum);






        }
    }
}
