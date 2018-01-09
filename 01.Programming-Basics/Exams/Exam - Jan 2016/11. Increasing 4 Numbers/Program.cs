using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (b - a < 3) 
            {
                Console.WriteLine("No");
                return;
            }
            for (int firstNumber = a; firstNumber <=b ; firstNumber++)
            {
                for (int secondNumber = firstNumber+1; secondNumber <= b; secondNumber++)
                {
                    for (int thirdNumber = secondNumber + 1; thirdNumber <= b; thirdNumber++)
                    {
                        for (int fourthNumber = thirdNumber + 1; fourthNumber <= b; fourthNumber++)
                        {
                            Console.WriteLine("{0} {1} {2} {3}",firstNumber,secondNumber,thirdNumber,fourthNumber);
                        }
                    }
                }
            }
        }
    }
}
