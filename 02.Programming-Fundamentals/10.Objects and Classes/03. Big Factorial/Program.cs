using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;

            for (int i = 2; i <= num; i++)
            {
                factoriel*=i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
