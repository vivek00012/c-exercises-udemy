using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //abstract classes:cannot be instantiated
            //abstract class is the base class that create a common behaviour.. 

            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Cannvas();
            canvas.DrawShapes(shapes);
        }
    }
}
