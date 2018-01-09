using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var minNumber = Math.Min(Math.Min(a, b), c);
            var maxNumber = Math.Max(Math.Max(a, b), c);
            var middleNumber = a + b + c - minNumber - maxNumber;

            if (minNumber+middleNumber==maxNumber)
            {
                Console.WriteLine("{0}+{1}={2}", minNumber , middleNumber , maxNumber);
            }
            else
            {
                Console.WriteLine("No");
            }
        
            
        }
    }
}
