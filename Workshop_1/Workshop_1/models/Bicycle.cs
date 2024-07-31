using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Bicycle : Transport
    {
        public override void StartTravel()
        {
            Console.WriteLine("Bicycle started traveling.");
        }
        public override void StopTravel()
        {
            Console.WriteLine("Bicycle stopped traveling.");
        }
        public override void GetTravelInfo()
        {
            Console.WriteLine("This is a bicycle traveling.");
        }
    }
}