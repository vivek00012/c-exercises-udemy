using System;

namespace udemy_exercises.exercise2
{
    class exercise2_section5_q_3
    {
       public void getFactorial()
        {
            Console.WriteLine("Provide your input  :");

            var input = Console.ReadLine();

            try
            {

                var factorial = 1;
                for(int i = 1; i <= Convert.ToInt64(input); i++)
                {
                    factorial *= i;
                }
                Console.Write("The factorial of {0} is :{1}", input,factorial);


                Console.WriteLine();
                getFactorial();
            }
            catch (Exception)
            {
                if (input.ToLower()!="OK")
                {
                    Console.WriteLine("You are exited from the application");

                }
            }
        }
    }
}
