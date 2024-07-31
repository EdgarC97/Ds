using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Administrative : Personal
    {
        public string? Basement { get; set; }

        public Administrative(string name, int baseSalary, double pensionPercentage, double healthPercentage, string basement) : base(name, baseSalary, pensionPercentage, healthPercentage)
        {
            Basement = basement;
        }

        public override void ShowPersonalDetails()
        {
            Console.WriteLine($"===Administrative Details===");
            Console.WriteLine($"Name: {Name}, Base Salary: {BaseSalary:C}, Pension Percentage: {PensionPercentage}%, Health Percentage: {HealthPercentage}%, Basement: {Basement}");
        }
    }
}