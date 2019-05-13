using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camel_casing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text with words delimited by dash/undercore symbols:");
            string text = Console.ReadLine();
            char[] separator = { '-', '_' };
            string[] result = text.Split(separator);
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i].Length > 1)
                {
                    result[i] = result[i].Substring(0, 1).ToUpper() + result[i].Substring(1, result[i].Length - 1);
                }
                else result[i].ToUpper();
            }
            text = string.Join("", result);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
