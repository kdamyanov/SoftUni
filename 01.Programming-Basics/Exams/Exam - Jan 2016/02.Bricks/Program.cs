using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine()); //Броят тухли
            var w = int.Parse(Console.ReadLine()); //Броят работници
            var m = int.Parse(Console.ReadLine()); //Вместимостта на количката

            var total = w * m *1.0; //общ брой тухли

            Console.WriteLine(Math.Ceiling(x / total*1.0));
        }
        
    }
}
