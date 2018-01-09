using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numbers = 1; numbers <= 1000; numbers++)
            {
                if (numbers % 10 == 7)
                {
                    Console.WriteLine(numbers);
                }
            }
        }
    }
}
