Sistema de Gestión de Empleados
Imagina que has sido contratado por una empresa de software para desarrollar un sistema de
gestión de empleados. Este sistema permitirá registrar y gestionar la información de los empleados
de la empresa.
Objetivos
• Practicar los conceptos de Programación Orientada a Objetos (POO) en C#, como clases,
objetos, encapsulación, y métodos.
• Reforzar el uso de un sistema de control de versiones
• Generar el diagrama de clases del programa
Requisitos del Sistema
1. Clase Empleado:
o Propiedades:
▪ Id (Guid)
▪ Nombre (string)
▪ Apellido (string)
▪ NumeroDeIdentificacion (string)
▪ Edad (byte)
▪ Posicion (string)
▪ Salario (double)
o Métodos:
▪ CalcularBonificacion: Este método calculará una bonificación del 10%
sobre el salario del empleado.(método privado)
▪ MostrarInformacion: Este método imprimirá en la consola la información
del empleado (nombre completo, edad, posición y salario pero con la
bonificacion) (método publico).
2. Clase Empresa:
o Propiedades:
▪ Nombre (string)
▪ Direccion (string)
▪ ListaEmpleados (List<Empleado>)
o Métodos:
▪ AgregarEmpleado: Este método permitirá agregar un empleado a la lista
de empleados.
▪ EliminarEmpleado: Este método permitirá eliminar un empleado de la lista
utilizando su nombre y apellido.
▪ MostrarTodosLosEmpleados: Este método imprimirá en la consola la
información de todos los empleados en la lista.
▪ ActualizarEmpleado: Este método permitirá actualizar un empleado de la
lista utilizando su número de identificacion.
▪ BuscarEmpleado: Este método permitirá buscar un empleado por numero
de documento
▪ MostrarEmpleadosPorCargo: Este método me permitirá buscar a los
empleabos pero deacuerdo a su cargo, ejemplo me debe mostrar a todos
los “supervisores”