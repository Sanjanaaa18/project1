using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Person
    {
        //auto-implemented properties for Person class
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        

        public Person() // Default constructor
        {
        }
        public Person(int id, string name,  string city, int age) // Parameterized constructor
        {
            Id = id;
            Name = name;
            City = city;
            Age = age;
        }
        // Method to display person details
        public void DisplayDetails()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Age: {Age}");
        }
        public string GetDetails()
        {
            return $"Id: {Id}, Name: {Name}, City: {City}, Age: {Age}";
        }
        // Method to update person details
        public void UpdateDetails(int id, string name, string city, int age)
        {
            Id = id;
            Name = name;
            City = city;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, City: {City}, Age: {Age}";
        }

    }
}
