using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Employee
    {
        public string? Name { set; get; }
        public string? Charge { set; get; }
        private decimal Salary { set; get; }

        public Employee(string name, string charge, decimal salary)
        {
            Name = name;
            Charge = charge;
            Salary = salary;
        }
    }
}