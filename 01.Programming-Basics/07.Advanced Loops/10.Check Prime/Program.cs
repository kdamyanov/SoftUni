using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number <= 1) 
            {
                Console.WriteLine("Not prime");
            }

            var isPrime = true;

            for (int devisor = 2; devisor <= Math.Sqrt(number); devisor++)
            {
                if (number % devisor == 0) 
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
