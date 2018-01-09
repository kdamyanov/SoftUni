using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var bigElemt = -99999;


            var n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > bigElemt)
                {
                    bigElemt = num;
                }
            }

            var sumMinusBigELement = sum - bigElemt;

            if (bigElemt == sumMinusBigELement)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum ={0}", sumMinusBigELement);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sumMinusBigELement - bigElemt));
            }
        }
    }
}