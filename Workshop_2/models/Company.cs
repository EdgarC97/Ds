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
        public List<Employee> Employees { get; set; } = new List<Employee>()
        {
            new Employee ("Pepe","Quintana","123456789",30,"Supervisor",3200000),
            new Employee ("Juan","Delgado","1234567890",33,"Supervisor",3300000),
            new Employee ("Joaco","Guillen","987654321",25,"Cajero",2200000)
        };


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
            Console.Clear();
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
        public void DeleteEmployeeFromUserInput()
        {
            Console.Clear();
            Console.WriteLine("\n=== Eliminar Empleado ===");
            Console.Write("Ingrese el nombre del empleado a eliminar: ");
            string userName = Console.ReadLine() ?? "";// Lee la entrada del usuario y asigna una cadena vacía si la entrada es nula

            //Busco el empleado por nombre en la lista usando LINQ
            var employeeToRemove = Employees.FirstOrDefault(name => (name.Name ?? "").Equals(userName, StringComparison.OrdinalIgnoreCase));

            // Verifica si se encontró un empleado con el nombre y apellido proporcionado
            if (employeeToRemove == null)
            {
                Console.WriteLine("No se encontró usuario con ese nombre asociado");
                return;
            }

            // Mostramos los detalles del libro y pedimos confirmación
            Console.WriteLine($"Empleado {userName} encontrado");
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
            Console.Clear();
            Console.WriteLine("\n=== Lista de Empleados ===\n");
            Console.WriteLine($"{"Nombre",-10}|{"Apellido",-10}|{"Número Doc.",-12}|{"Edad",-10}|{"Posicion",-12}|{"Salario",-20}|{"Salario + Bonificacion",-20}|");
            Console.WriteLine(new string('-', 103));

            foreach (var employee in Employees)
            {
                employee.ShowInfo();
            }
            Console.WriteLine(new string('-', 103));
        }

        //ActualizarEmpleado: Este método permitirá actualizar un empleado de la lista utilizando su número de identificacion
        public void UpdateEmployee()
        {
            Console.Clear();
            Console.WriteLine("\n=== Actualizar Empleado ===");
            Console.Write("Ingrese el número de documento del empleado a actualizar --> ");
            string idNumber = Console.ReadLine() ?? "";

            var employeeToUpdate = Employees.FirstOrDefault(e => e.IdNumber == idNumber);

            if (employeeToUpdate == null)
            {
                Console.WriteLine($"No se encontró ningún empleado con documento de identidad {idNumber}.");
                return;
            }

            Console.WriteLine($"\n{"Nombre",-10}|{"Apellido",-10}|{"Número Doc.",-12}|{"Edad",-10}|{"Posicion",-12}|{"Salario",-20}|{"Salario + Bonificacion",-20}|");
            Console.WriteLine(new string('-', 103));
            employeeToUpdate.ShowInfo();

            Console.WriteLine("\nIngrese los nuevos datos (presione Enter sin escribir nada para mantener el valor actual):");

            // Nombre
            try
            {
                string newName = Validator.GetValidNameFromUserInput();
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    employeeToUpdate.Name = newName;
                }
            }
            catch (ArgumentException)
            {
                // El usuario presionó Enter sin ingresar un nombre, mantenemos el nombre actual
            }

            // Apellido
            try
            {
                string newLastName = Validator.GetValidLastNameFromUserInput();
                if (!string.IsNullOrWhiteSpace(newLastName))
                {
                    employeeToUpdate.LastName = newLastName;
                }
            }
            catch (ArgumentException)
            {
                // El usuario presionó Enter sin ingresar un apellido, mantenemos el apellido actual
            }

            // Edad
            try
            {
                byte newAge = Validator.GetValidAgeFromUserInput();
                employeeToUpdate.Age = newAge;
            }
            catch (ArgumentException)
            {
                // El usuario ingresó una edad inválida o presionó Enter, mantenemos la edad actual
            }

            // Posición
            try
            {
                string newPosition = Validator.GetValidPositionFromUserInput();
                if (!string.IsNullOrWhiteSpace(newPosition))
                {
                    employeeToUpdate.Position = newPosition;
                }
            }
            catch (ArgumentException)
            {
                // El usuario presionó Enter sin ingresar una posición, mantenemos la posición actual
            }

            // Salario
            try
            {
                double newSalary = Validator.GetValidSalaryFromUserInput();
                employeeToUpdate.Salary = newSalary;
            }
            catch (ArgumentException)
            {
                // El usuario ingresó un salario inválido o presionó Enter, mantenemos el salario actual
            }

            Console.WriteLine("\nEmpleado actualizado exitosamente.");
            Console.WriteLine("\nDatos actualizados del empleado:");
            Console.WriteLine($"\n{"Nombre",-10}|{"Apellido",-10}|{"Número Doc.",-12}|{"Edad",-10}|{"Posicion",-12}|{"Salario",-20}|{"Salario + Bonificacion",-20}|");
            Console.WriteLine(new string('-', 103));
            employeeToUpdate.ShowInfo();
        }

        //BuscarEmpleado: Este método permitirá buscar un empleado por numero de documento
        public void SearchEmployeeByIdNumber()
        {
            Console.Clear();
            Console.Write("Ingrese el número de documento del empleado a buscar: ");
            string idNumber = Console.ReadLine() ?? "";

            var employee = Employees.FirstOrDefault(e => e.IdNumber == idNumber);

            Console.WriteLine($"\n=== Empleados con documento de identidad : {idNumber} ===\n");
            if (employee != null)
            {
                employee.ShowInfo();
            }
            else
            {
                Console.WriteLine($"No se encontró ningún empleado con documento de identidad {idNumber}.");
            }
        }

        //MostrarEmpleadosPorCargo: Este método me permitirá buscar a los empleabos pero deacuerdo a su cargo, ejemplo me debe mostrar a todos los “supervisores”
        public void ShowEmployeesByPosition()
        {
            Console.Clear();
            Console.Write("Ingrese el cargo de los empleados a mostrar: ");
            string position = Console.ReadLine() ?? "";

            var employeesByPosition = Employees.Where(e => (e.Position ?? "").Equals(position, StringComparison.OrdinalIgnoreCase)).ToList();
            if (employeesByPosition.Any())
            {
                Console.WriteLine($"\n=== Empleados con cargo: {position} ===\n");
                Console.WriteLine($"{"Nombre",-10}|{"Apellido",-10}|{"Número Doc.",-12}|{"Edad",-10}|{"Posicion",-12}|{"Salario",-20}|{"Salario + Bonificacion",-20}|");
                Console.WriteLine(new string('-', 103));
                foreach (var employee in employeesByPosition)
                {
                    employee.ShowInfo();
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron empleados con el cargo: {position}");
            }
        }
    }
}