using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sum of currency to convert:");
            double currency = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter converter value:");
            double converter = double.Parse(Console.ReadLine());
            double result = currency * converter;
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}
