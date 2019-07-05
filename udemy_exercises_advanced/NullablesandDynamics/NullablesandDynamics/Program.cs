using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullablesandDynamics
{

    class Program
    {
        static void Main(string[] args)
        {
            // ClassA myClassObject = new ClassB();
            dynamic classA = new ClassA();
            classA = new ClassB();
            classA.MethodB();
            
        





        }
    }
}
