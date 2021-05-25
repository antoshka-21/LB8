using System;
using System.Collections.Generic;
using System.Text;

namespace LB8
{
    public interface IProduct
    {

        decimal Price { get; }
        decimal Discount { get; }
        string Manufacturer { get; }
        DateTime DateOfIssue { get; }
        decimal GetPriceWithDiscount();

    }
}
