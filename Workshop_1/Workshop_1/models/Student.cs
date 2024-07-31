using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_1.models
{
    public class Student
    {
        //Properties
        private string? Name { get; set; }
        private int Age { get; set; }
        private bool Enrollement { get; set; }

        //Constructor
        public Student (string name, int age, bool enrollement)
        {   
            Name = name;
            Age = age;
            Enrollement = enrollement;
        }
        //Method for getting
        public string GetStudentDetails()
        {
            return $"Student Name: {Name}, Age: {Age}, Enrolled: {Enrollement}";
        }

    }
}