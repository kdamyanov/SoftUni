using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int starsCount;
            if (n % 2 == 0)
            {
                starsCount = 2;
            }
            else
            {
                starsCount = 1;
            }
            int linesCount = (n - starsCount) / 2;
            Console.Write(new string('-', linesCount));
            Console.Write(new string('*', starsCount));
            Console.WriteLine(new string('-', linesCount));

            for (int i = 1; i < (n + 1) / 2; i++)
            {
                starsCount = starsCount + 2;
                linesCount = linesCount - 1;
                Console.Write(new string('-', linesCount));
                Console.Write(new string('*', starsCount));
                Console.WriteLine(new string('-', linesCount));
            }

            for (int i = 0; i <= n/2-1; i++)
            {
                Console.Write('|');
                Console.Write(new string('*',n-2));
                Console.WriteLine('|');
            }
        }
    }
}