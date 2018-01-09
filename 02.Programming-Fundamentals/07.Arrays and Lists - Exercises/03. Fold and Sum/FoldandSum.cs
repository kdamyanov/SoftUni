using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class FoldandSum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int k = input.Length / 4;

            int[] firstRow = new int [2 * k];
            int[] secondRow = new int [2 * k];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = numbers[k - i - 1];
            }

            for (int i = 0; i < k; i++)
            {
                firstRow[k + i] = numbers[4 * k - i - 1];
            }

            for (int i = 0; i < 2 * k; i++) 
            {
                secondRow[i] = numbers[k + i];
            }

            for (int i = 0; i < 2*k; i++)
            {
                Console.Write(firstRow[i] + secondRow[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
