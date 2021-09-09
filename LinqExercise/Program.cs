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
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers

            Console.WriteLine(numbers.Sum());
            Separate();
            Console.WriteLine(numbers.Average());
            Separate();

            //Order numbers in ascending order and decsending order. Print each to console.

            var temp = numbers.OrderBy(x => x);
            foreach (int number in temp)
            {
                Console.WriteLine(number);
            }

            Separate();

            temp = numbers.OrderByDescending(x => x);
            foreach (int number in temp)
            {
                Console.WriteLine(number);
            }

            Separate();

            //Print to the console only the numbers greater than 6

            var temp2 = numbers.Where(x => x >= 6);
            foreach (int number in temp2)
            {
                Console.WriteLine(number);
            }

            Separate();

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            temp2 = numbers.Take(4);
            foreach (int number in temp2)
            {
                Console.WriteLine(number);
            }

            Separate();
            //Change the value at index 4 to your age, then print the numbers in decsending order

            //temp2 = numbers.Take(3).Append(32).OrderByDescending(x => x);
            var temp3 = temp2.ToList();
            temp3[3] = 32;
            temp3 = temp3.OrderByDescending(x => x).ToList();
            
            foreach (int number in temp3)
            {
                Console.WriteLine(number);
            }

            Separate();

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.

            
            
            foreach(Employee employee in employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName))
            {
                Console.WriteLine(employee.FullName);
            }

            Separate();

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.

            foreach(Employee employee in employees.Where(x => x.Age >= 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName))
            {
                Console.WriteLine($"{employee.FullName} /// {employee.Age}");
            }

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35

            Separate();

            Console.WriteLine(employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Sum(x => x.YearsOfExperience));
            Console.WriteLine(employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Average(x => x.YearsOfExperience));

            Separate();



            //Add an employee to the end of the list without using employees.Add()

            employees.Append(new Employee() { FirstName = "Chris", LastName = "Bradley", Age = 32, YearsOfExperience = 0 });


            Console.WriteLine();

            Console.ReadLine();
        }

        public static void Separate()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
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
