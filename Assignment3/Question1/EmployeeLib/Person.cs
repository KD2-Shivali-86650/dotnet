using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Person
    {
        private string name;
        private bool gender;
        private Date birth;
        private string address;

        public Person()
        {
            name = "";
            gender = true;
            birth = new Date();
            address = "";
        }
        public Person(string name, bool gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Date Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Age
        {

            get { return Date.DifferenceInYears(birth, new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year)); }
        }

        public void Accept()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Gender (true for male, false for female): ");
            gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Birth: ");
            birth.AcceptDate();
            Console.Write("Enter Address: ");
            address = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Gender: {(gender ? "Male" : "Female")}");
            Console.WriteLine($"Date of birth: {birth.ToString()}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {address}");
        }

        public override string ToString()
        {
            return $"Name: {name}, Gender: {(gender ? "Male" : "Female")}, Date of Birth: {birth.ToString()}, Age: {Age}, Address: {address}";
        }
    }

    }
