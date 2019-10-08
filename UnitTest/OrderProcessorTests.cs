using Xunit;
using System;
using Interface;


namespace UnitTest
{
    public class OrderProcessorTests
    {
        [Fact]
        public void Process_Order_Is_Already_Shipped() {
            var OrderProcessor = new OrderProcessor(new FakeShipmentCalculator());
            var order = new Order{
                shipment = new Shipment()
            };
       Assert.Throws<InvalidOperationException>(() => OrderProcessor.Process(order));
        //    Assert.True(ex.ParamName, Is.EqualTo("This order is already processed"));
        // OrderProcessor.Process(order);
        }

        [Fact]
        public void Process_Order_Is_Not_Shipped() {
            var OrderProcessor = new OrderProcessor(new FakeShipmentCalculator());
            var order = new Order();
            OrderProcessor.Process(order);
            Assert.True(order.IsShipped);
            Assert.Equal(1, order.shipment.Cost);
            Assert.Equal(DateTime.Today.AddDays(1), order.shipment.ShipmentTime);
        }

        public class FakeShipmentCalculator : IshippingCalculator
        {
            public float CalculateShipping(Order order) {
                return  1;
            }
        }
    }
}