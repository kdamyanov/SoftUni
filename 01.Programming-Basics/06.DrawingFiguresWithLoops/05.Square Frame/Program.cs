using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //top 
            Console.Write("+");
            for (int row = 0; row < n-2; row++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            //midle side

            
            for (int row = 0; row < n-2; row++)
            {
                Console.Write("|");
                for (int col = 0; col < n-2; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            //botton
            Console.Write("+");
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

        }
    }
}
