using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main()
        {
            long n =Math.Abs( long.Parse(Console.ReadLine()));
            string lastDigit = GetLastDigitOfString(n);
            Console.WriteLine(lastDigit);
        }

        static string GetLastDigitOfString(long number)
        {
            string lastDigitString = "";
            long lastDigitInt = number % 10;

            switch (lastDigitInt)
            {
                case 0:
                    lastDigitString ="zero";
                    break;
                case 1:
                    lastDigitString = "one";
                    break;
                case 2:
                    lastDigitString = "two";
                    break;
                case 3:
                    lastDigitString = "three";
                    break;
                case 4:
                    lastDigitString = "four";
                    break;
                case 5:
                    lastDigitString = "five";
                    break;
                case 6:
                    lastDigitString = "six";
                    break;
                case 7:
                    lastDigitString = "seven";
                    break;
                case 8:
                    lastDigitString = "eight";
                    break;
                case 9:
                    lastDigitString = "nine";
                    break;
                default:
                    break;
            }
            return lastDigitString;
        }
    }
}
