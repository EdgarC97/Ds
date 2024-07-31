using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Figure
    {
        public virtual double CalculateArea(double length, double width)
        {
            return length * width;
        }
        public virtual double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

    }
}