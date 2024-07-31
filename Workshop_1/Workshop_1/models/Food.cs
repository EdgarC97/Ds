using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Food : Product
    {
        public string? supplier { get; set; }

        public Food(string name, double price, int quantity,double taxes, string supplier) : base (name, price, quantity,taxes)
        {
            this.supplier = supplier;
        }

        public override void ShowProductDetail()
        {
            Console.WriteLine($"===Food Products===");
            base.ShowProductDetail();
            Console.WriteLine($"Supplier: {supplier}");
        }
    }
}