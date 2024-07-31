using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public abstract class Transport
    {
        public abstract void StartTravel();

        public abstract void StopTravel();

        public abstract void GetTravelInfo();
    }
}