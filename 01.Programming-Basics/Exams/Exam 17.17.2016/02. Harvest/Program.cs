using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine()); //X кв.м е лозето
            var y = double.Parse(Console.ReadLine()); //Y грозде за един кв.м 
            var litersWine = double.Parse(Console.ReadLine()); //Z нужни литри вино
            var nWorkers = double.Parse(Console.ReadLine()); //брой работници

            var grapes = x * y;
            var wine = (grapes * 0.4) / 2.5;

            if (wine>=litersWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - litersWine), Math.Ceiling((wine - litersWine)/nWorkers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                    Math.Floor( litersWine-wine));
            }
        }
        
    }
}
