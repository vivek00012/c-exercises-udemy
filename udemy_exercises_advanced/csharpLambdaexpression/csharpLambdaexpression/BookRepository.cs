using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLambdaexpression
{
    public class BookRepository
    {
        public List<Book> BookLists = new List<Book>{new Book()
        {
            Title = "title 1",
            Price = 4.75f

        }, new Book()
        {
            Title = "title 2",
            Price = 9.75f

        }, new Book()
        {
            Title = "title 3",
            Price = 42.75f

        } };
    }
}
