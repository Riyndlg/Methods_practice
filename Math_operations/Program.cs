using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string operation;
            string choice = "N";
            do
            {
                Console.WriteLine("Enter values for operands:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter symbol for operation (+,-,*,/)");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Add(x, y);
                        break;
                    case "-":
                        Sub(x, y);
                        break;
                    case "*":
                        Mul(x, y);
                        break;
                    case "/":
                        Div(x, y);
                        break;
                    default:
                        Console.WriteLine("You enter the wrong symbol");
                        break;
                }
                Console.WriteLine("Do you want another try? Y/N");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
            } while (choice == "Y");
            Console.ReadKey();
        }
        static void Add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"Result: {result}");
        }
        static void Sub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"Result: {result}");
        }
        static void Mul(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"Result: {result}");
        }
        static void Div(int x, int y)
        {
            if ((x != 0) && (y != 0))
            {
                int result = x / y;
                Console.WriteLine($"Result: {result}");
            }
            else Console.WriteLine("Cannot divide on null");
        }
    }
}
