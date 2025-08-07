using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Take input as student name, 5subject marks and output the total marks and average marks
namespace project1
{
    internal class sampleproblem
    {
        public sampleproblem()
        {

        }
        public void sample()
        {
            Console.WriteLine("Enter student name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter marks for 5 subjects (separated by space):");
            string[] marksInput = Console.ReadLine().Split(' ');
            int[] marks = new int[5];
            for (int i = 0; i < marksInput.Length; i++)
            {
                marks[i] = Convert.ToInt32(marksInput[i]);
            }
            int total = marks.Sum();
            double average = marks.Average();
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average}");
        }
    }
        
}
