using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Method_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(1,10);
        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
