using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            var max = Math.Max(first, second);
            var min = Math.Min(first, second);

            first = min;
            second = max;

            if (point>=first && point<= second)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            var firstDistance = Math.Abs(point - first);
            var secondDistance = Math.Abs(point - second);
            Console.WriteLine(Math.Min(firstDistance,secondDistance));
        }
    }
}
