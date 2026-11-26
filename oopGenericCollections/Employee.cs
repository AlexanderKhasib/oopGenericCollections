using System;
using System.Collections.Generic;
using System.Text;
namespace oopGenericCollections
{
    public class Employee
    {
        // Default propery values for Employe class
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; } 
        public string Gender { get; set; }

        // Constructor for Employee class
        public Employee(int id, string name, int salary, string gender)
        {
            Id = id;
            Salary = salary;
            Name = name;
            Gender = gender;
        }
    }
}
