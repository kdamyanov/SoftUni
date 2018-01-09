using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RiseToPower(number, power));
        }

        static double RiseToPower(double number, int power)
        {
            double result = 1d;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;

        }
    }
}
