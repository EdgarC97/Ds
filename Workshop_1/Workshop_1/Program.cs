using System.Security.Cryptography.X509Certificates;
using Workshop_1.models;
public class Program_1
{
    static void Main(string[] args)
    {
//6) Crear una clase Habitacion y una clase Reserva. La clase Habitacion debe tener propiedades como número de habitación y tipo. La clase Reserva debe tener propiedades como fecha de inicio, fecha de fin y la habitación reservada.
        //CLASS STUDENT
        //Student list
        List<Student> students = new List<Student>();
        //Create a new student instance
        Student student1 = new Student("PEPE", 19, true);
        Student student2 = new Student("JOACO", 31, true);
        //Add student to list
        students.Add(student1);
        students.Add(student2);
        //Print list of students
        foreach (var student in students)
        {
            Console.WriteLine(student.GetStudentDetails());
        }
//7) Crear una clase Prenda con propiedades para nombre, talla y precio. Crear una clase Tienda que gestione una colección de prendas y permita agregar y buscar prendas.
        //CLASS STORE
        Garment garment = new Garment("CAMISA", "XL", 50000);
        Store store = new Store();

        store.AddGarment(garment);
        store.ShowGarmentList();

//8) Crear una clase Empleado con propiedades para nombre, cargo y salario. Crear una clase Empresa que gestione una colección de empleados y permita agregar y buscar empleados.
        //CLASS EMPLOYEE
        Employee employee1 = new Employee("JOACO", "Developer", 40000);
        Company company = new Company();

        company.AddEmployee(employee1);
        company.FindEmployeeByName("JOACO");
//9) Crear una clase Curso con propiedades para nombre, código y duración. Crear una clase Escuela que gestione una colección de cursos y permita agregar y buscar cursos. 
        //CLASS COURSE
        School school = new School();

        school.AddCourse(new Course("Mathematics", "MAT101", 60));
        school.AddCourse(new Course("Physics", "PHY201", 45));
        school.AddCourse(new Course("Programming", "PRG301", 90));

        string searchName = "PHYSICS";
        school.FindAndDisplayCoursesByName(searchName);
//10) Crear una clase base Figura con un método CalcularArea. Crear clases derivadas Circulo y Rectangulo que sobrescriban el método CalcularArea.
        //CLASS RECTANGLE
        Rectangle rectangle = new Rectangle();
        rectangle.CalculateArea(5,15);
        //CLASS CIRCLE
        Circle circle = new Circle();
        circle.CalculateArea(5);

//11) Crear una clase base Vehiculo con un método Arrancar. Crear clases derivadas Coche y Moto que sobrescriban el método Arrancar.
        //CLASS CAR
        Car car = new Car();
        car.Start();
        //CLASS MOTORBIKE
        MotorBike motorBike = new MotorBike();
        motorBike.Start();

//12.Crear una clase base Empleado con un método Trabajar. Crear clases derivadas Desarrollador y Gerente que sobrescriban el método Trabajar.
        //CLASS DEVELOPER
        Developer developer = new Developer();
        developer.Work();
        //CLASS CEO
        CEO ceo = new CEO();
        ceo.Work();

//13) Crear una jerarquía de clases para representar diferentes tipos de transporte (coche, bicicleta, autobús). Implementar métodos para iniciar el viaje, detener el viaje y obtener detalles del viaje.
        //CLASS CAR_1
        Car_1 car_1 = new Car_1();
        car_1.StartTravel();
        car_1.StopTravel();
        car_1.GetTravelInfo();
        //CLASS BICYCLE
        Bicycle bicycle = new Bicycle();
        bicycle.StartTravel();
        bicycle.StopTravel();
        bicycle.GetTravelInfo();
        //CLASS BUS
        Bus bus = new Bus();
        bus.StartTravel();
        bus.StopTravel();
        bus.GetTravelInfo();

//14) Crear una jerarquía de clases para representar diferentes tipos de productos (Electrónico, Ropa, Alimento). Implementar métodos para calcular el precio final (con impuestos) y mostrar los detalles del producto. 
        //CLASS ELECTRONIC_PRODUCT
        Electronic electronicProduct = new Electronic("iPhone X", 5000000, 3, 19,"Apple");
        electronicProduct.ShowProductDetail();
        electronicProduct.CalculateFinalPrice();
        //CLASS CLOTHING_PRODUCT
        Clothing clothingProduct = new Clothing("T-Shirt", 90000, 20, 15,"EEUU");
        clothingProduct.ShowProductDetail();
        clothingProduct.CalculateFinalPrice();
        //CLASS FOOD_PRODUCT
        Food foodProduct = new Food("Apple", 3000, 10, 7,"Del valle");
        foodProduct.ShowProductDetail();
        foodProduct.CalculateFinalPrice();

//15) Crear una jerarquía de clases para representar diferentes tipos de personal (Doctor, Enfermera, Administrativo). Implementar métodos para calcular el salario  y mostrar los detalles del personal. 

        //CLASS DOCTOR
        Doctor doctor = new Doctor("Dr. Juanito", 5000000, 3.5, 2.5,"Hospital Saint Denise");
        doctor.ShowPersonalDetails();
        doctor.ShowSalaryDetail();
        //CLASS NURSE
        Nurse nurse = new Nurse("JUANA", 3500000, 2.5, 2.5,"Hospital San Francisco");
        nurse.ShowPersonalDetails();
        nurse.ShowSalaryDetail();
        //CLASS ADMINISTRATIVE
        Administrative administrative = new Administrative("Diana", 4500000, 5.5, 2.5,"Hospital La Paz");
        administrative.ShowPersonalDetails();
        administrative.ShowSalaryDetail();

        //Abstract class
        HumanBody person1 = new HumanBody();
        Console.WriteLine("=====Creando humano=====");
        person1.Breathe();
        person1.Move();
        person1.Eat();
        
        //Static class Lowercase
        Console.WriteLine("=====Creando clase estática=====");
        Console.WriteLine("Ingresa palabra que contengan mayusculas");
        string? input = Console.ReadLine();
        Console.WriteLine(Lower.ToLowerCase(input));
    }   
}