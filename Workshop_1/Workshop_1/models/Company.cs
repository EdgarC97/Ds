using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Company
    {
        private List<Employee> companies = new List<Employee>();

        //Agregar empleados a la empresa
        public void AddEmployee(Employee employee)
        {
            companies.Add(employee);
        }
        //Buscar empleados por nombre
        public void FindEmployeeByName(string name)
        {
            var foundEmployees = companies.Where(e => e.Name == name).ToList();
            if (foundEmployees.Any())
            {
                Console.WriteLine($"Se han encontrado {foundEmployees.Count} empleados con el nombre {name}:");
                foreach (var employee in foundEmployees)
                {
                    Console.WriteLine($"{employee.Name} - {employee.Charge}");
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron empleados con el nombre {name}");
            }
        }
    }
}