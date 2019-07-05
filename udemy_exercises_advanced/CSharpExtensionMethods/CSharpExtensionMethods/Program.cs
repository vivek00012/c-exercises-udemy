using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CSharpExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string post = "This is supossed to be very very long word blah blah......";

            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);



          
            
          
        }
    }
}
