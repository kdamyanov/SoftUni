using System;
using System.Numerics;

class FactorialN
{
    static void Main()
    {
        //Console.WriteLine("Enter n! - from 0 to 100: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial= FactorialCalculation(n);
        Console.WriteLine(factorial);
    }

    private static BigInteger FactorialCalculation(int n)
    {
        BigInteger factorial = 1;
        while (n >= 1) 
        {
            factorial *= n;
            n--;
        }
        return factorial;
    }
}