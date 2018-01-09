using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //top
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <=n- row; col++)
                {
                    Console.Write(" ");
                }
                
                for (int col = 1; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }

            //booton
            for (int row = n-1; row >= 1; row--)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }

                for (int col = 1; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
        }    
    }
}
