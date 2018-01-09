using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var sum = 0;
            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] == 'a') sum += 1;
                if (text[index] == 'e') sum += 2;
                if (text[index] == 'i') sum += 3;
                if (text[index] == 'o') sum += 4;
                if (text[index] == 'u') sum += 5;
            }

            Console.WriteLine("Vowels sum= {0}", sum);
        }
    }
}
