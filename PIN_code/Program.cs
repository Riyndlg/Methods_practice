using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIN_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter PIN (4 or 6 digits):");
            string pin = Console.ReadLine();
            ValidatePin(pin);
            Console.ReadKey();
        }
        static void ValidatePin(string pin)
        {
            if (((pin.Length == 4) || (pin.Length == 6)) && pin.Any(char.IsLetter))
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
        }
    }
}
