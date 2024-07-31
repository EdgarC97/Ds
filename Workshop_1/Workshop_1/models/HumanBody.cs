using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class HumanBody : Human
    {
        public string? Heart { get; set; }
        public string? Legs { get; set; }
        public string? Mouth { get; set; }

        public override void Breathe()
        {
            Console.WriteLine("HumanBody breathing");
        }
        public override void Move()
        {
            Console.WriteLine("HumanBody moving");
        }
        public override void Eat()
        {
            Console.WriteLine("HumanBody eating");
        }
    }
}