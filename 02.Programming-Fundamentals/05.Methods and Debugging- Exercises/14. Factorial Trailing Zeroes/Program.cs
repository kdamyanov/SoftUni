using System;
using System.Numerics;

class FactorialN
{
    static void Main()
    {
        //Console.WriteLine("Enter n! - from 0 to 100: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = FactorialCalculation(n);
        BigInteger countsTrailingZeroes = CountsTrailingZeroes(factorial);
        Console.WriteLine(countsTrailingZeroes);

    }

    private static BigInteger CountsTrailingZeroes(BigInteger factorial)
    {
        int count = 0;
        while (factorial > 0)
        {
            BigInteger lastDigitInt = factorial % 10;
            if (lastDigitInt == 0)
            {
                count += 1;
                factorial /= 10;
            }
            else if (lastDigitInt != 0)
            {
                break;
            }
        }
        return count;
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