using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');
            int[] num = strings.Select(int.Parse).ToArray();

            var sortedNums = num.OrderByDescending(x =>x);
            var largest3Num = sortedNums.Take(3);

            Console.WriteLine(string.Join(" ", largest3Num));

        }
    }
}
