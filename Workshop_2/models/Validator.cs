using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_2.models
{
    // Clase estática Validator que contiene métodos para validar datos de libros y entradas del usuario
    public static class Validator
    {
        // Método para validar un objeto Employee
        public static void ValidateEmployee(Employee employee)
        {
            // Verifica si el objeto Employee es nulo y lanza una excepción si es así
            if (employee == null)
                throw new ArgumentNullException("El nombre no puede ser nulo.");

            // Verifica si el nombre del empleado está vacío o es nulo
            if (string.IsNullOrWhiteSpace(employee.Name))
                throw new ArgumentException("El nombre del empleado no puede estar vacío.");
            // Valida el nombre utilizando el método ValidateSearchTerm
            ValidateSearchTerm(employee.Name, "nombre");

            // Verifica si el apellido del empleado está vacío o es nulo
            if (string.IsNullOrWhiteSpace(employee.LastName))
                throw new ArgumentException("El apellido del empleado no puede estar vacío.");
            // Valida el apellido utilizando el método ValidateSearchTerm
            ValidateSearchTerm(employee.LastName, "apellido");

            // Valida el numero de identificacion del empleado; si el numero es nulo, lanza una excepción
            ValidateIdNumber(employee.IdNumber ?? throw new ArgumentNullException("El documento de identificacion no puede ser nulo."));

            // Valida la edad del empleado el método ValidateYear
            ValidateAge(employee.Age);

            // Verifica si la posicion del empleado está vacía o es nula
            if (string.IsNullOrWhiteSpace(employee.Position))
                throw new ArgumentException("La posición del empleado no puede estar vacía.");
            // Valida la posición utilizando el método ValidateSearchTerm
            ValidateSearchTerm(employee.Position, "posicion");

            // Valida el precio del libro utilizando el método ValidatePrice
            ValidateSalary(employee.Salary);
        }

        // Método para validar que el numero de identificación no esté vacío
        public static void ValidateIdNumber(string idNumber)
        {
            if (string.IsNullOrWhiteSpace(idNumber))
                throw new ArgumentException("El documento de identificacion no puede estar vacío.");
        }

        // Método para validar que el año no sea negativo
        public static void ValidateAge(byte age)
        {
            if (age < 0)
                throw new ArgumentException("La edad no puede ser negativa.");
        }

        // Método para validar que el salario no sea negativo
        public static void ValidateSalary(double salary)
        {
            if (salary < 0)
                throw new ArgumentException("El salario no puede ser negativo.");
        }

        // Método para validar que un término de búsqueda no esté vacío
        public static void ValidateSearchTerm(string term, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(term))
                throw new ArgumentException($"El {fieldName} de búsqueda no puede estar vacío.");
        }

        // Método para obtener y validar el nombre desde la entrada del usuario
        public static string GetValidNameFromUserInput()
        {
            Console.Write("Nombre: ");
            string name = Console.ReadLine() ?? "";
            // Valida el nombre utilizando el método ValidateSearchTerm
            ValidateSearchTerm(name, "nombre");
            return name;
        }

        // Método para obtener y validar el apellido desde la entrada del usuario
        public static string GetValidLastNameFromUserInput()
        {
            Console.Write("Apellido: ");
            string lastName = Console.ReadLine() ?? "";
            // Valida el apellido utilizando el método ValidateSearchTerm
            ValidateSearchTerm(lastName, "apellido");
            return lastName;
        }

        // Método para obtener y validar el documento de identidad desde la entrada del usuario
        public static string GetValidIdNumberFromUserInput()
        {
            Console.Write("Numero Documento de identidad: ");
            string idNumber = Console.ReadLine() ?? "";
            // Valida el documento de identidad utilizando el método ValidateIdNumber
            ValidateIdNumber(idNumber);
            return idNumber;
        }

        // Método para obtener y validar la edad del empleado desde la entrada del usuario
        public static byte GetValidAgeFromUserInput()
        {
            Console.Write("Edad: ");
            // Intenta convertir la entrada a un número entero
            if (!byte.TryParse(Console.ReadLine(), out byte age))
            {
                throw new ArgumentException("Edad inválida.");
            }
            // Valida la edad utilizando el método ValidateAge
            ValidateAge(age);
            return age;
        }

        // Método para obtener y validar la posicion del empleado desde la entrada del usuario
        public static string GetValidPositionFromUserInput()
        {
            Console.Write("Posición: ");
            string position = Console.ReadLine() ?? "";
            // Valida la posicion del empleado utilizando el método ValidateSearchTerm
            ValidateSearchTerm(position, "posición");
            return position;
        }

        // Método para obtener y validar el salario del empleado desde la entrada del usuario
        public static double GetValidSalaryFromUserInput()
        {
            Console.Write("Precio: ");
            // Intenta convertir la entrada a un double
            if (!double.TryParse(Console.ReadLine(), out double salary))
            {
                throw new ArgumentException("Salario inválido.");
            }
            // Valida el salario utilizando el método ValidateSalary
            ValidateSalary(salary);
            return salary;
        }
    }
}
