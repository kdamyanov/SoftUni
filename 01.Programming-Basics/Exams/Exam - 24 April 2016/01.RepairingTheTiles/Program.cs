using System;

class TileRepairment
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine()); //дължината на страна от площадката 
        double w = double.Parse(Console.ReadLine()); //широчината на една плочка
        double h = double.Parse(Console.ReadLine()); //дължината на една плочка
        double a = double.Parse(Console.ReadLine()); //широчината на пейката 
        double b = double.Parse(Console.ReadLine()); //дължината на пейката

        double area = n * n;
        double areaToRepair = area - (a * b); //площа на площадката - пейката

        double tiles = areaToRepair / (w * h);

        double minutes = tiles * 0.2;

        Console.WriteLine(tiles);
        Console.WriteLine(minutes);

    }
}

