using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharpLambdaexpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using predicate:
            //DEFINITION:Predicate is a delegate which points to a method that gets a argument and returns a boolean value


            var booksList = new BookRepository().BookLists;

            //conventional way
            //var cheepBooks=booksList.FindAll(IsCheaperThan10Dollars);//find all accepts a predicate which points to a method having argument as Book
            //using lambda expression..
            //var cheepBooks=booksList.FindAll(book=>book.Price<10); //can b shortened as the argument containing will always be of book type since list is of book object
            //can be re-written as..

            var cheepBooks = booksList.FindAll(b => b.Price < 10);


            foreach (var book in cheepBooks)
            {
                Console.WriteLine(book.Title);
            }

            //syntax of lambda expression: args=>expression


            //1:using delegate to point to lambda expression..
            //The first parameter of the func represents the argument of the function and the second parameter represents the data type of the result
            Func<int, int> square = number => number * number;//accepts a single argument

            //for multiple arguments:parameters must be passed inside parenthesis (x,y,z)=>

            //calling the delegate
           
            try
            {
                while (true)
                {
                    //using Foreground clor property of console to change the color...
                    Console.Write("please provide your input to get square of the number : ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    var UserInput = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The square of number is : " + square(UserInput));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please Wait..");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Cannot parse the string or special characters");            }
           
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }


      


        

    
    }
}
