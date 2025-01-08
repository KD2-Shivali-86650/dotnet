using System;
using EmployeeLib;



namespace HRMS
{
    internal class Question2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Assignment 3!");
            Console.WriteLine("-------------------------------------------------------------------------");

            Employee employee1 = new Employee();
            employee1.Accept();

            Employee employee2 = new Employee("Swapnil Kanherkar", true, new Date(20, 05, 2002), 
                "Bhangaon", 50000, "Software Engineer", Employee.DepartmentType.IT);

            Manager manager1 = new Manager("Swapnil Kanherkar", true, new Date(20, 05, 2002),
                 "Bhangaon", 50000, Employee.DepartmentType.Marketing, 10000);

            Supervisor supervisor1 = new Supervisor("Swapnil Kanherkar", true, new Date(20, 05, 2002),
                 "Bhangaon", 50000, Employee.DepartmentType.HR, 10000);

            WageEmp wageEmp1 = new WageEmp("Swapnil Kanherkar", true, new Date(20, 05, 2002),
                 "Bhangaon", 20000, 10000);



            Console.WriteLine("\nEmployee 1: ");
            employee1.Print();
            Console.WriteLine(employee1.ToString());
            Console.WriteLine("-------------------------------------------------------------------------");



            Console.WriteLine("\nEmployee 2: ");
            employee2.Print();
            Console.WriteLine(employee2.ToString());
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine("\nManager 1:");
            manager1.Print();
            Console.WriteLine(manager1.ToString());
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine("\nSupervisor 1:");
            supervisor1.Print();
            Console.WriteLine(supervisor1.ToString());
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine("\nWage Employee 1:");
            wageEmp1.Print();
            Console.WriteLine(wageEmp1.ToString());
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine("Assignment Done!");
            Console.ReadLine();




        }
    }
}
