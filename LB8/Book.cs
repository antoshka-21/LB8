using System;
using System.Collections.Generic;
using System.Text;

namespace LB8
{
    public class Book : IProduct
    {
        
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Label { get; private set; }
        public DateTime DateOfIssue { get; private set; }
        public int NumberOfPages { get; private set; }


        public decimal Price { get; private set; }

        public decimal Discount { get; private set; }

        public string Manufacturer { get; private set; }


        public Book(string name, string author, string label, DateTime dateOfIssue, int numberOfPages, decimal price, decimal discount, string manufacturer)
        {
            Name = name;
            Author = author;
            Label = label;
            DateOfIssue = dateOfIssue;
            NumberOfPages = numberOfPages;
            Price = price;
            Discount = discount;
            Manufacturer = manufacturer;
        }

        public string GetData()
        {
            return $"Название: {Name}, автор: {Author}, издатель: {Label}, дата выпуска: {DateOfIssue}, кол-во страниц: {NumberOfPages}";
        }

        public decimal GetPriceWithDiscount()
        {
            return Price - Discount;
        }
    }
}
