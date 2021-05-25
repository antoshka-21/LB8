using System;

namespace LB8
{
    public class ElectricKettle : IProduct, IConsumingElectricity
    {

        public string Model { get; private set; }
        public ConsoleColor Color { get; private set; }
        public double Volume { get; private set; }
        public double Power { get; private set; }


        public decimal Price { get; private set; }

        public decimal Discount { get; private set; }

        public string Manufacturer { get; private set; }

        public DateTime DateOfIssue { get; private set; }


        public double Voltage { get; private set; }

        public double Amperage { get; private set; }

        public bool IsConnected { get; private set; }


        private double TimeOfWork = 0;


        public ElectricKettle(string model, ConsoleColor color, double volume, double power, decimal price, decimal discount, string manufacturer, DateTime dateOfIssue, double voltage, double amperage)
        {
            Model = model;
            Color = color;
            Volume = volume;
            Power = power;
            Price = price;
            Discount = discount;
            Manufacturer = manufacturer;
            DateOfIssue = dateOfIssue;
            Voltage = voltage;
            Amperage = amperage;
        }


        public string GetData()
        {
            return $"Модель: {Model}, цвет: {Color.ToString()}, объем: {Volume}, мощность: {Power}";
        }


        public decimal GetPriceWithDiscount()
        {
            return Price - Discount;
        }

        public void ConnectToTheNetwork()
        {
            if (!IsConnected)
            {
                Console.WriteLine("Connected");
                IsConnected = true;
                TimeOfWork += 0.075;
            }
            else
                Console.WriteLine("Already connected!");
        }

        public void DisconnectFromTheNetwork()
        {
            if (IsConnected)
            {
                Console.WriteLine("Disconnected");
                IsConnected = false;
            }
            else
                Console.WriteLine("Already disconnected!");
        }

        public double DetermineCostsEnergy()
        {
            return Amperage * Voltage * TimeOfWork;
        }

    }
}
