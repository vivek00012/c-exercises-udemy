using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegates
{
    public class Program
    {
        static void Main(string[] args)
        {
//IEnumerable is an interface defining a single method GetEnumerator() that returns an IEnumerator interface. It is the base interface for all non-generic collections that can be enumerated.

//This works for read-only access to a collection that implements that IEnumerable can be used with a foreach statement.

//It has a single method −

//GetEnumerator() − This method returns an enumerator that iterates through a collection.
            IEnumerable<int> list = new List<int> { 1, 2, 3, 4 };
            
            var processor = new PhotoProcessors();
            var genericDelegates = new GenericDelegates();
            var filter = new PhotoFilter();
            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;//POINTING TO A METHOD
            filterHandler += filter.Resize;
            filterHandler += RemoveRedEyeFilter;
            //processor.Process("Photo.jpg", filterHandler);
            genericDelegates.Process("Photo.jpg", filterHandler);
            
        }
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Remove Red eye");
        }
    }
}
