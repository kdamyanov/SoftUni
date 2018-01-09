using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var oddSum = 0;
            var evenSum = 0;
             
            for (int i = 1; i <= count; i++)
            {
                var sum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += sum;
                }
                else
                {
                    oddSum += sum;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", oddSum);
            }
            else  
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
