
using System;

namespace udemy_exercises.exercise1
{
    public class exercise1_section5_q1
    {
        //declaration
        public int maxNum = 10;
        public int minNum = 0;

        public int userInput;
        public string string_data;

         
        //use conditional statements
        public void getDataConditional()
        {
            Console.WriteLine("Please Give Your Input");
            userInput= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Input is {0}",userInput);

            if (userInput<=maxNum && userInput>0)
            {
                Console.WriteLine("VALID!");
            }
            else
            {
                Console.WriteLine("INVALID!");
            }
        }

        public void getDataloop()
        {


            for (var i = userInput; i < maxNum; i++)
            {
                Console.WriteLine("Please Give Your Input");
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput <= maxNum && userInput > 0)
                    {
                        Console.WriteLine("VALID!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("INVALID!");
                        Console.WriteLine("Validation Checks Complete");

                        break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number");

                }
                
            }
        }
    }
}