using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class WageEmp : Employee
    {
		private int hours;
		private int rate;

        public WageEmp() : base() 
        {
			Designation = "Wage";
			hours = 0;
			rate = 0;
        }

        public WageEmp(string name, bool gender, Date birth, string address, int hours, int rate) 
			: base(name, gender, birth, address,hours * rate,"Wage", DepartmentType.IT)
        {
			this.hours = hours;
			this.rate = rate;	
        }

        public int Rate
		{
			get { return rate; }
			set { rate = value; }
		}

		public int Hours
		{
			get { return hours; }
			set { hours = value; }
		}

		public new void Accept()
		{
			base.Accept();
            Console.Write("Enter Hours worked: ");
			hours = int.Parse(Console.ReadLine());
            Console.Write("Enter rate per Hour: ");
			rate = int.Parse(Console.ReadLine());

		}

		public new void Print()
		{
			base.Print();	
			Console.WriteLine($"Hours Worked: {hours}");
			Console.WriteLine($"Rate per Hour: {rate}");
		}

		public new string ToString()
		{
			return base.ToString() + $", Hours Worked: {hours}, Rate per Hour: {rate}";
		}
	}
}
