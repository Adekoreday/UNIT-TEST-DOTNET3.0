using System;


namespace Interface
{
    public class OrderProcessor
    {
        private readonly IshippingCalculator _shippingCalculator;
        public OrderProcessor(IshippingCalculator shippingCalculator) {
            _shippingCalculator = shippingCalculator;
        }
       public void Process(Order order) {
            if(order.IsShipped)
            throw new InvalidOperationException("This order is already processed");

            order.shipment = new Shipment {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShipmentTime = DateTime.Today.AddDays(1),
            };
        }
    }
}