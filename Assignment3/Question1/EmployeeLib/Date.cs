using System;

namespace EmployeeLib
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 1;
            year = 1900;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            get { return day; }
            set { day = value; }

        }
        public int Month
        {
            get { return month; }
            set { month = value; }

        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void AcceptDate()
        {
            Console.Write("Enter Day of Birth: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Enter Month of Birth: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Enter Year of Birth: ");
            year = int.Parse(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine($"{day}/{month}/{year}");
        }

        public bool IsValid()
        {
            if (year < 1900)
                return false;

            if (month < 1 || month > 12)
                return false;

            if (day < 1 || day > DateTime.DaysInMonth(year,month))
                return false;
            return true;
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }

        public static int DifferenceInYears(Date date1, Date date2)
        {
            if (date1.Year < date2.Year)
            {
                return date2.Year - date1.Year;
            }
            else
            {
                return date2.Year - date1.Year;
            }
        }

        public static int operator -(Date date1, Date date2)
        {
            return DifferenceInYears(date1, date2);
        }
    }
}































