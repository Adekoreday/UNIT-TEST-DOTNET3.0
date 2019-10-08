using System;

namespace Interface
{
    public class Shipment {
        public float Cost { get; set; }
        public DateTime ShipmentTime { get; set; }
    }
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public float TotalPrice {get; set; }
        public Shipment shipment {get; set; }
        public bool IsShipped { get {
            return shipment != null;
        } }
    }
}