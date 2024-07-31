using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Car_1 : Transport
    {
        public override void StartTravel()
        {
            Console.WriteLine("Car started traveling");
        }
        public override void StopTravel()
        {
            Console.WriteLine("Car stopped traveling");
        }
        public override void GetTravelInfo()
        {
            Console.WriteLine("This is a car traveling");
        }
    }
}