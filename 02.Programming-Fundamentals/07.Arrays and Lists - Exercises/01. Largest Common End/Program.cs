using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            int commonElementsLeft = 0;
            int commonElementsRight = 0;

            int shorterLenght = Math.Min(first.Length, second.Length);

            for (int i = 0; i < shorterLenght; i++)
            {
                if (first[i]==second[i])
                {
                    commonElementsLeft++;
                    continue;
                }

                break;
                
            }

            Array.Reverse(first);
            Array.Reverse(second);

            for (int i = 0; i < shorterLenght; i++)
            {
                if (first[i] == second[i])
                {
                    commonElementsRight++;
                    continue;
                }

                break;

            }
            Console.WriteLine(Math.Max(commonElementsLeft,commonElementsRight));
        }
    }
}
