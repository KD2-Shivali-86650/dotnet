using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Question1
{
    struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student()
        {
            name = string.Empty;
            gender = true;
            age = 0;
            std = 0;
            div = 'A';
            marks = 0.0;
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
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
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Std
        {
            get { return std; }
            set { std = value; }
        }
        public char Div
        {
            get { return div; }
            set { div = value; }
        }
        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }



        public void AcceptDetails()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Gender (true for Male, false for Female):");
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Standard: ");
            std = int.Parse(Console.ReadLine());

            Console.Write("Enter Division: ");
            div = char.Parse(Console.ReadLine());

            Console.Write("Enter Marks: ");
            marks = double.Parse(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + (gender ? "Male" : "Female"));
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Standard: " + std);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Marks: " + marks);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine("Details of Student 1 (Default Constructor):");
            student1.PrintDetails();

            Student student2 = new Student("Swapnil", true, 22, 15, 'B', 92.5);
            Console.WriteLine("\nDetails of Student 2 (Parameterized constructor):");
            student2.PrintDetails();

            Student student3 = new Student();
            Console.WriteLine("\nEnter details for Student 3: ");
            student3.AcceptDetails();
            Console.WriteLine("\nDetails of Student 3: ");
            student3.PrintDetails();
        }
    }
}