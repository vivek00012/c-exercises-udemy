using System;
using System.Linq;
using System.Collections.Generic;
namespace udemy_exercises.exercise3
{
    public class exercise3_section6_q1
    {
        List<string> arrayList = new List<string>();
        public void getNames()
        {
            
            try
            {
                while (true)
                {
                    Console.WriteLine("Please type your Name :");
                    var input = Console.ReadLine();
                    Console.WriteLine(displayNames(input));
                    
                }
              

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input");
            }

        }

        public string displayNames(string text)
        {
            arrayList.Add(text);
            var message="";
            var remArray=new List<string>();
            var count= arrayList.Count;
                if (count == 1)
                {
                    message = string.Format("{0} enters his name ;", arrayList[0]);
                }else if (count==2)
                {
                    message= string.Format("{0} and {1} enter their name ;", arrayList[0], arrayList[1]);
                    
                }else 
                {
                var remCount = arrayList.Count - 2;
                var stringOther = (remCount == 1) ? "other":"others" ;
                    message = string.Format("{0},{1} and {2} {3} enter their name ;", arrayList[0], arrayList[1], remCount,stringOther);
                }
            
            return message;


        }
    }
}
