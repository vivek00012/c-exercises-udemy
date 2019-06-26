using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testability;

namespace Testability.UnitTest
{
    [TestClass]
    public class OrderProcessorTests
    {
        //methodname convention:METHOD_NAME_CONDITION_EXPECTATION
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsShipped_ShouldSetTheShippmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
               
            };
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1,order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }

    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        //methods defined in the interface should be public 
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
