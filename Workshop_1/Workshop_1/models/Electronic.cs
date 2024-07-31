using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Electronic : Product
    {
        public string? Manufacturer { get; set; }
        
        public Electronic(string name, double price, int quantity, double taxes,  string manufacturer)
            : base(name, price, quantity, taxes)
        {
            Manufacturer = manufacturer;
        }
        public override void ShowProductDetail()
        {
            Console.WriteLine($"===Electronic Products===");
            base.ShowProductDetail();
            Console.WriteLine($"Manufacturer: {Manufacturer}");
        }
    }
}