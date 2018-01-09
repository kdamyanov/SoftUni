using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstPoint = new Point();
            firstPoint.X = firstCircleParams[0];
            firstPoint.Y = firstCircleParams[1];

            Point secondPoint = new Point();
            secondPoint.X = secondCircleParams[0];
            secondPoint.Y = secondCircleParams[1];

            Circle firstCircle = new Circle();
            firstCircle.Radios = firstCircleParams[2];
            firstCircle.Center = firstPoint;

            Circle secondCircle = new Circle();
            secondCircle.Radios = secondCircleParams[2];
            secondCircle.Center = secondPoint;

            if (Circle.Intersect(firstCircle,secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    public class Circle
    {
        public int Radios { get; set; }
        public Point Center { get; set; }

        public static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            int deltaX = Math.Abs(firstCircle.Center.X - secondCircle.Center.X);
            int deltaY = Math.Abs(secondCircle.Center.Y - firstCircle.Center.Y);

            double distance = Math.Sqrt(deltaY*deltaY + deltaX*deltaX);
            int radiusSum = firstCircle.Radios + secondCircle.Radios;
            if (distance <= radiusSum)
            {
                return true;
            }
            return false;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
