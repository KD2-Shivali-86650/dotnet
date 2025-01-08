using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Manager : Employee
    {
        private double bonus;

        public Manager()
            : base()
        {
            Designation = "Manager";
            bonus = 0;
        }

        public Manager(string name, bool gender, Date birth, string address, double salary, DepartmentType dept, double bonus)
        : base(name, gender, birth, address, salary, "Manager", dept)
        {
            this.bonus = bonus;
        }

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public new void Accept()
        {
            base.Accept();
            Console.Write("Enter Bonus: ");
            bonus = double.Parse(Console.ReadLine());

        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Bonus: {bonus}");
        }

        public new string ToString()
        {
            return base.ToString() + $", Bonus: {bonus} ";
        }


    }
}
