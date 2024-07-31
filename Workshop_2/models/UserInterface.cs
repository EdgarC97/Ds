using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop_2.models;


public class UserInterface
{
    // Método principal que ejecuta el menú de la aplicación
        private static  Company company = new Company();
    public static void Run()
    {
        bool exit = false; // Bandera para controlar la salida del bucle
        while (!exit)
        {
            // Limpio la consola para una presentación más limpia del menú
            Console.Clear();
            // Muestro el menú de opciones al usuario
            Console.WriteLine("\n=== Sistema de Gestión de Empleados ===");
            Console.WriteLine("1. Agregar empleado");
            Console.WriteLine("2. Eliminar empleado");
            Console.WriteLine("3. Mostrar empleados");
            Console.WriteLine("4. Actualizar empleado");
            Console.WriteLine("5. Buscar empleado por numero de documento");
            Console.WriteLine("6. Mostrar empleados por cargo");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            // Leo la opción ingresada por el usuario y valida que sea un número
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                Console.ReadKey();
                continue;
            }

            try
            {
                // Ejecuto la acción correspondiente según la opción seleccionada
                switch (choice)
                {
                    case 1:
                        company.AddEmployeeFromUserInput();
                        break;
                    case 2:
                        company.DeleteEmployeeFromUserInput();
                        break;
                    case 3:
                        company.ShowAllEmployeesInfo();
                        break;
                    case 4:
                        company.UpdateEmployee();
                        break;
                    case 5:
                        company.SearchEmployeeByIdNumber();
                        break;
                    case 6:
                        company.ShowEmployeesByPosition();
                        break;
                    case 7:
                        exit = true; // Establezco la bandera exit a true para salir del bucle
                        Console.WriteLine("Gracias por usar el Sistema de Gestión de Empleados. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo."); // Mensaje para opciones no válidas
                        break;
                }
            }
            catch (Exception ex)
            {
                // Capturo y muestra cualquier excepción que ocurra durante la ejecución
                Console.WriteLine($"Error: {ex.Message}");
            }

            if (!exit)
            {
                // Solicito al usuario que presione una tecla para continuar si no se ha salido
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
