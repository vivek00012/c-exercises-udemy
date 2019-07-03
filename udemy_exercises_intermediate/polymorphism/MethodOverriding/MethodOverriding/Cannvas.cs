using System.Collections.Generic;

namespace MethodOverriding
{

 
        public class Cannvas
        {
          public void DrawShapes(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }
           
        }
    
}
