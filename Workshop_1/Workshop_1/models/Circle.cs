using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Circle : Figure
    {
        double Radius { get; set; }
        public override double CalculateArea(double radius)
        {
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine($"El area del circulo es --> {circleArea:F2}");
            return circleArea ;
        }
    }
}