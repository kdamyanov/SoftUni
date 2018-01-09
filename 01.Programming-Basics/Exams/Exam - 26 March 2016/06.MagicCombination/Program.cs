using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MagicCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var magicNumber = int.Parse(Console.ReadLine());

            for (int number = 100000; number <= 999999; number++)
            {
                var digits = number;
                var product = 1;
                while (digits!=0)
                {
                    var lastDigit = digits % 10;
                    product *= lastDigit;
                    digits /= 10;
                }
                if (product==magicNumber)
                {
                    Console.Write(number+" ");
                }
            }
        }
    }
}
