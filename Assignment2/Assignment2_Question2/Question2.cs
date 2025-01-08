using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
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

    internal class Question2
    {
        static void Main(string[] args)
        {
            Student[] students = null;

            // Create, Accept, Print, Reverse, and Print Reversed Array
            CreateArray(ref students);
            AcceptInfo(students);
            Console.WriteLine("\nOriginal Student Array:");
            PrintInfo(students);

            Student[] reversedStudents = null;
            ReverseArray(students, ref reversedStudents);
            Console.WriteLine("\nReversed Student Array:");
            PrintInfo(reversedStudents);
        }

        // Static Function to Create Array
        static void CreateArray(ref Student[] students)
        {
            Console.Write("Enter the number of students: ");
            int size = int.Parse(Console.ReadLine());
            students = new Student[size];
        }

        // Static Function to Accept Student Information
        static void AcceptInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");
                students[i].AcceptDetails();
            }
        }

        // Static Function to Print Student Array
        static void PrintInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nStudent {i + 1} Details:");
                students[i].PrintDetails();
            }
        }

        // Static Function to Reverse Array
        static void ReverseArray(Student[] original, ref Student[] reversed)
        {
            reversed = new Student[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                reversed[i] = original[original.Length - 1 - i];
            }
        }
    }
}



