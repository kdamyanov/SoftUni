﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
          
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int rndIndex = rnd.Next(words.Length);
                string oldValue = words[i];
                
                words[i] = words[rndIndex];
                words[rndIndex] = oldValue;
            }
            Console.WriteLine(string.Join("\r\n", words));
            
        }
    }
}
