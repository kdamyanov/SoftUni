using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameters = Console.ReadLine(); // face, space, volume or area


            if (parameters == "face")
            {
                Console.WriteLine("{0:f2}", FindFaceDiagonals(cubeSide));
            }
            else if (parameters == "space")
            {
                Console.WriteLine("{0:f2}", FindSpaceDiagonals(cubeSide));
            }
            else if (parameters == "volume")
            {
                Console.WriteLine("{0:f2}", FindVolume(cubeSide));
            }
            else if (parameters == "area")
            {
                Console.WriteLine("{0:f2}", FindArea(cubeSide));
            }

        }

        static double FindArea(double cubeSide)
        {
            double result = 6 * (cubeSide * cubeSide);

            return result;
        }

        static double FindVolume(double cubeSide)
        {
            double result = cubeSide * cubeSide * cubeSide;
            return result;
        }

        static double FindSpaceDiagonals(double cubeSide)
        {
            double result = Math.Sqrt(3 * (cubeSide * cubeSide));
            return result;
        }

        static double FindFaceDiagonals(double cubeSide)
        {
            double result = Math.Sqrt(2 * (cubeSide * cubeSide));
            return result;
        }
    }
}