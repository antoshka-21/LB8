using System;
using LB8;

namespace LB8_
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Простоквашино", "Пушкин А.С.", "Дрофа", new DateTime(1988, 03, 12), 25, 119, 20, "Дрофа 2");
            Book book2 = new Book("Колобок", "Гоголь А.С.", "Звезда", new DateTime(1992, 05, 15), 10, 89, 15, "Звезда 2");

            ElectricKettle kettle1 = new ElectricKettle("HF-1200", ConsoleColor.Red, 1.5, 75, 2000, 500, "Производитель чайников №1", new DateTime(2019, 12, 1), 220, 20);
            ElectricKettle kettle2 = new ElectricKettle("BG-999", ConsoleColor.Green, 1.75, 60, 1699, 300, "Производитель чайников №2", new DateTime(2020, 7, 3), 220, 19);

            Console.WriteLine(book1.GetData());
            Console.WriteLine(book2.GetData());
            Console.WriteLine(kettle1.GetData());
            Console.WriteLine(kettle2.GetData());

            Console.WriteLine("Скидка у книги 1: " + book1.GetPriceWithDiscount());
            Console.WriteLine("Скидка у книги 2: " + book2.GetPriceWithDiscount());
            Console.WriteLine("Скидка у чайника 1: " + kettle1.GetPriceWithDiscount());
            Console.WriteLine("Скидка у чайника 2: " + kettle2.GetPriceWithDiscount());

            kettle1.ConnectToTheNetwork();
            kettle1.DisconnectFromTheNetwork();
            kettle1.ConnectToTheNetwork();
            kettle1.DisconnectFromTheNetwork();
            kettle1.ConnectToTheNetwork();
            kettle1.DisconnectFromTheNetwork();

            Console.WriteLine(kettle1.DetermineCostsEnergy());

        }
    }
}
