using System;
using System.Linq;


namespace udemy_exercises.exercise1
{
   public class exercise1_section5_q2
    {
        public int userInputA;
        public int userInputB;
        public int[] arrayList= new int[2];
        public int maxNumber;

    public void enterFirstNumber()
    {
            try
            {
                Console.WriteLine("Please Input First Number");
                userInputA = Convert.ToInt32(Console.ReadLine());
                enterSecondNumber();
            }
            catch (Exception)
            {
                Console.WriteLine(@"Invalid Input ! Please type valid number.
                 Try again !!");
                enterFirstNumber();
            }         

        }


        public void enterSecondNumber()
        {

            try
            {
                Console.WriteLine("Please Input Second Number");
                userInputB = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine(@"Invalid Input ! Please type valid number.
                 Try again !!");
                enterFirstNumber();
            }

            arrayList[0] = userInputA;
            arrayList[1] = userInputB;

            maxNumber = arrayList.Max();

            Console.WriteLine("The maximum of two numbers is : {0}", maxNumber);



        }
    }
}
