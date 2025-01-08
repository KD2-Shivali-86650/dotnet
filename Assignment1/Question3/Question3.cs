﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Question3
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                Console.WriteLine("\nBasic calculator");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction(-)");
                Console.WriteLine("3. Multiplication(*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == '5')
                {
                    Console.WriteLine("Exiting the calculator. GoodBye!!");
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (choice)
                {
                    case '1':
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case '2':
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case '3':
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case '4':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.Write("\nDo you want to perform another calculation? (y/n): ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (choice == 'y' || choice == 'Y');

            Console.WriteLine("Calculator terminated. Have a great day!");
        }
    }





}
  