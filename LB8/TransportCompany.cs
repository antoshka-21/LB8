using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace LB8
{
    public class TransportCompany : IEnumerable
    {

        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public ShippingOrder[] Orders { get; private set; }

        public TransportCompany(string name, string phoneNumber, ShippingOrder[] orders)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Orders = orders;
        }

        public IEnumerator GetEnumerator()
        {
            return Orders.GetEnumerator();
        }
    }
}
