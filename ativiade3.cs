using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "---- Calculator Menu ----\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division"
            );

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter two numbers to perform this operation: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($">> {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($">> {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($">> {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine($">> {num1} / {num2} = {num1 / (double)num2}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}