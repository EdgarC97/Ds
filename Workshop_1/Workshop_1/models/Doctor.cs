using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Doctor : Personal
    {
        public string? Hospital { get; set; }

        public Doctor(string name, int baseSalary, double pensionPercentage, double healthPercentage, string hospital)
            : base(name, baseSalary, pensionPercentage, healthPercentage)
        {
            Hospital = hospital;
        }
        
        public override void ShowPersonalDetails()
        {
            Console.WriteLine($"===Doctor Details===");
            Console.WriteLine($"Name: {Name}, Base Salary: {BaseSalary:C}, Pension Percentage: {PensionPercentage}%, Health Percentage: {HealthPercentage}%, Hospital: {Hospital}");
        }
    }
}