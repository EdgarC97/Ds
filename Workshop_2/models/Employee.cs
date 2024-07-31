using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_2.models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? IdNumber { get; set; }
        public byte Age { get; set; }
        public string? Position { get; set; }
        public double Salary { get; set; }

        //Constructor
        public Employee(string name, string lastName, string idNumber, byte age, string position, double salary)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            IdNumber = idNumber;
            Age = age;
            Position = position;
            Salary = salary;
        }

        private double CalculateBonus()
        {
            //Este metodo calculara la bonificacion del 10% sobre el salario del empleado
            double bonus = Salary * 0.1;
            var finalSalary = Salary + bonus;
            return finalSalary;
        }

        //Este método imprimirá en la consola la información del empleado 
        public void ShowInfo()
        {

            Console.WriteLine($"{Name,-10}|{LastName,-10}|{IdNumber,-12}|{Age,-10}|{Position,-12}|{Salary,-20:C}|{CalculateBonus(),-20:C}  |");
            
        }

    }
}