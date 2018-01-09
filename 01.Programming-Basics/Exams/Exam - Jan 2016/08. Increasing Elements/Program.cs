using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n==0)
            {
                Console.WriteLine(0);
                return;
            }
           
            var maxLenght = 1;
            var currentLenght = 1;

            var previousNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                
                var currentNumber = int.Parse(Console.ReadLine());
                    
                if (currentNumber>previousNumber)
                {
                    currentLenght++;
                }
                else
                {
                    currentLenght = 1;
                }

                if (currentLenght>maxLenght)
                {
                    maxLenght = currentLenght;
                }
                previousNumber = currentNumber;
            }
            Console.WriteLine(maxLenght);
        }
    }
}
