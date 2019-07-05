using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLinq
{
    public class BookRepository
    {
        public List<Book> BookList = new List<Book>() { new Book() { title = "c# advanced", price = 8 },
        new Book() { title = "c# intermediate", price = 20 },new Book() { title = "c# basic", price = 9 }};
    }
}
