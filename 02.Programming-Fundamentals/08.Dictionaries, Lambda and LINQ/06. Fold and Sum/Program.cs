using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // number 5 2 3 6    
                                                                                                  
            int k = numbers.Length / 4;

            int[] row1Left = numbers.Take(k).Reverse().ToArray(); // 5
            int[] row1Right = numbers.Reverse().Take(k).ToArray(); // 6
            int[] row1 = row1Left.Concat(row1Right).ToArray();  // 5 6
            int[] row2 = numbers.Skip(k).Take(2 * k).ToArray(); // 2 3 

           
            var sumNumbers = row1.Select((x, index) => x + row2[index]);//  = 7  9
            Console.WriteLine(string.Join(" ",sumNumbers));


            //int[] total = new int[k * 2];
           // for (int i = 0; i < row1.Length; i++)
           // {
           //     total[i] = row1[i] + row2[i];
           // }
           //
           // foreach (var sum in total)
           // {
           //     Console.Write($"{sum} ");
           // }
            //Console.WriteLine();
        }
    }
}
