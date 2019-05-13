using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_possible
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 string including only letters from a to z:");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string text = String.Concat(s1, s2);
            string result = DuplicateSymbols(text);
            char[] temp = result.ToCharArray();
            Array.Sort(temp);
            result = new string(temp);
            Console.WriteLine($"Longest(s1, s2) -> {result}");
            Console.ReadKey();
        }
        static string DuplicateSymbols(string text)
        {
            int count = 0;
            string result = "";
            foreach (char c in text)
            {
                count = 0;
                foreach (char c2 in result) //проверка, что символ не является дубликатом
                {
                    if (c2 == c)
                    {
                        count++;
                    }
                }
                if (count < 1) //проверка, что символ не повторялся еще в строке, вместо 1 может быть другое допустимое число дубликатов символа в строке
                {
                    result = result + c;
                }
            }
            return result;
        }
    }
}
