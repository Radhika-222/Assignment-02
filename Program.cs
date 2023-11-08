using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Gender (M/F):");
            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary:");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Joining (MM/DD/YYYY):");
            DateTime doj = DateTime.Parse(Console.ReadLine());

            // Calculate tax based on salary
            double taxRate = salary > 90000 ? 0.30 : 0.15;
            double taxAmount = salary * taxRate;

            // Display employee details
            Console.WriteLine("\nID\tEmployee Name\tEmployee Gender\tEmployee Salary\tDOJ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t{salary:C}\t\t{doj:MM/dd/yyyy}");
            Console.WriteLine("\nYou have to pay: " + taxAmount.ToString("C"));

            Console.ReadLine(); 
        }
    }
}


       
