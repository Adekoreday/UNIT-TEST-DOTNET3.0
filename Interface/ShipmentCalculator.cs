using System;

namespace Interface
{
    public interface IshippingCalculator
    {
        float CalculateShipping(Order Order);
    }

    public class ShipmentCalculator : IshippingCalculator
    {
      public float CalculateShipping(Order order) {
          if(order.TotalPrice > 30f) 
             return order.TotalPrice * 0.1f;
          return 0;
        }
    }
}