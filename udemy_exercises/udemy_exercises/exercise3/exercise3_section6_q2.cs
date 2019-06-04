using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_exercises.exercise3
{
    public class exercise3_section6_q2
    {
        public void typeInput()
        {
            Console.WriteLine("Input any String:");
           
                var input = Console.ReadLine();
                Console.WriteLine(reverseString(input,input.Length)); 


         

                Console.WriteLine("Not a valid string");
       

        }

        public string reverseString(string text,int textLength)
        {;
            var userTextArray = new char[textLength];
            var reverseString = "";
            for(int i= textLength; i>0;i--)
            {
                userTextArray[textLength - i] = text[i-1];
                reverseString = new string(userTextArray);
            }
            return reverseString;
        }


    }
}
