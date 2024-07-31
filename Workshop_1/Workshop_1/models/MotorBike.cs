using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class MotorBike : Vehicle
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("Moto encendida brapppppp brap brap brap");
        }
    }
}