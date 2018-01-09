using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cordBoundary = int.Parse(Console.ReadLine());
            var minArea = int.Parse(Console.ReadLine());
            var rectangleFound = false;
            for (int topX = -cordBoundary; topX < cordBoundary; topX++) 
            {
                for (int topY  = -cordBoundary; topY < cordBoundary; topY++)
                {
                    for (int dictanceX = 1; dictanceX <= Math.Abs(topX-cordBoundary); dictanceX++)
                    {
                        for (int dictanceY = 1; dictanceY <= Math.Abs(topY - cordBoundary); dictanceY++)
                        {
                            var area = dictanceX * dictanceY;
                            if (area >= minArea)
                            {
                                rectangleFound = true;
                                Console.WriteLine(
                                    "({0}, {1}) ({2}, {3}) -> {4}",
                                    topX, 
                                    topY, 
                                    topX + dictanceX, 
                                    topY + dictanceY, 
                                    area);
                            }
                        }
                    }
                }
            }
            if (!rectangleFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}

