using System;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    public class CenturiesToNanoseconds
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            ulong microseconds = (ulong)(milliseconds * 1000);
            BigInteger nanoseconds = BigInteger.Multiply(microseconds, 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
