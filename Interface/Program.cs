using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor (new ShipmentCalculator());
            var order = new Order {
                DatePlaced = DateTime.Now,
                TotalPrice = 104.0f,
            };
            orderProcessor.Process(order);
            Console.WriteLine(order.shipment.Cost);
        }
    }
}
