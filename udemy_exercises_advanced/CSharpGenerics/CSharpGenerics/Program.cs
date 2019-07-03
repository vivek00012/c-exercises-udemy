using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Book = new Book { ISBN = "SSN87878787", Price = 32f };

            var numbers = new GenericList<int>();
            numbers.Add(10);
            //here generic list is a list of integers.so no boxing and un boxing is going to occur.

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value"+number.HasValue);
            Console.WriteLine("Value"+number.GetValueOrDefault());

        }
    }
}
