using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Encendiendo motores");
        }
    }
}