using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLenght = GetDistanceBetweenTwoPoints(x1, y1, x2, y2);
            double secondLineLenght = GetDistanceBetweenTwoPoints(x3, y3, x4, y4);
                       

            if (firstLineLenght>secondLineLenght)
            {
                PrintLine(x1, y1, x2, y2);
            }
            else
            {
                PrintLine(x3, y3, x4, y4);
            }
        }

        private static void PrintLine(double x1, double y1, double x2, double y2)
        {
            double distanceToCenterA = GetDistanceBetweenTwoPoints(x1, y1, 0, 0);
            double distanceToCenterB = GetDistanceBetweenTwoPoints(x2, y2, 0, 0);

            if (distanceToCenterA < distanceToCenterB)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
            else if (distanceToCenterA > distanceToCenterB)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
        }

        static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }
}
