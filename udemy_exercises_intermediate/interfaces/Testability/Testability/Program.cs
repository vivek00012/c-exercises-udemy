using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            //orderProcessor concrete class doesnt know about the existence of other concrete classes..so dependency is safe
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order
            {
                DatePlaced=DateTime.Now,
                TotalPrice=100f
            };

            orderProcessor.Process(order);
            
            
        }
    }
}
