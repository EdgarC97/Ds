using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Taxes { get; set; }

        public Product(string name, double price, int quantity, double taxes)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Taxes = taxes;
        }

        public virtual void CalculateFinalPrice()
        {
            double FinalPrice = Price * Quantity * (1 + Taxes / 100);
            Console.WriteLine($"Final Price: {FinalPrice:C}");
        }
        public virtual void ShowProductDetail()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price:C}\nQuantity: {Quantity}\nTaxes: {Taxes}%");
        }
    }
}