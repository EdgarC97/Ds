using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_2.models
{
    public class Company
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<Employee>? Employees = new List<Employee>();

        //Constructor
        public Company(string name, string address, List<Employee> employees)
        {
            Name = name;
            Address = address;
        }

        //Metodo para Agregar un empleado a la colección de empleados
        public void AddEmployee(Employee employee)
        {
            // Validar el objeto Employee
            Validator.ValidateEmployee(employee);

            // Agregar el libro a la colección
            Employees.Add(employee);
        }

        //Agregar empleado : Este método permitirá agregar un empleado a la listade empleados.
        public void AddEmployeeFromUserInput()
        {
            Console.WriteLine("\n=== Agregar Empleado ===");

            string name = Validator.GetValidNameFromUserInput();
            string lastName = Validator.GetValidLastNameFromUserInput();
            string idNumber = Validator.GetValidIdNumberFromUserInput();
            byte age = Validator.GetValidAgeFromUserInput();
            string position = Validator.GetValidPositionFromUserInput();
            double salary = Validator.GetValidSalaryFromUserInput();

            // Creamos un nuevo empleado con los datos validados
            Employee newEmployee = new Employee(name, lastName, idNumber, age, position, salary);

            // Validamos el nuevo libro utilizando el método ValidateBook
            Validator.ValidateEmployee(newEmployee);

            // Agregamos el libro a la lista si pasa las validaciones
            AddEmployee(newEmployee);
            Console.WriteLine("Empleado agregado exitosamente.");
        }

        //EliminarEmpleado: Este método permitirá eliminar un empleado de la lista utilizando su nombre y apellido.
        public void RemoveEmployeeFromUserInput()
        {
            Console.WriteLine("\n=== Eliminar Empleado ===");
            Console.Write("Ingrese el nombre del empleado a eliminar: ");
            string userName = Console.ReadLine() ?? "";// Lee la entrada del usuario y asigna una cadena vacía si la entrada es nula
            Console.Write("Ingrese el apellido del empleado a eliminar: ");
            string userLastName = Console.ReadLine() ?? "";//

            //Busco el empleado por nombre en la lista usando LINQ
            var employeeToRemove = Employees.FirstOrDefault(name => (name.Name ?? "").Equals(userName, StringComparison.OrdinalIgnoreCase));

            // Verifica si se encontró un empleado con el nombre y apellido proporcionado
            if (employeeToRemove == null)
            {
                Console.WriteLine("No se encontró usuario con ese nombre o apellido asociado");
                return;
            }

            // Mostramos los detalles del libro y pedimos confirmación
            Console.WriteLine("Empleado encontrado");
            Console.WriteLine(employeeToRemove.ToString());
            Console.Write("¿Está seguro de que desea eliminar este empleado? (s/n): ");
            string confirmation = Console.ReadLine()?.ToLower() ?? "";

            if (confirmation == "s")
            {
                Employees.Remove(employeeToRemove);
                Console.WriteLine("Empleado eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Eliminación cancelada.");
            }
        }

        //MostrarTodosLosEmpleados: Este método imprimirá en la consola lainformación de todos los empleados en la lista.
        public void ShowAllEmployeesInfo()
        {
            Console.WriteLine("\n=== Lista de Empleados ===\n");
            Console.WriteLine($"{"Nombre",-10}|{"Apellido",-10}|{"Número Doc.",-12}|{"Edad",-10}|{"Posicion",-12}|{"Salario",-20}|");
            Console.WriteLine(new string('-', 100));

            foreach (var employee in Employees)
            {
                employee.ShowInfo();
            }
            Console.WriteLine(new string('-', 100));
        }

        //ActualizarEmpleado: Este método permitirá actualizar un empleado de la lista utilizando su número de identificacion
        public void UpdateEmployee(string newName, string newLastName, string idNumber, byte newAge, string newPosition, double newSalary)
        {
            Employee employeeToUpdate = Employees.FirstOrDefault(e => e.IdNumber == idNumber);
            if (employeeToUpdate != null)
            {
                employeeToUpdate.Name = newName;
                employeeToUpdate.LastName = newLastName;
                employeeToUpdate.Age = newAge;
                employeeToUpdate.Position = newPosition;
                employeeToUpdate.Salary = newSalary;
            }
        }

        //BuscarEmpleado: Este método permitirá buscar un empleado por numero de documento
        public Employee? SearchEmployeeByIdNumber(string idNumber)
        {
            Console.Clear();
            var employee = Employees.FirstOrDefault(e => e.IdNumber == idNumber);

            if (employee != null)
            {
                Console.WriteLine($"Empleado con documento de identidad {idNumber}:");
                Console.WriteLine($"Nombre: {employee.Name}");
                Console.WriteLine($"Cargo: {employee.Position}");
            }
            else
            {
                Console.WriteLine($"No se encontró ningún empleado con documento de identidad {idNumber}.");
            }
            return employee;
        }

        //MostrarEmpleadosPorCargo: Este método me permitirá buscar a los empleabos pero deacuerdo a su cargo, ejemplo me debe mostrar a todos los “supervisores”
        public List<Employee>? GetEmployeesByPosition(string position)
        {
            return Employees.Where(e => e.Position == position).ToList();

        }
    }
}