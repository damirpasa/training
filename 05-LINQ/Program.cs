using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LINQ
{
    class Program
    {
        static void Main()
        {
            // initialize array of employees
            var employees = new[]
            {
                new Employee("Jason", "Red", 5000M),
                new Employee("Ashley", "Green", 7600M),
                new Employee("Matthew", "Indigo", 3587.5M),
                new Employee("James", "Indigo", 4700.77M),
                new Employee("Luke", "Indigo", 6200M),
                new Employee("Jason", "Blue", 3200M),
                new Employee("Wendy", "Brown", 4236.4M)
            };

            // display all employees
            Console.WriteLine("Original array:");
            foreach(var element in employees)
            {
                Console.WriteLine(element);
            }

            // filter a range of salaries using && in a LINQ query
            var between4K6K =
                from e in employees
                where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
                select e;

            // display employees making bewtween 4000 and 6000 per month
            Console.WriteLine("\nEmployees earning in the range " + 
                $"{4000:C} - {6000:C} per month: ");
            foreach(var element in between4K6K)
            {
                Console.WriteLine(element);
            }

            // order the employees by last name, then first name with LINQ
            var nameSorted =
                from e in employees
                orderby e.LastName, e.FirstName
                select e;

            // header
            Console.WriteLine("\nFirst employee when sorted by name: ");

            // attempt to display the first result of the above LINQ query
            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("not found");
            }

            // use LINQ to select employee last names
            var lastNames =
                from e in employees
                select e.LastName;

            // use method Distinct to select unique last names
            Console.WriteLine("\nUnique employee last names:");

            foreach(var element in lastNames.Distinct())
            {
                Console.WriteLine(element);
            }

            // use LINQ to select first and last names
            var names =
                from e in employees
                select new { e.FirstName, e.LastName };

            // display full names
            Console.WriteLine("\nNames only:");
            foreach(var element in names)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            Console.Read();
        }
    }
    //Employee class with FirstName, LastName and MonthlySalary properties
    class Employee
    {
        public string FirstName { get; } // read only auto implemented property
        public string LastName { get; }
        private decimal monthlySalary; 

        // constructor initializes first name, last name and monthly salary
        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        // property that gets and sets the employee's monthly salary
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if(value >= 0M)
                {
                    monthlySalary = value;
                }
            }
        }

        // return a string containing the employee's information
        public override string ToString() =>
            $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
    }
}
