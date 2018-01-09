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

            var stars = 1;

            if (n % 2 == 0)
            {
                stars = 2;
            }

            var outer = new string('-', (n - stars) / 2);
            var middle = new string('*', stars);
            Console.WriteLine("{0}{1}{0}", outer, middle);

            for (; stars <= n - 2; stars += 2)
            {
                outer = new string('-', (n - stars) / 2 - 1);
                middle = new string('-', stars);
                Console.WriteLine("{0}*{1}*{0}", outer, middle);
            }

            stars -= 4;
            for (; stars >= 0; stars -= 2)
            {
                outer = new string('-', (n - stars) / 2 - 1);
                middle = new string('-', stars);
                Console.WriteLine("{0}*{1}*{0}", outer, middle);
            }

            if (n > 1 && n % 2 == 1)
            {
                outer = new string('-', (n - 1) / 2);
                middle = new string('*', 1);
                Console.WriteLine("{0}{1}{0}", outer, middle);
            }

        }
    }
}