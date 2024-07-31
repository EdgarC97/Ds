
using Workshop_2.models;

public class Program
{
    static void Main(string[] args)
    {   

        new Employee ("Pepe","Quintana","123456789",30,"supervisor",3200000);
        new Employee ("Joaco","Guillen","987654321",25,"cajero",2200000);

        new Company("ARENAS","CALLE FALSA 123", new List<Employee>());

        
        
    }
}