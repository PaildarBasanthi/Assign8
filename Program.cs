using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display menu to choose employee type
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Declare variables
            int workingHours, workingDays, projectHandles, extras;
            double monthlySalary;

            // Get input based on employee type
            switch (choice)
            {
                case 1: // HR
                    Console.Write("Enter working hours: ");
                    workingHours = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    workingDays = Convert.ToInt32(Console.ReadLine());

                    // Call the CalculateSalary method for HR
                    monthlySalary = CalculateSalary(workingHours, workingDays);
                    break;

                case 2: // Admin
                    Console.Write("Enter working hours: ");
                    workingHours = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    workingDays = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter project handles: ");
                    projectHandles = Convert.ToInt32(Console.ReadLine());

                    // Call the CalculateSalary method for Admin
                    monthlySalary = CalculateSalary(workingHours, workingDays, projectHandles);
                    break;

                case 3: // Software Developer
                    Console.Write("Enter working hours: ");
                    workingHours = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    workingDays = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter project handles: ");
                    projectHandles = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter extras: ");
                    extras = Convert.ToInt32(Console.ReadLine());

                    // Call the CalculateSalary method for Software Developer
                    monthlySalary = CalculateSalary(workingHours, workingDays, projectHandles, extras);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            // Display the calculated monthly salary
            Console.WriteLine("Monthly Salary: $" + monthlySalary);

            Console.ReadLine();
        }

        // Method to calculate the salary based on employee type and input parameters
        static double CalculateSalary(int workingHours, int workingDays, int projectHandles = 0, int extras = 0)
        {
            // Calculate the monthly salary based on the given conditions
            double salary = 100 * workingHours * workingDays;  // Base salary calculation

            if (projectHandles > 0)
                salary += 3000;  // Additional amount for project handles

            if (extras > 0)
                salary += 2000;  // Additional amount for extras

            return salary;
        
    
    }
    }
}
