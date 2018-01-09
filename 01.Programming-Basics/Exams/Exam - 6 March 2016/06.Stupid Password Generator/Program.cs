using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxNumber = int.Parse(Console.ReadLine());
            var maxLetter = int.Parse(Console.ReadLine());

            for (int first = 1; first < maxNumber; first++)
            {
                for (int second = 1; second < maxNumber; second++)
                {
                    for (var third = 'a'; third < 'a' + maxLetter; third++) 
                    {
                        for (var fourth = 'a'; fourth < 'a' + maxLetter; fourth++)
                        {
                            for (int fifth = Math.Max(first, second) + 1; fifth <= maxNumber; fifth++)  
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", first,second,third,fourth,fifth);
                            }
                        }
                    }
                }
            }
        }
    }
}
