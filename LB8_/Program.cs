using System;
using LB8;

namespace LB8_
{
    class Program
    {
        static void Main(string[] args)
        {
            //========= Часть 1 ============
            Book book = new Book("Простоквашино", "Пушкин А.С.", "Дрофа", new DateTime(1988, 03, 12), 25, 119, 20, "Дрофа 2");

            ElectricKettle kettle = new ElectricKettle("HF-1200", ConsoleColor.Red, 1.5, 75, 2000, 500, "Производитель чайников №1", new DateTime(2019, 12, 1), 220, 20);

            Console.WriteLine(book.GetData());
            Console.WriteLine(kettle.GetData());

            Console.WriteLine("Скидка у книги: " + book.GetPriceWithDiscount());
            Console.WriteLine("Скидка у чайника: " + kettle.GetPriceWithDiscount());

            kettle.ConnectToTheNetwork();
            kettle.DisconnectFromTheNetwork();
            kettle.ConnectToTheNetwork();
            kettle.DisconnectFromTheNetwork();
            Console.WriteLine("Потреблено энергии: " + kettle.DetermineCostsEnergy());

            //========= Часть 2 ============
            ShippingOrder[] orders = new ShippingOrder[3] { new ShippingOrder(113, DateTime.Now, "Куликова 8", 855, 2999),
                                                            new ShippingOrder(228, DateTime.Now, "Московская 22", 214, 599),
                                                            new ShippingOrder(844, DateTime.Now, "Куйбышева 13", 1210, 3299)};

            Array.Sort(orders);

            TransportCompany company = new TransportCompany("Delivery Club", "+79194447788", orders);

            foreach (ShippingOrder order in company)
                Console.WriteLine("Вес груза:" + order.Weight);

        }
    }
}
