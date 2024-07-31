using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public abstract class Human
    {
        public string? Soul { get; set; }
        public string? Conscience { get; set; }


        public abstract void Breathe();
        public abstract void Move();
        public abstract void Eat();
    }
}