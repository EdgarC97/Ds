using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Personal
    {
        public string? Name { get; set; }
        public int BaseSalary { get; set; }
        public double PensionPercentage { get; set; }
        public double HealthPercentage { get; set; }

        public Personal(string name, int baseSalary, double pensionPercentage, double healthPercentage)
        {
            Name = name;
            BaseSalary = baseSalary;
            PensionPercentage = pensionPercentage;
            HealthPercentage = healthPercentage;
        }

        public double CalculateSalaryDeductions()
        {
            double pensionDeduction = BaseSalary * (PensionPercentage / 100);
            double healthDeduction = BaseSalary * (HealthPercentage / 100);
            return pensionDeduction + healthDeduction;
        }
        public double CalculateNetSalary()
        {
            double salaryDeductions = CalculateSalaryDeductions();
            return BaseSalary - salaryDeductions;
        }
        public void ShowSalaryDetail()
        {
            Console.WriteLine($"===Salary Details===");
            Console.WriteLine($"Base Salary: {BaseSalary:C}");
            Console.WriteLine($"El total de deducciones es --> {CalculateSalaryDeductions():C}");
            Console.WriteLine($"Net Salary: {CalculateNetSalary():C}");
        }
        public virtual void ShowPersonalDetails()
        {
            Console.WriteLine($"Name: {Name}, Base Salary: {BaseSalary:C}, Pension Percentage: {PensionPercentage}%, Health Percentage: {HealthPercentage}%");
        }
    }
}