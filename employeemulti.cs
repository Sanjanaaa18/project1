using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class employeemulti:Person
    {
        public int employeemultiID { get; set; }
        public string? role {  get; set; }// ?means nullable when you have joined the company but still doesnt have any role
        public string? email { get; set; }
        public double salary { get; set; }

        public employeemulti() // Default constructor
        {
        }
        public employeemulti(int id, string name, string city, int age, int employeemultiID, string role, string email, double salary) // Parameterized constructor
            : base(id, name, city, age)
        {
            this.employeemultiID = employeemultiID;
            this.role = role;
            this.email = email;
            this.salary = salary;
        }
        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {employeemultiID}");
            Console.WriteLine($"Role: {role}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Salary: {salary}");
        }
    }

}
