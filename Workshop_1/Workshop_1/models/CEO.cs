using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class CEO : Employee_1
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("CEO starts working");
        }
    }
}