using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Garment
    {
        public string? Name { get; set; }
        private string? Size { get; set; }
        private double Price { get; set; }

        //Constructor
        public Garment(string name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }
        public void ShowGarmentDetails()
        {
            Console.WriteLine($"Nombre --> {Name} --> {Size} --> {Price:C}");
        }
    }
}