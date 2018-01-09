using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class OddLines
{
    static void Main()
    {
        string[] text = File.ReadAllLines("input.txt");
        File.WriteAllText("output.txt","");
        for (int i = 0; i < text.Length; i++)
        {
            if (i%2 != 0) 
            {
                File.AppendAllText("output.txt",text[i]+"\r\n");
            }
        }
      
    } 
}

