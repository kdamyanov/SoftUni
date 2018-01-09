using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());  //Обем на басейна в литри.
            var p1 = int.Parse(Console.ReadLine()); //Дебит на първата тръба за час.
            var p2 = int.Parse(Console.ReadLine()); //Дебит на втората тръба за час.
            var h = double.Parse(Console.ReadLine());  //Часовете които работникът отсъства.

            var totalLiters = (p1 + p2)*h;

            if (totalLiters>v)
            {
                var poolOverflows = totalLiters - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,poolOverflows);
            }
            else
            {
                var poolFull = (int)((totalLiters / v) * 100.0);
                var pipeFirst = (int)(((p1*h)/totalLiters) * 100.0);
                var pipeSecond = (int)(((p2 * h) / totalLiters) * 100.0);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", poolFull,pipeFirst,pipeSecond);
            }
        }
    }
}
