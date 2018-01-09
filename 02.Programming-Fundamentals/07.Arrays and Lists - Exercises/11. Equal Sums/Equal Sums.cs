using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            bool sumFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                long leftSum = 0;
                long rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int j = i+1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    sumFound = true;
                    break;
                }
            }
            if (!sumFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
