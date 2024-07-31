using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Booking
    {
        private DateOnly StartDate { get; set; }
        private DateOnly EndDate { get; set; }
        private Room? Room { get; set; }

    }

}