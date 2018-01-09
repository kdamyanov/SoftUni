using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            bool foundSum = false;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++) 
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[i]+numbers[j]==numbers[k])
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            foundSum = true;
                            break;
                        }
                    }
                }
            }

            if (!foundSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}

