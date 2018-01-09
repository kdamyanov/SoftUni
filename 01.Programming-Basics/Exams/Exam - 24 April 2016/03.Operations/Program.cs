using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var operation = (Console.ReadLine());

            if (operation=="+")
            {
                var total = n1 + n2;

                if (total % 2 == 0) 
                {
                    Console.WriteLine("{0} + {1} = {2} - even",n1,n2,total);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, total);
                }
            }
            else if (operation == "-")
            {
                var total = n1 - n2;

                if (total % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", n1, n2, total);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, total);
                }
            }
            else if (operation == "*")
            {
                var total = n1 * n2;

                if (total % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", n1, n2, total);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, total);
                }
            }
            else if (operation == "/")
            {
                if (n2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    var total = (double)n1 / n2;
                    Console.WriteLine("{0} / {1} = {2:F2}", n1, n2, total);
                }
                
            }
            else if (operation == "%")
            {
                if (n2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero",n1);
                    
                }
                else
                {
                    var total = n1 % n2;
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, total);
                }
            }
        }
    }
}
