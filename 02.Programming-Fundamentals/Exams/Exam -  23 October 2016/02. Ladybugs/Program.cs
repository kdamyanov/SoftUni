using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int sizeField = int.Parse(Console.ReadLine());

        List<string> input = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();


        string[] command = Console.ReadLine().Split();

        int index = 0;
        int flyLenght = 0;
        List<string> currList = new List<string>();


        while (!command[0].Equals("end"))
        {
            switch (command[1])
            {
                case "left":
                    index = int.Parse(command[0]);
                    flyLenght = int.Parse(command[2]);

                    break;

                case "right":
                    index = int.Parse(command[2]);
                    flyLenght = int.Parse(command[4]);

                    for (int i = 0; i < (count % input.Count); i++)
                    {
                        string element = input[input.Count - 1];

                        input.RemoveAt(input.Count - 1);
                        input.Insert(0, element);
                    }
                    break;

                default:
                    break;
            }
            command = Console.ReadLine().Split();
        }
        Console.WriteLine(string.Join(" ", input));
    }
}

