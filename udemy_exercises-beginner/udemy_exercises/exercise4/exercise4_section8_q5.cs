using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_exercises.exercise4
{
    public class exercise4_section8_q5
    {
        public void typeInput()
        {
            var input = "";
            Console.WriteLine("Please type Input");
             input = Console.ReadLine();
            if(input.IndexOf(" ") != -1)
            {
                input = string.Join("",input.Split(' '));
            }

            Console.WriteLine(input);
            var arrayList = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            var vowels = new List<char>();
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid Input");
                    return;
                }
                var includevowels = false;
                var vowelCount = 0;
                foreach(var x in input)
                {
                    if (arrayList.Contains(x))
                    {
                        vowelCount++;
                        includevowels = true;
                    }
                    
                   
                }
                var stringformat = string.Format("vowels found : {0}", vowelCount);

                Console.WriteLine(includevowels ? stringformat : "no vowels found");



            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }
}
