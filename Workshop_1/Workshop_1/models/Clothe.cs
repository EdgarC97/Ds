using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Clothing : Product
    {
        public string? OriginCountry { get; set; }

        public Clothing(string name, double price, int quantity, double taxes, string originCountry) : base(name, price, quantity, taxes)
        {
            OriginCountry = originCountry;
        }

        public override void ShowProductDetail()
        {
            Console.WriteLine($"===Clothing Products===");
            base.ShowProductDetail();
            Console.WriteLine($"Origin Country: {OriginCountry}");
        }
    }
}