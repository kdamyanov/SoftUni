using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLetters = Console.ReadLine().Split();
            string[] secondLetters = Console.ReadLine().Split();

            List<char> chars = new List<char>();
            List<char> secondChars = new List<char>();

            for (int i = 0; i < firstLetters.Length; i++)
            {
                chars.Add(char.Parse(firstLetters[i]));
            }

            for (int i = 0; i < secondLetters.Length; i++)
            {
                secondChars.Add(char.Parse(secondLetters[i]));
            }
            int lenght = Math.Min(chars.Count, secondChars.Count);

            bool areDifferent = false;

            for (int i = 0; i < lenght; i++)
            {
                if (chars[i] > secondChars[i]) 
                {
                    Console.WriteLine(string.Join("", secondChars));
                    Console.WriteLine(string.Join("", chars));
                    areDifferent = true;
                    break;
                }
                else if (chars[i] < secondChars[i])
                {
                    Console.WriteLine(string.Join("", chars));
                    Console.WriteLine(string.Join("", secondChars));
                    areDifferent = true;
                    break;
                }
            }
            if (!areDifferent)
            {
                if (chars.Count <= secondChars.Count)
                {
                    Console.WriteLine(string.Join("", chars));
                    Console.WriteLine(string.Join("", secondChars));
                }
                else
                {
                    Console.WriteLine(string.Join("", secondChars));
                    Console.WriteLine(string.Join("", chars));
                }
            }
        }
    }
}
