using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LineNumbers
{
    static void Main()
    {
        string[] text = File.ReadAllLines("input.txt");

        for (int i = 0; i < text.Length; i++)
        {
            File.AppendAllText("output.txt",
              $"{i + 1}. {text[i]}\r\n");
        }
    }
}
