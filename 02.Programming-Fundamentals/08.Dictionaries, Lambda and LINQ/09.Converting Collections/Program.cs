using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Converting_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numsArray = Console.ReadLine()
                                .Split()
                                .Select(number => double.Parse(number))   // = // .Select(double.Parse)
                                .Select(number => number + Math.PI)
                                .ToArray();
            

            List<double> numsList = Console.ReadLine()
                                       .Split()
                                       .Select(double.Parse)
                                       .Select(number=> number+1)
                                       .ToList();

            foreach (var num in numsArray)
            {
                Console.WriteLine(num);
                Console.WriteLine(string.Join(" ", numsList));
            }
        }
    }
}
