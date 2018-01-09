using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Fib(n);

        }

        static void Fib(long n)
        {
            long fib0 = 1;
            long fib1 = 1;
            long fibCurrent = 1;

            for (int i = 1; i < n; i++)
            {
                fib0 = fib1;
                fib1 = fibCurrent;
                fibCurrent = fib0 + fib1;
            }
            Console.WriteLine(fibCurrent);
        }
    }
}
