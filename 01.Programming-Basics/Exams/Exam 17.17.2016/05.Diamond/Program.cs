using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //top
            Console.Write(new string('.', n));
            Console.Write(new string('*', n*3));
            Console.WriteLine(new string('.', n));

            //middle

            var countDotLeftandRight = n - 1;
            var countDotCener = n *3;


            for (int i = 1; i <n; i++)
            {
                Console.Write(new string('.', countDotLeftandRight));
                Console.Write("*");
                Console.Write(new string('.', countDotCener ));
                Console.Write("*");
                Console.WriteLine(new string('.', countDotLeftandRight));

                countDotCener += 2;
                countDotLeftandRight -= 1;

            }
            Console.WriteLine(new string('*', n * 5));

            countDotLeftandRight =  1;
            countDotCener = 5 * n-4;

            //down
            for (int i = 1; i <= 2 * n; i++) 
            {
                Console.Write(new string('.', countDotLeftandRight));
                Console.Write("*");
                Console.Write(new string('.', countDotCener));
                Console.Write("*");
                Console.WriteLine(new string('.', countDotLeftandRight));

                countDotCener -= 2;
                countDotLeftandRight += 1;
            }
            Console.Write(new string('.', n*2+1));
            Console.Write(new string('*', n -2));
            Console.WriteLine(new string('.', n * 2 + 1));
        }
    }
}
