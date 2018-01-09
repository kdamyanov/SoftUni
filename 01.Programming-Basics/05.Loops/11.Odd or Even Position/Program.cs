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



            var n = double.Parse(Console.ReadLine());

            var evenSum = 0.0;
            var evenMax = double.MinValue;
            var evenMin = double.MaxValue;

            var oddSum = 0.0;
            var oddMax = double.MinValue;
            var oddMin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }

            if (n == 0)
            {
                Console.WriteLine("Oddsum = 0, Oddmin = No, Oddmax = No, Evensum = 0, Evenmin = No, Evenmax = No");
            }
            else if (n == 1)
            {
                Console.WriteLine("Oddsum = {0}, Oddmin = {1}, Oddmax = {2}, Evensum = 0, Evenmin = No, Evenmax = No", oddSum, oddMin, oddMax);
            }
            else
            {
                Console.WriteLine("Oddsum = {0}, Oddmin = {1}, Oddmax = {2}, Evensum = {3}, Evenmin = {4}, Evenmax = {5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);


            }
        }
    }
}