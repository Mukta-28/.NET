using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Calculator ===");

            // Ask first number
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Ask operator
            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            // Ask second number
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine(" Error: Cannot divide by zero!");
                    return;
                }
            }
            else
            {
                Console.WriteLine(" Invalid operator!");
                return;
            }

            Console.WriteLine($"Result = {result}");
        }
    }
}

