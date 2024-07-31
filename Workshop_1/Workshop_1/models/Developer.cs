using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public  class Developer : Employee_1
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Developer is working...");
        }
    }
}