using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Bus : Transport
    {
        public override void StartTravel()
        {
            Console.WriteLine("Bus is starting to travel");
        }
        public override void StopTravel()
        {
            Console.WriteLine("Bus is stopping");

        }
        public override void GetTravelInfo()
        {
            Console.WriteLine("Bus is traveling");

        }
    }
}