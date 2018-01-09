using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            var factorial = 1;
            var counter = 1;

            do
            {
                factorial *= counter;
                counter++;
            } while (counter <=n);
            Console.WriteLine(factorial);
        }
    }
}
