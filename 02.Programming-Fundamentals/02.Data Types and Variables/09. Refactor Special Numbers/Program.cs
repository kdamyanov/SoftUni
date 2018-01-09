using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int kolkko = int.Parse(Console.ReadLine());
            int total = 0; int takova = 0; bool toe = false;
            for (int ch = 1; ch <= kolkko; ch++)
            {
                takova = ch;
                while (ch > 0)
                {
                    total += ch % 10;
                    ch = ch / 10;
                }
                toe = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{takova} -> {toe}");
                total = 0; ch = takova;
            }
        }
    }
}
