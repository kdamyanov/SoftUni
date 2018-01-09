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

            var number = 1;

            for (int row = 0; row <= n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(number + " ");
                    if (number >= n)
                    {
                        return;
                    }
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
