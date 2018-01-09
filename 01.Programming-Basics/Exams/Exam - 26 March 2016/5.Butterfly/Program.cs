using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n-2; row++)
            {
                if (row % 2 == 0) 
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', n - 2), "\\"," ","/");
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('-', n - 2), "\\", " ", "/");
                }
            }
            Console.WriteLine("{0}@",new string(' ',n-1));
            for (int row = 0; row < n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', n - 2), "/", " ", "\\");
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('-', n - 2), "/", " ", "\\");
                }
            }
        }
    }
}
