using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();
            PrintFiguresArea(figureType);
        }

        private static void PrintFiguresArea(string figureType)
        {
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                TriangleArea(side, height);
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine("{0:F2}", area);
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = width * height;
                Console.WriteLine("{0:F2}", area);
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI *(radius*radius);
                Console.WriteLine("{0:F2}", area);
            }
        }

        private static void TriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            Console.WriteLine("{0:F2}", area);
        }
    }
}
