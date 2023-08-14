using Empresa.Entities;
using System;
using System.Globalization;

namespace Empresa 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> employees = new List<Employee>();

            
            
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{n} data: ");
                Console.Write("Outsourced? (s/n): ");
                char r = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (r == 's' || r == 'S')
                {
                    Console.WriteLine("Additional charge: ");
                     double additional = double.Parse(Console.ReadLine());

                    employees.Add(new OutsourcedEmployee (name,hours, valuePerHour, additional));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine("");
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.name + " - $"+ e.payment());
            }

        }
    }
}