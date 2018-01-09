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

            double distanceToCenterA = GetDistanceBetweenTwoPoints(x1, y1, 0, 0);
            double distanceToCenterB = GetDistanceBetweenTwoPoints(x2, y2, 0, 0);
            PrintClosestPointToCenter(x1, y1, x2, y2, distanceToCenterA, distanceToCenterB); 

        }

        static void PrintClosestPointToCenter(double x1, double y1, double x2, double y2, double distanceToCenterA, double distanceToCenterB)
        {
           if (distanceToCenterA < distanceToCenterB)
            {
                Console.WriteLine("({0}, {1})", x1, y1);                
            }
            else if (distanceToCenterA > distanceToCenterB)
            {
                Console.WriteLine("({0}, {1})", x2, y2);               
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);               
            }
        }

        static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }
}
