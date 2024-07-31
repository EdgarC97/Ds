using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Course
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int Duration { get; set; }

        public Course(string name, string code, int duration)
        {
            Name = name;
            Code = code;
            Duration = duration;
        }
    }
}