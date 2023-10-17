using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"Sum: {numbers.Sum()}");

            //TODO: Print the Average of numbers
            Console.WriteLine($"Average: {numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console
            var orderedNumbers = numbers.OrderBy(x => x).ToArray();
            Console.WriteLine("Ordered:");
            foreach(var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }

            //TODO: Order numbers in descending order and print to the console
            var decendNumbers = numbers.OrderByDescending(x => x).ToArray();
            Console.WriteLine("Descending:");
            foreach (var number in decendNumbers)
            {
                Console.WriteLine(number);
            }


            //TODO: Print to the console only the numbers greater than 6
            var numsAboveSix = numbers.Where(number => number > 6).ToArray();
            Console.WriteLine("Greater than 6:");
            foreach(var number in numsAboveSix)
            {
                Console.WriteLine(number);
            }

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var numsBelowFour = numbers.Where(number => number < 4).ToArray();
            Console.WriteLine("Less than 4:");
            foreach (var number in numsBelowFour)
            {
                Console.WriteLine(number);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[3] = 20;
            var numsAfterAge = numbers.OrderByDescending(x => x).ToArray();
            Console.WriteLine("Descending:");
            foreach (var number in numsAfterAge)
            {
                Console.WriteLine(number);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Employees starting with 'C' and 'S'");
            var filteredEmp = employees.Where(emp => emp.FirstName.StartsWith("C") || emp.FirstName.StartsWith("S")).OrderBy(emp => emp.FirstName);
            foreach(var Employee in filteredEmp)
            {
                Console.WriteLine(Employee.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Employee name and Age:");
            var nameAndAge = employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName);
            foreach (var Employee in nameAndAge)
            {
                
                Console.WriteLine($"{Employee.FullName} | {Employee.Age}");
            }


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if
            //their YOE is less than or equal to 10 AND Age is greater than 35.
            var yoeEmployees = employees.Where(emp => emp.YearsOfExperience <= 10 && emp.Age > 35);

            int sumYearsOfExperience = yoeEmployees.Sum(emp => emp.YearsOfExperience);
            double averageYearsOfExperience = yoeEmployees.Average(emp => emp.YearsOfExperience);

            Console.WriteLine($"Sum of Years of Experience: {sumYearsOfExperience}");
            Console.WriteLine($"Average of Years of Experience: {averageYearsOfExperience}");



            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("ADD EMPLOYEE(NEW LIST):");
            Employee newEmployee = new Employee("Sara", "Jadidi", 20, 2);
            employees.Insert(employees.Count, newEmployee);

            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, Age {employee.Age}, Years of Experience: {employee.YearsOfExperience}");
            }
            

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
