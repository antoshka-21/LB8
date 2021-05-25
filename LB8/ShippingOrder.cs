using System;
using System.Collections.Generic;
using System.Text;

namespace LB8
{
    public class ShippingOrder : IComparable
    {

        public int Number { get; private set; }
        public DateTime DeliveryDate { get; private set; }
        public string DelivetyAddress { get; private set; }
        public double Weight { get; private set; }
        public decimal TransportationCost { get; private set; }


        public ShippingOrder(int number, DateTime deliveryDate, string delivetyAddress, double weight, decimal transportationCost)
        {
            Number = number;
            DeliveryDate = deliveryDate;
            DelivetyAddress = delivetyAddress;
            Weight = weight;
            TransportationCost = transportationCost;
        }


        public int CompareTo(object obj)
        {
            ShippingOrder order = (ShippingOrder)obj;

            if (order != null)
            {
                if (this.Weight < order.Weight)
                    return -1;
                else if (this.Weight > order.Weight)
                    return 1;
                return 0;
            }

            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
