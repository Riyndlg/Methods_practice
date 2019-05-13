using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row index: ");
            int index = int.Parse(Console.ReadLine());
            int firstNumber = 1;
            int sum = 0;
            for (int i = 2; i <= index * 2 - 2; i = i + 2)
            {
                firstNumber = firstNumber + i;
            }
            for (int i = 0; i < index; i++)
            {
                sum = sum + firstNumber;
                firstNumber = firstNumber + 2;
            }
            Console.WriteLine($"Row sum for index {index}: {sum}");
            Console.ReadKey();
        }
    }
}
