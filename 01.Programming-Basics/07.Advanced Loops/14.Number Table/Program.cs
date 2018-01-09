using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int row = 1; row <= n; row++)
            {
                var number = row;
                var step=+1;
                for (int col = 1; col <= n; col++)
                {
                    Console.Write(number+" ");
                    if (number>=n)
                    {
                        step = -1;
                    }
                    number += step;
                }
                Console.WriteLine();
            }
        }
    }
}
