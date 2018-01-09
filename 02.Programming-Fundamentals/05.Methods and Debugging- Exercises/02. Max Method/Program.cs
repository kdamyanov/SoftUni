using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int firstMax=GetMax(firstNumber, secondNumber);
            int max = Math.Max(firstMax, thirdNumber);

            Console.WriteLine(max);

        }

        private static int GetMax(int num1, int num2)
        {
            if (num1 > num2 )
            {
                return num1;
            }
            return num2;
            
        }
    }
}
