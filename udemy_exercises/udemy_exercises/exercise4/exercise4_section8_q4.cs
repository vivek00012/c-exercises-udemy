using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_exercises.exercise4
{
    public class exercise4_section8_q4
    {
        public void typeInput()
        {
            Console.WriteLine("Please Input Any String!It will be converted to Pascal Case");
            var input = Console.ReadLine();
            var arrayList = input.Split(' ');
            var stringText=new StringBuilder();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            foreach(var x in arrayList)
            {
                var pascalWord = char.ToUpper(x[0]) + x.Substring(1).ToLower();
                stringText.Append(pascalWord);

            }
            Console.WriteLine("the string is "+stringText);
        }
    }
}
