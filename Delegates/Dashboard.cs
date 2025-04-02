using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Dashboard
    {
        public delegate bool ILLegiableSalary(Employee employee);

        public void ProcessEmployees(Employee[] employees, string title, ILLegiableSalary iLLegiableSalary) 
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var emp in employees)
            {
                if (iLLegiableSalary(emp))
                {
                    Console.WriteLine($"{emp.Id} | {emp.Name}| {emp.Geneder}| {emp.TotalSalary}");
                }

            }

            Console.WriteLine("\n\n");

        }

    }
}
