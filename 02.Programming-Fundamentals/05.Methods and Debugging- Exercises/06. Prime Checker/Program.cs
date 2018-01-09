using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool isPrime= IsPrime(n);
            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long n)
        {
            if (n==0 || n==1)
            {
                return false;
            }
            for (long diveder = 2; diveder <= Math.Sqrt(n); diveder++)
            {
                if (n % diveder == 0)
                {
                    return false;                    
                }                
            }

            return true;
        }
    }
}
