using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Employee : Person
    {
        private static int employeeCount = 1;
        private int id;
        private double salary;
        private string designation;
        private DepartmentType dept;

        public enum DepartmentType
        {
            IT,
            HR,
            Marketing,
            Sales
        }

        public Employee()
        {
            id = employeeCount++;
            salary = 0;
            designation = "";
            dept = DepartmentType.IT;
        }

        public Employee(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept)
             : base(name, gender, birth, address)
        {
            id = employeeCount++;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        public new void Accept()
        {
            base.Accept();
            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());
            Console.Write("Enter Designation: ");
            designation = Console.ReadLine();
            Console.WriteLine("Select Department:");
            Console.WriteLine("1. IT");
            Console.WriteLine("2. HR");
            Console.WriteLine("3. Marketing");
            Console.WriteLine("4. Sales");
            int choice = int.Parse(Console.ReadLine());
            dept = (DepartmentType)(choice - 1);
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Designation: {designation}");
            Console.WriteLine($"Department: {dept}");
        }

        public new string ToString()
        {
            return base.ToString() + $", ID: {id}, Salary: {salary}, Designation: {designation}, Department: {dept}";


        }
    }
}





























