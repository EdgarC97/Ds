using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Rectangle : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }
        
        public override double CalculateArea(double length, double width)
        {
            double area = length * width;
            Console.WriteLine($"El area del rectangulo es --> {area:F2}");
            return area ;
        }
    }
}