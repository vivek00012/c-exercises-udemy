using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLinq
{
    class Program
    {
        //LINQ-It is lanquage integrated query ..
        //it is used to query..
        //objects in memory,eg collections(LINQ TO OBJECTS)..
        //Databases(Linq to entities)...
        //XML..(LINQ TO XML)..
        //ADO.NET DATA Sets(Linq to Data Sets)..



         
        static void Main(string[] args)
        {

            //using LINQ extension methods..

            var bookList = new BookRepository().BookList;

            var CheapBookList = bookList
                                     .Where(b => b.price < 10)
                                     .OrderBy(b => b.title)
                                     .Select(b => b.title);
            //can be re-written using LINQ Query Methods..

            var CheapBookListUsingLinqQuery = from b in bookList
                                              where b.price < 10
                                              orderby b.title
                                              select b.title;


            //Linq other Extension Methods..
            //bookList.Where();
            //bookList.Single();
            //bookList.SingleOrDefault();

            //bookList.First();
            //bookList.FirstOrDefault();

            //bookList.Last();
            //bookList.LastOrDefault();

            //bookList.Min();
            //bookList.Max();
            //bookList.Count();
            //bookList.Sum();
            //bookList.Average();

            //bookList.Skip(3).Take(2);usually used in paging


            //console 1

            foreach (var bookTitle1  in CheapBookList)
            {
                Console.WriteLine(bookTitle1);

            }

            //console 2

            foreach (var bookTitle2 in CheapBookListUsingLinqQuery)
            {
                Console.WriteLine(bookTitle2);

            }


        }
    }
}
