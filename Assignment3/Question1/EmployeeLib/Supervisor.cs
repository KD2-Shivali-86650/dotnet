using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Supervisor : Employee
    {
        private int subordinates;

        public Supervisor() : base()
        {
            Designation = "Supervisor";
            subordinates = 0;
        }

        public Supervisor(string name, bool gender, Date birth, string address, double salary, DepartmentType dept, int subordinates)
            : base(name, gender, birth, address, salary, "Supervisor", dept)
        {
            this.subordinates = subordinates;
        }

        public int Subordinates
        {
            get { return subordinates; }
            set { subordinates = value; }
        }

        public new void Accept()
        {
            base.Accept();
            Console.Write("Enter numner of Subordinates: ");
            subordinates = int.Parse(Console.ReadLine());
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Number of Subordinates: {subordinates}");
        }

        public new string ToString()
        {
            return base.ToString() + $", Number of Subordinates: {subordinates}";
        }
    }

	}

