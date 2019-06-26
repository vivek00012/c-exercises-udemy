using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace udemy_exercises.exercise4
{
    public class exercise4_section8_q1
    {
        public void typeInput()
        {
            Console.WriteLine("Please Type Input :");
            try
            {
                var input = Console.ReadLine();


                var arrayList =input.Split('-');
                //Array.Sort(arrayList);
                Console.WriteLine(verifyConsequtive(arrayList.ToList()));

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input");
            }
           
            
        }

        public string verifyConsequtive(List<string> arrayList)
        {

            var message = "";
            var isConsecutive=true;
            for (int i=1;i<arrayList.Count;i++)
            {
                Console.WriteLine();
                if (int.Parse(arrayList[i]) != int.Parse(arrayList[i - 1]) + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            return message =isConsecutive ?  "Consequtive" : "Not Consequtive";


        }
        
    }

}
