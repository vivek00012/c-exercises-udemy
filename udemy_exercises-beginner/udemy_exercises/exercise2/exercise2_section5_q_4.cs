using System;

namespace udemy_exercises.exercise2
{
    public class exercise2_section5_q_4
    {
        public int secretNumber;
        public int guessNumber;
        public void guessYourNumber()
        {
            try
            {
                Console.WriteLine("Your secret number:");
                
                var random = new Random();


                secretNumber= random.Next(1,10);
                Console.WriteLine("Secret Number recorded :{0}", secretNumber);
            
                       // Console.Clear();
                 
                

                
                Console.WriteLine("Provide Your Secret Number! You have four guesses");
             
                for(var i = 0; i <= 4; i++)
                {
                    guessNumber = Convert.ToInt32(Console.ReadLine()); ;
                    if (secretNumber==guessNumber)
                    {
                        Console.WriteLine("congrats you won !!");
                        return;
                    }
                }

                Console.WriteLine(" you lost !!");

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Input Provided");
            }
          

           
        }
    }
}
