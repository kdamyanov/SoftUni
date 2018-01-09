using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;

            var sumSelector = 1;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (sumSelector == 1)
                {
                    sum1 += num;
                    sumSelector++;
                }
                else if (sumSelector == 2)
                {
                    sum2 += num;
                    sumSelector++;
                }
                else if (sumSelector == 3)
                {
                    sum3 += num;
                    sumSelector++;
                    sumSelector = 1;
                }
                
            }
            


            Console.WriteLine("sum1={0}",sum1);
            Console.WriteLine("sum2={0}",sum2);
            Console.WriteLine("sum3={0}",sum3);
        }
    }
}
